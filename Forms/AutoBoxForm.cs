using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class AutoBoxForm : Form, IObserver
    {
        private OpenBox openbox;
        private bool isYgg;
        public AutoBoxForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);

        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    //this.openbox = this.isYgg ? ProfileSingleton.GetCurrent().AutopotYgg : ProfileSingleton.GetCurrent().Autopot;
                    InitializeApplicationForm();
                    break;
                case MessageCode.TURN_OFF:
                    this.openbox.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.openbox.Start();
                    break;
            }
        }

        private void InitializeApplicationForm()
        {
            this.txtHPBoxKey.Text = this.openbox.hpBoxKey.ToString();
            this.txtSPBoxKey.Text = this.openbox.spBoxKey.ToString();
            this.txtHPBoxlim.Text = this.openbox.hpBoxlim.ToString();
            this.txtSPBoxlim.Text = this.openbox.spBoxlim.ToString();
            this.openbox = ProfileSingleton.GetCurrent()?.Autobox ?? new OpenBox(OpenBox.ACTION_NAME_AUTOBOX);

            this.txtHPBoxKey.Text = "None";
            this.txtSPBoxKey.Text = "None";

            txtHPBoxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            txtHPBoxKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            txtHPBoxKey.TextChanged += new EventHandler(this.onHpTextChange);
            txtSPBoxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            txtSPBoxKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            txtSPBoxKey.TextChanged += new EventHandler(this.onSpTextChange);

        }

        private void onHpTextChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtHPBoxKey.Text.ToString());
            this.openbox.hpBoxKey = Key.None;
            this.openbox.hpBoxKey = key;
            ProfileSingleton.SetConfiguration(this.openbox);
        }

        private void onSpTextChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtSPBoxKey.Text.ToString());
            this.openbox.hpBoxKey = Key.None;
            this.openbox.spBoxKey = key;
            ProfileSingleton.SetConfiguration(this.openbox);
        }

        private void txtAutopotSPlimDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.openbox.spBoxlim = Int16.Parse(this.txtSPBoxlim.Text);
                ProfileSingleton.SetConfiguration(this.openbox);
            }
            catch (Exception) { }
        }

        private void txtAutopotHPlimDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.openbox.hpBoxlim = Int16.Parse(this.txtHPBoxlim.Text);
                ProfileSingleton.SetConfiguration(this.openbox);
            }
            catch (Exception) { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AutoBoxForm_Load(object sender, EventArgs e)
        {

        }

        private void txtHpKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
