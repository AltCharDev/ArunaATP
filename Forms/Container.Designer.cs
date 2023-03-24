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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.lblProcessName = new System.Windows.Forms.Label();
            this.processCB = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabPageSpammer = new System.Windows.Forms.TabPage();
            this.tabPageAutobuffSkill = new System.Windows.Forms.TabPage();
            this.atkDefMode = new System.Windows.Forms.TabControl();
            this.tabPageAutobuffStuff = new System.Windows.Forms.TabPage();
            this.tabPageMacroSongs = new System.Windows.Forms.TabPage();
            this.atkDef = new System.Windows.Forms.TabPage();
            this.tabMacroSwitch = new System.Windows.Forms.TabPage();
            this.tabPageProfiles = new System.Windows.Forms.TabPage();
            this.tabArunaFarm = new System.Windows.Forms.TabPage();
            this.cmb_sp = new System.Windows.Forms.ComboBox();
            this.cmb_hp = new System.Windows.Forms.ComboBox();
            this.cmbBullet4 = new System.Windows.Forms.ComboBox();
            this.cmbBullet3 = new System.Windows.Forms.ComboBox();
            this.cmbBullet2 = new System.Windows.Forms.ComboBox();
            this.cmbBullet1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.profileCB = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControlAutopot = new System.Windows.Forms.TabControl();
            this.tabPageAutopot = new System.Windows.Forms.TabPage();
            this.tabPageYggAutopot = new System.Windows.Forms.TabPage();
            this.tabPageSkillTimer = new System.Windows.Forms.TabPage();
            this.atkDefMode.SuspendLayout();
            this.tabArunaFarm.SuspendLayout();
            this.tabControlAutopot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.BackColor = System.Drawing.Color.Black;
            this.lblProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessName.ForeColor = System.Drawing.Color.Red;
            this.lblProcessName.Location = new System.Drawing.Point(16, 11);
            this.lblProcessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(143, 20);
            this.lblProcessName.TabIndex = 3;
            this.lblProcessName.Text = "Ragnarok Client";
            // 
            // processCB
            // 
            this.processCB.FormattingEnabled = true;
            this.processCB.Location = new System.Drawing.Point(23, 36);
            this.processCB.Margin = new System.Windows.Forms.Padding(4);
            this.processCB.Name = "processCB";
            this.processCB.Size = new System.Drawing.Size(244, 24);
            this.processCB.TabIndex = 2;
            this.processCB.SelectedIndexChanged += new System.EventHandler(this.processCB_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(268, 34);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 27);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabPageSpammer
            // 
            this.tabPageSpammer.Location = new System.Drawing.Point(4, 25);
            this.tabPageSpammer.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSpammer.Name = "tabPageSpammer";
            this.tabPageSpammer.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSpammer.Size = new System.Drawing.Size(753, 340);
            this.tabPageSpammer.TabIndex = 1;
            this.tabPageSpammer.Text = "Skill Spammer";
            this.tabPageSpammer.UseVisualStyleBackColor = true;
            // 
            // tabPageAutobuffSkill
            // 
            this.tabPageAutobuffSkill.Location = new System.Drawing.Point(4, 25);
            this.tabPageAutobuffSkill.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAutobuffSkill.Name = "tabPageAutobuffSkill";
            this.tabPageAutobuffSkill.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAutobuffSkill.Size = new System.Drawing.Size(753, 340);
            this.tabPageAutobuffSkill.TabIndex = 3;
            this.tabPageAutobuffSkill.Text = "Autobuff - Skills";
            this.tabPageAutobuffSkill.UseVisualStyleBackColor = true;
            // 
            // atkDefMode
            // 
            this.atkDefMode.Controls.Add(this.tabPageSpammer);
            this.atkDefMode.Controls.Add(this.tabPageAutobuffSkill);
            this.atkDefMode.Controls.Add(this.tabPageAutobuffStuff);
            this.atkDefMode.Controls.Add(this.tabPageMacroSongs);
            this.atkDefMode.Controls.Add(this.atkDef);
            this.atkDefMode.Controls.Add(this.tabMacroSwitch);
            this.atkDefMode.Controls.Add(this.tabPageProfiles);
            this.atkDefMode.Controls.Add(this.tabArunaFarm);
            this.atkDefMode.Location = new System.Drawing.Point(20, 337);
            this.atkDefMode.Margin = new System.Windows.Forms.Padding(4);
            this.atkDefMode.Name = "atkDefMode";
            this.atkDefMode.SelectedIndex = 0;
            this.atkDefMode.Size = new System.Drawing.Size(761, 369);
            this.atkDefMode.TabIndex = 6;
            // 
            // tabPageAutobuffStuff
            // 
            this.tabPageAutobuffStuff.Location = new System.Drawing.Point(4, 25);
            this.tabPageAutobuffStuff.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAutobuffStuff.Name = "tabPageAutobuffStuff";
            this.tabPageAutobuffStuff.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAutobuffStuff.Size = new System.Drawing.Size(753, 340);
            this.tabPageAutobuffStuff.TabIndex = 4;
            this.tabPageAutobuffStuff.Text = "Autobuff - Stuffs";
            this.tabPageAutobuffStuff.UseVisualStyleBackColor = true;
            // 
            // tabPageMacroSongs
            // 
            this.tabPageMacroSongs.Location = new System.Drawing.Point(4, 25);
            this.tabPageMacroSongs.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMacroSongs.Name = "tabPageMacroSongs";
            this.tabPageMacroSongs.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMacroSongs.Size = new System.Drawing.Size(753, 340);
            this.tabPageMacroSongs.TabIndex = 6;
            this.tabPageMacroSongs.Text = "Macro Songs";
            this.tabPageMacroSongs.UseVisualStyleBackColor = true;
            // 
            // atkDef
            // 
            this.atkDef.Location = new System.Drawing.Point(4, 25);
            this.atkDef.Margin = new System.Windows.Forms.Padding(4);
            this.atkDef.Name = "atkDef";
            this.atkDef.Padding = new System.Windows.Forms.Padding(4);
            this.atkDef.Size = new System.Drawing.Size(753, 340);
            this.atkDef.TabIndex = 5;
            this.atkDef.Text = "ATK x DEF Mode";
            this.atkDef.UseVisualStyleBackColor = true;
            // 
            // tabMacroSwitch
            // 
            this.tabMacroSwitch.Location = new System.Drawing.Point(4, 25);
            this.tabMacroSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.tabMacroSwitch.Name = "tabMacroSwitch";
            this.tabMacroSwitch.Padding = new System.Windows.Forms.Padding(4);
            this.tabMacroSwitch.Size = new System.Drawing.Size(753, 340);
            this.tabMacroSwitch.TabIndex = 8;
            this.tabMacroSwitch.Text = "Macro Switch";
            this.tabMacroSwitch.UseVisualStyleBackColor = true;
            // 
            // tabPageProfiles
            // 
            this.tabPageProfiles.Location = new System.Drawing.Point(4, 25);
            this.tabPageProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageProfiles.Name = "tabPageProfiles";
            this.tabPageProfiles.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageProfiles.Size = new System.Drawing.Size(753, 340);
            this.tabPageProfiles.TabIndex = 7;
            this.tabPageProfiles.Text = "Profiles";
            this.tabPageProfiles.UseVisualStyleBackColor = true;
            // 
            // tabArunaFarm
            // 
            this.tabArunaFarm.BackColor = System.Drawing.Color.Black;
            this.tabArunaFarm.Controls.Add(this.cmb_sp);
            this.tabArunaFarm.Controls.Add(this.cmb_hp);
            this.tabArunaFarm.Controls.Add(this.cmbBullet4);
            this.tabArunaFarm.Controls.Add(this.cmbBullet3);
            this.tabArunaFarm.Controls.Add(this.cmbBullet2);
            this.tabArunaFarm.Controls.Add(this.cmbBullet1);
            this.tabArunaFarm.Controls.Add(this.label9);
            this.tabArunaFarm.Controls.Add(this.label4);
            this.tabArunaFarm.Controls.Add(this.label2);
            this.tabArunaFarm.Controls.Add(this.checkBox2);
            this.tabArunaFarm.Controls.Add(this.checkBox1);
            this.tabArunaFarm.Location = new System.Drawing.Point(4, 25);
            this.tabArunaFarm.Name = "tabArunaFarm";
            this.tabArunaFarm.Size = new System.Drawing.Size(753, 340);
            this.tabArunaFarm.TabIndex = 9;
            this.tabArunaFarm.Text = "Aruna Auto Farm";
            // 
            // cmb_sp
            // 
            this.cmb_sp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sp.FormattingEnabled = true;
            this.cmb_sp.Location = new System.Drawing.Point(249, 134);
            this.cmb_sp.Name = "cmb_sp";
            this.cmb_sp.Size = new System.Drawing.Size(57, 24);
            this.cmb_sp.TabIndex = 59;
            // 
            // cmb_hp
            // 
            this.cmb_hp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hp.FormattingEnabled = true;
            this.cmb_hp.Location = new System.Drawing.Point(249, 101);
            this.cmb_hp.Name = "cmb_hp";
            this.cmb_hp.Size = new System.Drawing.Size(57, 24);
            this.cmb_hp.TabIndex = 58;
            // 
            // cmbBullet4
            // 
            this.cmbBullet4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBullet4.FormattingEnabled = true;
            this.cmbBullet4.Location = new System.Drawing.Point(238, 224);
            this.cmbBullet4.Name = "cmbBullet4";
            this.cmbBullet4.Size = new System.Drawing.Size(57, 24);
            this.cmbBullet4.TabIndex = 54;
            // 
            // cmbBullet3
            // 
            this.cmbBullet3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBullet3.FormattingEnabled = true;
            this.cmbBullet3.Location = new System.Drawing.Point(175, 224);
            this.cmbBullet3.Name = "cmbBullet3";
            this.cmbBullet3.Size = new System.Drawing.Size(57, 24);
            this.cmbBullet3.TabIndex = 57;
            // 
            // cmbBullet2
            // 
            this.cmbBullet2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBullet2.FormattingEnabled = true;
            this.cmbBullet2.Location = new System.Drawing.Point(112, 224);
            this.cmbBullet2.Name = "cmbBullet2";
            this.cmbBullet2.Size = new System.Drawing.Size(57, 24);
            this.cmbBullet2.TabIndex = 56;
            // 
            // cmbBullet1
            // 
            this.cmbBullet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBullet1.FormattingEnabled = true;
            this.cmbBullet1.Location = new System.Drawing.Point(42, 224);
            this.cmbBullet1.Name = "cmbBullet1";
            this.cmbBullet1.Size = new System.Drawing.Size(57, 24);
            this.cmbBullet1.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(40, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Mild Wind/Bullets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(40, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Teleport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Lightning Jolt/Desperado";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Red;
            this.checkBox2.Location = new System.Drawing.Point(194, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Wave Mode";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(43, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Farm Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.BackColor = System.Drawing.Color.Black;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.Red;
            this.labelProfile.Location = new System.Drawing.Point(535, 12);
            this.labelProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(64, 20);
            this.labelProfile.TabIndex = 15;
            this.labelProfile.Text = "Profile";
            // 
            // profileCB
            // 
            this.profileCB.FormattingEnabled = true;
            this.profileCB.Location = new System.Drawing.Point(540, 37);
            this.profileCB.Margin = new System.Windows.Forms.Padding(4);
            this.profileCB.Name = "profileCB";
            this.profileCB.Size = new System.Drawing.Size(240, 24);
            this.profileCB.TabIndex = 14;
            this.profileCB.SelectedIndexChanged += new System.EventHandler(this.profileCB_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(21, 81);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(757, 1);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.BackColor = System.Drawing.Color.Black;
            this.lblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.ForeColor = System.Drawing.Color.Red;
            this.lblCharacterName.Location = new System.Drawing.Point(483, 258);
            this.lblCharacterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(123, 16);
            this.lblCharacterName.TabIndex = 19;
            this.lblCharacterName.Text = "Character Name:";
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterName.ForeColor = System.Drawing.Color.DarkGreen;
            this.characterName.Location = new System.Drawing.Point(483, 274);
            this.characterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(25, 17);
            this.characterName.TabIndex = 20;
            this.characterName.Text = "- -";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(403, 102);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 222);
            this.panel5.TabIndex = 18;
            // 
            // tabControlAutopot
            // 
            this.tabControlAutopot.Controls.Add(this.tabPageAutopot);
            this.tabControlAutopot.Controls.Add(this.tabPageYggAutopot);
            this.tabControlAutopot.Controls.Add(this.tabPageSkillTimer);
            this.tabControlAutopot.Location = new System.Drawing.Point(29, 102);
            this.tabControlAutopot.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlAutopot.Name = "tabControlAutopot";
            this.tabControlAutopot.SelectedIndex = 0;
            this.tabControlAutopot.Size = new System.Drawing.Size(272, 156);
            this.tabControlAutopot.TabIndex = 25;
            // 
            // tabPageAutopot
            // 
            this.tabPageAutopot.Location = new System.Drawing.Point(4, 25);
            this.tabPageAutopot.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAutopot.Name = "tabPageAutopot";
            this.tabPageAutopot.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAutopot.Size = new System.Drawing.Size(264, 127);
            this.tabPageAutopot.TabIndex = 0;
            this.tabPageAutopot.Text = "Autopot";
            this.tabPageAutopot.UseVisualStyleBackColor = true;
            // 
            // tabPageYggAutopot
            // 
            this.tabPageYggAutopot.Location = new System.Drawing.Point(4, 25);
            this.tabPageYggAutopot.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageYggAutopot.Name = "tabPageYggAutopot";
            this.tabPageYggAutopot.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageYggAutopot.Size = new System.Drawing.Size(264, 127);
            this.tabPageYggAutopot.TabIndex = 1;
            this.tabPageYggAutopot.Text = "Yggdrasil";
            this.tabPageYggAutopot.UseVisualStyleBackColor = true;
            // 
            // tabPageSkillTimer
            // 
            this.tabPageSkillTimer.Location = new System.Drawing.Point(4, 25);
            this.tabPageSkillTimer.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSkillTimer.Name = "tabPageSkillTimer";
            this.tabPageSkillTimer.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSkillTimer.Size = new System.Drawing.Size(264, 127);
            this.tabPageSkillTimer.TabIndex = 2;
            this.tabPageSkillTimer.Text = "Skill Timer";
            this.tabPageSkillTimer.UseVisualStyleBackColor = true;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 722);
            this.Controls.Add(this.tabControlAutopot);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.profileCB);
            this.Controls.Add(this.atkDefMode);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.processCB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArunafetlzRO - Mod4ROTools";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Container_Load);
            this.Resize += new System.EventHandler(this.containerResize);
            this.atkDefMode.ResumeLayout(false);
            this.tabArunaFarm.ResumeLayout(false);
            this.tabArunaFarm.PerformLayout();
            this.tabControlAutopot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl atkDefMode;
        private System.Windows.Forms.TabPage tabPageSpammer;
        private System.Windows.Forms.Label labelProfile;
        public System.Windows.Forms.ComboBox profileCB;
        private System.Windows.Forms.TabPage tabPageAutobuffSkill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label characterName;
        private Panel panel5;
        private TabPage tabPageAutobuffStuff;
        private TabPage tabPageMacroSongs;
        private TabPage atkDef;
        private TabControl tabControlAutopot;
        private TabPage tabPageAutopot;
        private TabPage tabPageYggAutopot;
        private TabPage tabPageProfiles;
        private TabPage tabMacroSwitch;
        private TabPage tabPageSkillTimer;
        private TabPage tabArunaFarm;
        private ComboBox cmbBullet4;
        private ComboBox cmbBullet3;
        private ComboBox cmbBullet2;
        private ComboBox cmbBullet1;
        private Label label9;
        private Label label4;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox cmb_sp;
        private ComboBox cmb_hp;
    }
}