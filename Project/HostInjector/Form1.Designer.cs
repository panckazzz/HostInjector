namespace HostInjector
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxHTTPs = new System.Windows.Forms.CheckBox();
            this.labelStatue = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBoxResponseResult = new System.Windows.Forms.RichTextBox();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.linkLabelRender = new System.Windows.Forms.LinkLabel();
            this.labelVulnerable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.labelVulnerable);
            this.panel1.Controls.Add(this.linkLabelRender);
            this.panel1.Controls.Add(this.linkLabelAbout);
            this.panel1.Controls.Add(this.checkBoxHTTPs);
            this.panel1.Controls.Add(this.labelStatue);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.richTextBoxResponseResult);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 376);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxHTTPs
            // 
            this.checkBoxHTTPs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHTTPs.AutoSize = true;
            this.checkBoxHTTPs.Location = new System.Drawing.Point(356, 95);
            this.checkBoxHTTPs.Name = "checkBoxHTTPs";
            this.checkBoxHTTPs.Size = new System.Drawing.Size(60, 17);
            this.checkBoxHTTPs.TabIndex = 9;
            this.checkBoxHTTPs.Text = "HTTPs";
            this.checkBoxHTTPs.UseVisualStyleBackColor = true;
            // 
            // labelStatue
            // 
            this.labelStatue.AutoSize = true;
            this.labelStatue.Location = new System.Drawing.Point(5, 356);
            this.labelStatue.Name = "labelStatue";
            this.labelStatue.Size = new System.Drawing.Size(38, 13);
            this.labelStatue.TabIndex = 8;
            this.labelStatue.Text = "Statue";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payload";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domain";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(434, 38);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 55);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "GET";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBoxResponseResult
            // 
            this.richTextBoxResponseResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxResponseResult.Location = new System.Drawing.Point(23, 112);
            this.richTextBoxResponseResult.Name = "richTextBoxResponseResult";
            this.richTextBoxResponseResult.Size = new System.Drawing.Size(487, 234);
            this.richTextBoxResponseResult.TabIndex = 4;
            this.richTextBoxResponseResult.Text = "";
            this.richTextBoxResponseResult.TextChanged += new System.EventHandler(this.richTextBoxResponseResult_TextChanged);
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Location = new System.Drawing.Point(489, 3);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(35, 13);
            this.linkLabelAbout.TabIndex = 10;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "About";
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // linkLabelRender
            // 
            this.linkLabelRender.AutoSize = true;
            this.linkLabelRender.Location = new System.Drawing.Point(479, 349);
            this.linkLabelRender.Name = "linkLabelRender";
            this.linkLabelRender.Size = new System.Drawing.Size(30, 13);
            this.linkLabelRender.TabIndex = 11;
            this.linkLabelRender.TabStop = true;
            this.linkLabelRender.Text = "View";
            this.linkLabelRender.Visible = false;
            this.linkLabelRender.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRender_LinkClicked);
            // 
            // labelVulnerable
            // 
            this.labelVulnerable.AutoSize = true;
            this.labelVulnerable.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelVulnerable.Location = new System.Drawing.Point(266, 351);
            this.labelVulnerable.Name = "labelVulnerable";
            this.labelVulnerable.Size = new System.Drawing.Size(57, 13);
            this.labelVulnerable.TabIndex = 12;
            this.labelVulnerable.Text = "Vulnerable";
            this.labelVulnerable.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 392);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "HTTP Host Injector  ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBoxResponseResult;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelStatue;
        private System.Windows.Forms.CheckBox checkBoxHTTPs;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.LinkLabel linkLabelRender;
        private System.Windows.Forms.Label labelVulnerable;
    }
}

