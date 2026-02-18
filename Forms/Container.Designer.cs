using System.Windows.Forms;

namespace _4RTools.Forms
{
    partial class Container
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.lblProcessName = new System.Windows.Forms.Label();
            this.processCB = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.TabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.labelProfile = new System.Windows.Forms.Label();
            this.profileCB = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControlAutopot = new System.Windows.Forms.TabControl();
            this.tabPageAutopot = new System.Windows.Forms.TabPage();
            this.tabPageYggAutopot = new System.Windows.Forms.TabPage();
            this.tabPageProfiles = new System.Windows.Forms.TabPage();
            this.tabMacroSwitch = new System.Windows.Forms.TabPage();
            this.tabPageSpammer = new System.Windows.Forms.TabPage();
            this.tabPageAutobuffStuff = new System.Windows.Forms.TabPage();
            this.tabPageAutobuffSkill = new System.Windows.Forms.TabPage();
            this.atkDefMode = new System.Windows.Forms.TabControl();
            this.tabDebuffRecovery = new System.Windows.Forms.TabPage();
            this.tabSkillTimer = new System.Windows.Forms.TabPage();
            this.tabAtxXDef = new System.Windows.Forms.TabPage();
            this.characterName = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.OnOffPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.QuiverKey = new System.Windows.Forms.TextBox();
            this.quiverLim = new System.Windows.Forms.TextBox();
            this.spBoxLim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.spBoxKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hpBoxKey = new System.Windows.Forms.TextBox();
            this.hpBoxLim = new System.Windows.Forms.TextBox();
            this.tabPageBox = new System.Windows.Forms.TabPage();
            this.tabControlAutopot.SuspendLayout();
            this.atkDefMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProcessName.Location = new System.Drawing.Point(26, 46);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(109, 17);
            this.lblProcessName.TabIndex = 3;
            this.lblProcessName.Text = "Ragnarok Client";
            // 
            // processCB
            // 
            this.processCB.FormattingEnabled = true;
            this.processCB.Location = new System.Drawing.Point(27, 66);
            this.processCB.Name = "processCB";
            this.processCB.Size = new System.Drawing.Size(184, 21);
            this.processCB.TabIndex = 2;
            this.processCB.SelectedIndexChanged += new System.EventHandler(this.processCB_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(211, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(19, 22);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TabControlImageList
            // 
            this.TabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabControlImageList.ImageStream")));
            this.TabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TabControlImageList.Images.SetKeyName(0, "new.png");
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProfile.Location = new System.Drawing.Point(254, 46);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(48, 17);
            this.labelProfile.TabIndex = 15;
            this.labelProfile.Text = "Profile";
            // 
            // profileCB
            // 
            this.profileCB.FormattingEnabled = true;
            this.profileCB.Location = new System.Drawing.Point(258, 66);
            this.profileCB.Name = "profileCB";
            this.profileCB.Size = new System.Drawing.Size(181, 21);
            this.profileCB.TabIndex = 14;
            this.profileCB.SelectedIndexChanged += new System.EventHandler(this.profileCB_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(26, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 1);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(354, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 165);
            this.panel5.TabIndex = 18;
            // 
            // tabControlAutopot
            // 
            this.tabControlAutopot.Controls.Add(this.tabPageAutopot);
            this.tabControlAutopot.Controls.Add(this.tabPageYggAutopot);
            this.tabControlAutopot.ImageList = this.TabControlImageList;
            this.tabControlAutopot.Location = new System.Drawing.Point(25, 120);
            this.tabControlAutopot.Name = "tabControlAutopot";
            this.tabControlAutopot.SelectedIndex = 0;
            this.tabControlAutopot.Size = new System.Drawing.Size(308, 165);
            this.tabControlAutopot.TabIndex = 25;
            // 
            // tabPageAutopot
            // 
            this.tabPageAutopot.BackColor = System.Drawing.Color.Transparent;
            this.tabPageAutopot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAutopot.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutopot.Name = "tabPageAutopot";
            this.tabPageAutopot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutopot.Size = new System.Drawing.Size(300, 139);
            this.tabPageAutopot.TabIndex = 0;
            this.tabPageAutopot.Text = "Autopot";
            // 
            // tabPageYggAutopot
            // 
            this.tabPageYggAutopot.Location = new System.Drawing.Point(4, 22);
            this.tabPageYggAutopot.Name = "tabPageYggAutopot";
            this.tabPageYggAutopot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYggAutopot.Size = new System.Drawing.Size(300, 139);
            this.tabPageYggAutopot.TabIndex = 3;
            this.tabPageYggAutopot.Text = "Yggdrasil";
            this.tabPageYggAutopot.UseVisualStyleBackColor = true;
            // 
            // tabPageProfiles
            // 
            this.tabPageProfiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfiles.Name = "tabPageProfiles";
            this.tabPageProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfiles.Size = new System.Drawing.Size(711, 316);
            this.tabPageProfiles.TabIndex = 7;
            this.tabPageProfiles.Text = "Profiles";
            this.tabPageProfiles.UseVisualStyleBackColor = true;
            // 
            // tabMacroSwitch
            // 
            this.tabMacroSwitch.Location = new System.Drawing.Point(4, 22);
            this.tabMacroSwitch.Name = "tabMacroSwitch";
            this.tabMacroSwitch.Padding = new System.Windows.Forms.Padding(3);
            this.tabMacroSwitch.Size = new System.Drawing.Size(711, 316);
            this.tabMacroSwitch.TabIndex = 8;
            this.tabMacroSwitch.Text = "Macro Switch";
            this.tabMacroSwitch.UseVisualStyleBackColor = true;
            // 
            // tabPageSpammer
            // 
            this.tabPageSpammer.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpammer.Name = "tabPageSpammer";
            this.tabPageSpammer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpammer.Size = new System.Drawing.Size(711, 316);
            this.tabPageSpammer.TabIndex = 1;
            this.tabPageSpammer.Text = "Skill Spammer";
            this.tabPageSpammer.UseVisualStyleBackColor = true;
            // 
            // tabPageAutobuffStuff
            // 
            this.tabPageAutobuffStuff.ImageIndex = 0;
            this.tabPageAutobuffStuff.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutobuffStuff.Name = "tabPageAutobuffStuff";
            this.tabPageAutobuffStuff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutobuffStuff.Size = new System.Drawing.Size(711, 316);
            this.tabPageAutobuffStuff.TabIndex = 4;
            this.tabPageAutobuffStuff.Text = "Autobuff - Stuffs";
            this.tabPageAutobuffStuff.UseVisualStyleBackColor = true;
            // 
            // tabPageAutobuffSkill
            // 
            this.tabPageAutobuffSkill.ImageIndex = 0;
            this.tabPageAutobuffSkill.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutobuffSkill.Name = "tabPageAutobuffSkill";
            this.tabPageAutobuffSkill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutobuffSkill.Size = new System.Drawing.Size(711, 316);
            this.tabPageAutobuffSkill.TabIndex = 3;
            this.tabPageAutobuffSkill.Text = "Autobuff - Skills";
            this.tabPageAutobuffSkill.UseVisualStyleBackColor = true;
            // 
            // atkDefMode
            // 
            this.atkDefMode.Controls.Add(this.tabPageSpammer);
            this.atkDefMode.Controls.Add(this.tabDebuffRecovery);
            this.atkDefMode.Controls.Add(this.tabPageAutobuffSkill);
            this.atkDefMode.Controls.Add(this.tabPageAutobuffStuff);
            this.atkDefMode.Controls.Add(this.tabSkillTimer);
            this.atkDefMode.Controls.Add(this.tabAtxXDef);
            this.atkDefMode.Controls.Add(this.tabMacroSwitch);
            this.atkDefMode.Controls.Add(this.tabPageProfiles);
            this.atkDefMode.Controls.Add(this.tabPageBox);
            this.atkDefMode.Location = new System.Drawing.Point(25, 336);
            this.atkDefMode.Name = "atkDefMode";
            this.atkDefMode.SelectedIndex = 0;
            this.atkDefMode.Size = new System.Drawing.Size(719, 342);
            this.atkDefMode.TabIndex = 4;
            // 
            // tabDebuffRecovery
            // 
            this.tabDebuffRecovery.ImageIndex = 0;
            this.tabDebuffRecovery.Location = new System.Drawing.Point(4, 22);
            this.tabDebuffRecovery.Name = "tabDebuffRecovery";
            this.tabDebuffRecovery.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebuffRecovery.Size = new System.Drawing.Size(711, 316);
            this.tabDebuffRecovery.TabIndex = 2;
            this.tabDebuffRecovery.Text = "Debuff";
            this.tabDebuffRecovery.UseVisualStyleBackColor = true;
            // 
            // tabSkillTimer
            // 
            this.tabSkillTimer.Location = new System.Drawing.Point(4, 22);
            this.tabSkillTimer.Name = "tabSkillTimer";
            this.tabSkillTimer.Size = new System.Drawing.Size(711, 316);
            this.tabSkillTimer.TabIndex = 9;
            this.tabSkillTimer.Text = "Skill Timer";
            this.tabSkillTimer.UseVisualStyleBackColor = true;
            // 
            // tabAtxXDef
            // 
            this.tabAtxXDef.Location = new System.Drawing.Point(4, 22);
            this.tabAtxXDef.Name = "tabAtxXDef";
            this.tabAtxXDef.Size = new System.Drawing.Size(711, 316);
            this.tabAtxXDef.TabIndex = 10;
            this.tabAtxXDef.Text = "Atk x Def";
            this.tabAtxXDef.UseVisualStyleBackColor = true;
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterName.ForeColor = System.Drawing.Color.DarkGreen;
            this.characterName.Location = new System.Drawing.Point(147, 20);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(25, 17);
            this.characterName.TabIndex = 28;
            this.characterName.Text = "- -";
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(26, 20);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(115, 17);
            this.lblCharacterName.TabIndex = 27;
            this.lblCharacterName.Text = "Character Name:";
            // 
            // OnOffPanel
            // 
            this.OnOffPanel.Location = new System.Drawing.Point(373, 120);
            this.OnOffPanel.Name = "OnOffPanel";
            this.OnOffPanel.Size = new System.Drawing.Size(223, 112);
            this.OnOffPanel.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(641, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Website";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 34;
            this.button2.Text = "Discord";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(641, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 24);
            this.button3.TabIndex = 35;
            this.button3.Text = "Facebook";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(641, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 24);
            this.button4.TabIndex = 36;
            this.button4.Text = "Wiki";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // QuiverKey
            // 
            this.QuiverKey.Location = new System.Drawing.Point(420, 242);
            this.QuiverKey.Name = "QuiverKey";
            this.QuiverKey.Size = new System.Drawing.Size(41, 20);
            this.QuiverKey.TabIndex = 37;
            this.QuiverKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quiverLim
            // 
            this.quiverLim.Location = new System.Drawing.Point(467, 242);
            this.quiverLim.Name = "quiverLim";
            this.quiverLim.Size = new System.Drawing.Size(41, 20);
            this.quiverLim.TabIndex = 38;
            // 
            // spBoxLim
            // 
            this.spBoxLim.Location = new System.Drawing.Point(467, 272);
            this.spBoxLim.Name = "spBoxLim";
            this.spBoxLim.Size = new System.Drawing.Size(41, 20);
            this.spBoxLim.TabIndex = 39;
            this.spBoxLim.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Quiver";
            // 
            // spBoxKey
            // 
            this.spBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.spBoxKey.Location = new System.Drawing.Point(420, 268);
            this.spBoxKey.Name = "spBoxKey";
            this.spBoxKey.Size = new System.Drawing.Size(41, 23);
            this.spBoxKey.TabIndex = 44;
            this.spBoxKey.TextChanged += new System.EventHandler(this.spBoxKey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "SP Box";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "HP Box";
            // 
            // hpBoxKey
            // 
            this.hpBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hpBoxKey.Location = new System.Drawing.Point(420, 297);
            this.hpBoxKey.Name = "hpBoxKey";
            this.hpBoxKey.Size = new System.Drawing.Size(41, 23);
            this.hpBoxKey.TabIndex = 47;
            // 
            // hpBoxLim
            // 
            this.hpBoxLim.Location = new System.Drawing.Point(467, 300);
            this.hpBoxLim.Name = "hpBoxLim";
            this.hpBoxLim.Size = new System.Drawing.Size(41, 20);
            this.hpBoxLim.TabIndex = 48;
            // 
            // tabPageBox
            // 
            this.tabPageBox.Location = new System.Drawing.Point(4, 22);
            this.tabPageBox.Name = "tabPageBox";
            this.tabPageBox.Size = new System.Drawing.Size(711, 316);
            this.tabPageBox.TabIndex = 11;
            this.tabPageBox.Text = "Box";
            this.tabPageBox.UseVisualStyleBackColor = true;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 693);
            this.Controls.Add(this.hpBoxLim);
            this.Controls.Add(this.hpBoxKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spBoxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spBoxLim);
            this.Controls.Add(this.quiverLim);
            this.Controls.Add(this.QuiverKey);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.OnOffPanel);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.tabControlAutopot);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.profileCB);
            this.Controls.Add(this.atkDefMode);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.processCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArunafeltzRO 4RTools";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Container_Load);
            this.Resize += new System.EventHandler(this.containerResize);
            this.tabControlAutopot.ResumeLayout(false);
            this.atkDefMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelProfile;
        public System.Windows.Forms.ComboBox profileCB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Panel panel5;
        private TabControl tabControlAutopot;
        private TabPage tabPageAutopot;
        private TabPage tabPageYggAutopot;
        private ImageList TabControlImageList;
        private TabPage tabPageProfiles;
        private TabPage tabMacroSwitch;
        private TabPage tabPageAutobuffStuff;
        private TabPage tabPageAutobuffSkill;
        private TabPage tabPageSpammer;
        private TabControl atkDefMode;
        private Label characterName;
        private Label lblCharacterName;
        private TabPage tabDebuffRecovery;
        private Panel OnOffPanel;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TabPage tabSkillTimer;
        private TabPage tabAtxXDef;
        private TextBox QuiverKey;
        private TextBox quiverLim;
        private TextBox spBoxLim;
        private Label label2;
        private TextBox spBoxKey;
        private Label label3;
        private Label label4;
        private TextBox hpBoxKey;
        private TextBox hpBoxLim;
        private TabPage tabPageBox;
    }
}