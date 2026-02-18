namespace _4RTools.Forms
{
    partial class AutoBoxForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuiverKey = new System.Windows.Forms.TextBox();
            this.txtQuiverlim = new System.Windows.Forms.NumericUpDown();
            this.txtHPBoxKey = new System.Windows.Forms.TextBox();
            this.txtHPBoxlim = new System.Windows.Forms.NumericUpDown();
            this.txtSPBoxKey = new System.Windows.Forms.TextBox();
            this.txtSPBoxlim = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuiverlim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHPBoxlim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPBoxlim)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Quiver";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "SP Box";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "HP Box";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQuiverKey
            // 
            this.txtQuiverKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQuiverKey.Location = new System.Drawing.Point(138, 35);
            this.txtQuiverKey.Name = "txtQuiverKey";
            this.txtQuiverKey.Size = new System.Drawing.Size(61, 23);
            this.txtQuiverKey.TabIndex = 50;
            this.txtQuiverKey.Text = "None";
            this.txtQuiverKey.TextChanged += new System.EventHandler(this.txtHpKey_TextChanged);
            // 
            // txtQuiverlim
            // 
            this.txtQuiverlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQuiverlim.Location = new System.Drawing.Point(200, 35);
            this.txtQuiverlim.Name = "txtQuiverlim";
            this.txtQuiverlim.Size = new System.Drawing.Size(44, 23);
            this.txtQuiverlim.TabIndex = 49;
            // 
            // txtHPBoxKey
            // 
            this.txtHPBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHPBoxKey.Location = new System.Drawing.Point(138, 64);
            this.txtHPBoxKey.Name = "txtHPBoxKey";
            this.txtHPBoxKey.Size = new System.Drawing.Size(61, 23);
            this.txtHPBoxKey.TabIndex = 52;
            this.txtHPBoxKey.Text = "None";
            // 
            // txtHPBoxlim
            // 
            this.txtHPBoxlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHPBoxlim.Location = new System.Drawing.Point(200, 64);
            this.txtHPBoxlim.Name = "txtHPBoxlim";
            this.txtHPBoxlim.Size = new System.Drawing.Size(44, 23);
            this.txtHPBoxlim.TabIndex = 51;
            this.txtHPBoxlim.TextChanged += new System.EventHandler(this.txtAutopotHPlimDelayTextChanged);
            // 
            // txtSPBoxKey
            // 
            this.txtSPBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSPBoxKey.Location = new System.Drawing.Point(138, 93);
            this.txtSPBoxKey.Name = "txtSPBoxKey";
            this.txtSPBoxKey.Size = new System.Drawing.Size(61, 23);
            this.txtSPBoxKey.TabIndex = 54;
            this.txtSPBoxKey.Text = "None";
            // 
            // txtSPBoxlim
            // 
            this.txtSPBoxlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSPBoxlim.Location = new System.Drawing.Point(200, 93);
            this.txtSPBoxlim.Name = "txtSPBoxlim";
            this.txtSPBoxlim.Size = new System.Drawing.Size(44, 23);
            this.txtSPBoxlim.TabIndex = 53;
            this.txtSPBoxlim.TextChanged += new System.EventHandler(this.txtAutopotSPlimDelayTextChanged);
            // 
            // AutoBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 152);
            this.Controls.Add(this.txtSPBoxKey);
            this.Controls.Add(this.txtSPBoxlim);
            this.Controls.Add(this.txtHPBoxKey);
            this.Controls.Add(this.txtHPBoxlim);
            this.Controls.Add(this.txtQuiverKey);
            this.Controls.Add(this.txtQuiverlim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoBoxForm";
            this.Text = "AutoBoxForm";
            this.Load += new System.EventHandler(this.AutoBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuiverlim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHPBoxlim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPBoxlim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuiverKey;
        private System.Windows.Forms.NumericUpDown txtQuiverlim;
        private System.Windows.Forms.TextBox txtHPBoxKey;
        private System.Windows.Forms.NumericUpDown txtHPBoxlim;
        private System.Windows.Forms.TextBox txtSPBoxKey;
        private System.Windows.Forms.NumericUpDown txtSPBoxlim;
    }
}