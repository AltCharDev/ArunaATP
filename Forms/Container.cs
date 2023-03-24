using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using _4RTools.Model;
using _4RTools.Utils;
using System.Configuration;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class Container : Form, IObserver
    {

        private Subject subject = new Subject();
        private String currentProfile;
        Dictionary<string, Keys> dictionary = new Dictionary<string, Keys>();
        private bool dictLoaded { get; set; }
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool PostMessage(IntPtr hWnd, int Msg, Keys wParam, int lParam);
        private Process roProc { get; set; }

        public Container()
        {
            this.subject.Attach(this);

            InitializeComponent();
            this.Text = ConfigurationManager.AppSettings["Name"] + " - " + ConfigurationManager.AppSettings["Version"]; // Window title

            //Container Configuration
            this.IsMdiContainer = true;
            SetBackGroundColorOfMDIForm();

            //Paint Children Forms 
            SetToggleApplicationStateWindow();
            SetAutopotWindow();
            SetAutopotYggWindow();
            SetSkillTimerWindow();
            SetAutoStatusEffectWindow();
            SetAHKWindow();
            SetProfileWindow();
            SetAutobuffStuffWindow();
            SetAutobuffSkillWindow();
            SetSongMacroWindow();
            SetATKDEFWindow();
            SetMacroSwitchWindow();
        }

        public void SetToggleApplicationStateWindow()
        {
            ToggleApplicationStateForm frm = new ToggleApplicationStateForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(350, 70);
            frm.MdiParent = this;
            frm.Show();
        }

        public void SetAutopotWindow()
        {
            AutopotForm frm = new AutopotForm(subject, false);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageAutopot, frm);
        }
        public void SetAutopotYggWindow()
        {
            AutopotForm frm = new AutopotForm(subject, true);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageYggAutopot, frm);
        }

        public void SetSkillTimerWindow()
        {
            SkillTimerForm frm = new SkillTimerForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageSkillTimer, frm);

        }
        public void SetAutoStatusEffectWindow()
        {
            StatusEffectForm form = new StatusEffectForm(subject);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = new Point(50, 220);
            form.MdiParent = this;
            form.Show();
        }

        public void SetAHKWindow()
        {
            AHKForm frm = new AHKForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageSpammer, frm);
        }

        public void SetProfileWindow()
        {
            ProfileForm frm = new ProfileForm(this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageProfiles, frm);
        }

        public void SetAutobuffStuffWindow()
        {
            StuffAutoBuffForm frm = new StuffAutoBuffForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageAutobuffStuff, frm);
        }

        public void SetAutobuffSkillWindow()
        {
            SkillAutoBuffForm frm = new SkillAutoBuffForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabPageAutobuffSkill, frm);
            frm.Show();
        }

        public void SetSongMacroWindow()
        {
            MacroSongForm frm = new MacroSongForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabPageMacroSongs, frm);
            frm.Show();
        }

        public void SetATKDEFWindow()
        {
            ATKDEFForm frm = new ATKDEFForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.atkDef, frm);
            frm.Show();
        }

        public void SetMacroSwitchWindow()
        {
            MacroSwitchForm frm = new MacroSwitchForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabMacroSwitch, frm);
            frm.Show();
        }

        public void addform(TabPage tp, Form f)
        {

            if (!tp.Controls.Contains(f))
            {
                tp.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();
                Refresh();
            }
            Refresh();
        }

        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)
                {
                    ctl.BackColor = Color.White;
                }

            }
        }

        private void processCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client client = new Client(this.processCB.SelectedItem.ToString());
            ClientSingleton.Instance(client);
            characterName.Text = client.ReadCharacterName();
            subject.Notify(new Utils.Message(Utils.MessageCode.PROCESS_CHANGED, null));
        }

        private void Container_Load(object sender, EventArgs e)
        {
            ProfileSingleton.Create("Default");
            this.refreshProcessList();
            this.refreshProfileList();
            this.profileCB.SelectedItem = "Default";
            loadDict();
            Thread waitForProcThread = new Thread(() => waitForProcess());
            waitForProcThread.SetApartmentState(ApartmentState.STA);
            waitForProcThread.Start();
           
        }

        private void waitForProcess()
        {
            while (true)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    if (processCB.Text != "" && processCB.Text != null)
                    {
                        // found proc
                        foreach (Process pc1 in Process.GetProcessesByName(processCB.Text.Split(new string[] { ".exe - " }, StringSplitOptions.None)[0]))
                        {
                            if (pc1.Id == int.Parse(processCB.Text.Split(new string[] { ".exe - " }, StringSplitOptions.None)[1]))
                            {
                                // pId matched
                                roProc = pc1;

                                break;
                            }
                        }

                    }
                });

                if (roProc != null)
                    break;
                Thread.Sleep(1000);

            }
        }
        public void loadDict()
        {
            dictLoaded = false;
            dictionary.Add("F1", Keys.F1);
            dictionary.Add("F2", Keys.F2);
            dictionary.Add("F3", Keys.F3);
            dictionary.Add("F4", Keys.F4);
            dictionary.Add("F5", Keys.F5);
            dictionary.Add("F6", Keys.F6);
            dictionary.Add("F7", Keys.F7);
            dictionary.Add("F8", Keys.F8);
            dictionary.Add("F9", Keys.F9);
            dictionary.Add("1", Keys.D1);
            dictionary.Add("2", Keys.D2);
            dictionary.Add("3", Keys.D3);
            dictionary.Add("4", Keys.D4);
            dictionary.Add("5", Keys.D5);
            dictionary.Add("6", Keys.D6);
            dictionary.Add("7", Keys.D7);
            dictionary.Add("8", Keys.D8);
            dictionary.Add("9", Keys.D9);
            dictionary.Add("0", Keys.D0);
            dictionary.Add("A", Keys.A);
            dictionary.Add("B", Keys.B);
            dictionary.Add("C", Keys.C);
            dictionary.Add("D", Keys.D);
            dictionary.Add("E", Keys.E);
            dictionary.Add("F", Keys.F);
            dictionary.Add("G", Keys.G);
            dictionary.Add("H", Keys.H);
            dictionary.Add("I", Keys.I);
            dictionary.Add("J", Keys.J);
            dictionary.Add("K", Keys.K);
            dictionary.Add("L", Keys.L);
            dictionary.Add("M", Keys.M);
            dictionary.Add("N", Keys.N);
            dictionary.Add("O", Keys.O);
            dictionary.Add("P", Keys.P);
            dictionary.Add("Q", Keys.Q);
            dictionary.Add("R", Keys.R);
            dictionary.Add("S", Keys.S);
            dictionary.Add("T", Keys.T);
            dictionary.Add("U", Keys.U);
            dictionary.Add("V", Keys.V);
            dictionary.Add("W", Keys.W);
            dictionary.Add("X", Keys.X);
            dictionary.Add("Y", Keys.Y);
            dictionary.Add("Z", Keys.Z);

            // ap

            cmb_hp.DataSource = new BindingSource(dictionary, null);
            cmb_hp.ValueMember = "Value";
            cmb_hp.DisplayMember = "Key";
            cmb_hp.SelectedIndex = 7;
            cmb_sp.DataSource = new BindingSource(dictionary, null);
            cmb_sp.ValueMember = "Value";
            cmb_sp.DisplayMember = "Key";
            cmb_sp.SelectedIndex = 8;
            cmbBullet1.DataSource = new BindingSource(dictionary, null);
            cmbBullet1.ValueMember = "Value";
            cmbBullet1.DisplayMember = "Key";
            cmbBullet1.SelectedIndex = 9;
            cmbBullet2.DataSource = new BindingSource(dictionary, null);
            cmbBullet2.ValueMember = "Value";
            cmbBullet2.DisplayMember = "Key";
            cmbBullet2.SelectedIndex = 10;
            cmbBullet3.DataSource = new BindingSource(dictionary, null);
            cmbBullet3.ValueMember = "Value";
            cmbBullet3.DisplayMember = "Key";
            cmbBullet3.SelectedIndex = 11;
            cmbBullet4.DataSource = new BindingSource(dictionary, null);
            cmbBullet4.ValueMember = "Value";
            cmbBullet4.DisplayMember = "Key";
            cmbBullet4.SelectedIndex = 12;
            
        }
        public void refreshProfileList()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.profileCB.Items.Clear();
            });
            foreach (string p in Profile.ListAll())
            {
                this.profileCB.Items.Add(p);
            }
        }

        private void refreshProcessList()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.processCB.Items.Clear();
            });
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle != "" && ClientListSingleton.ExistsByProcessName(p.ProcessName))
                {
                    this.processCB.Items.Add(string.Format("{0}.exe - {1}", p.ProcessName, p.Id));
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshProcessList();
        }

        protected override void OnClosed(EventArgs e)
        {
            ShutdownApplication();
            base.OnClosed(e);
        }

        private void ShutdownApplication()
        {
            KeyboardHook.Disable();
            subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
            Environment.Exit(0);
        }

        private void lblLinkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["GithubLink"]);
        }

        private void lblLinkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["DiscordLink"]);
        }

        private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["4RToolsWebsite"]);
        }

        private void profileCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.profileCB.Text != currentProfile)
            {
                try
                {
                    ProfileSingleton.Load(this.profileCB.Text); //LOAD PROFILE
                    subject.Notify(new Utils.Message(MessageCode.PROFILE_CHANGED, null));
                    currentProfile = this.profileCB.Text.ToString();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.TURN_ON: case MessageCode.PROFILE_CHANGED:
                    Client client = ClientSingleton.GetClient();
                    if (client != null)
                    {
                        characterName.Text = ClientSingleton.GetClient().ReadCharacterName();
                    }
                    break;
                case MessageCode.CLICK_ICON_TRAY:
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    break;
                case MessageCode.SHUTDOWN_APPLICATION:
                    this.ShutdownApplication();
                    break;
            }
        }

        private void containerResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) { this.Hide(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBox1.Checked == true)
            {
                Application.DoEvents();
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // keydown
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(500);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_sp.SelectedValue, 0); // keydown
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_sp.SelectedValue, 0);
                Thread.Sleep(500);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
            while (checkBox2.Checked == true)
            {
                Application.DoEvents();
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(150);
                Application.DoEvents();
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmbBullet1.SelectedValue, 0);
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmbBullet1.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmbBullet1.SelectedValue, 0);
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmbBullet1.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(150);
                Application.DoEvents();
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmbBullet2.SelectedValue, 0);
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmbBullet2.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmbBullet2.SelectedValue, 0);
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmbBullet2.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(150);
                Application.DoEvents();
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmbBullet3.SelectedValue, 0);
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmbBullet3.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmbBullet3.SelectedValue, 0);
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmbBullet3.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmb_hp.SelectedValue, 0); // 
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmb_hp.SelectedValue, 0);
                Thread.Sleep(150);
                Application.DoEvents();
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmbBullet4.SelectedValue, 0);
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmbBullet4.SelectedValue, 0);
                Thread.Sleep(100);
                PostMessage(roProc.MainWindowHandle, 0x100, (Keys)cmbBullet4.SelectedValue, 0);
                PostMessage(roProc.MainWindowHandle, 0x101, (Keys)cmbBullet4.SelectedValue, 0);
                Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        

    }
}
