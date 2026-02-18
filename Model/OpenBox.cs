using System;
using System.ComponentModel;
using _4RTools.Utils;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Newtonsoft.Json;

namespace _4RTools.Model
{

    public class OpenBox : Action
    {

        public static string ACTION_NAME_AUTOBOX = "Autobox";

        public Key spBoxKey { get; set; }
        public Key hpBoxKey { get; set; }
        public int spBoxlim { get; set; }
        public int hpBoxlim { get; set; }
        public int delay { get; set; } = 15;
        public int delayYgg { get; set; } = 50;

        public string actionName { get; set; }
        private _4RThread thread;

        public OpenBox() { }
        public OpenBox(string actionName)
        {
            this.actionName = actionName;
        }

        public OpenBox(Key spBoxKey, int spBoxlim, int delay, Key hpBoxKey, int hpBoxlim)
        {
            //this.delay = delay;

            // HP
            this.spBoxKey = spBoxKey;
            this.spBoxlim = spBoxlim;

            // SP
            this.hpBoxKey = hpBoxKey;
            this.hpBoxlim = hpBoxlim;
        }

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if(roClient != null)
            {
                int hpPotCount = 0;
                this.thread = new _4RThread(_ => AutopotThreadExecution(roClient, hpPotCount));
                _4RThread.Start(this.thread);
            }
        }

        private int AutopotThreadExecution(Client roClient, int hpPotCount)
        {
            // check hp first
            if (roClient.IsSpBoxBelow(spBoxlim))
            {
                pot(this.spBoxKey);
                hpPotCount++;

                if (hpPotCount == 3)
                {
                    hpPotCount = 0;
                    if (roClient.IsHpBoxBelow(hpBoxlim))
                    {
                        pot(this.hpBoxKey);
                    }
                }
            }
            // check sp
            if (roClient.IsHpBoxBelow(hpBoxlim))
            {
                pot(this.hpBoxKey);
            }

            Thread.Sleep(this.delay);
            return 0;
        }

        private void pot(Key key)
        {
            Keys k = (Keys)Enum.Parse(typeof(Keys), key.ToString());
            if ((k != Keys.None) && !Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
            {
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, k, 0); // keydown
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYUP_MSG_ID, k, 0); // keyup
            }
        }

        public void Stop()
        {
            _4RThread.Stop(this.thread);
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        public string GetActionName()
        {
            return this.actionName != null ? this.actionName : ACTION_NAME_AUTOBOX;
        }
    }
}
