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
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelCustomHeader = new System.Windows.Forms.LinkLabel();
            this.labelFilteredHost = new System.Windows.Forms.Label();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVulnerable = new System.Windows.Forms.Label();
            this.linkLabelRender = new System.Windows.Forms.LinkLabel();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.checkBoxHTTPs = new System.Windows.Forms.CheckBox();
            this.labelStatue = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBoxResponseResult = new System.Windows.Forms.RichTextBox();
            this.labelBanner = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.labelBanner);
            this.panel1.Controls.Add(this.textBoxPage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.linkLabelCustomHeader);
            this.panel1.Controls.Add(this.labelFilteredHost);
            this.panel1.Controls.Add(this.textBoxMethod);
            this.panel1.Controls.Add(this.label2);
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
            this.panel1.Size = new System.Drawing.Size(662, 438);
            this.panel1.TabIndex = 0;
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(80, 96);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(474, 20);
            this.textBoxPage.TabIndex = 18;
            this.textBoxPage.Text = "index.html";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Page";
            // 
            // linkLabelCustomHeader
            // 
            this.linkLabelCustomHeader.AutoSize = true;
            this.linkLabelCustomHeader.Location = new System.Drawing.Point(540, 127);
            this.linkLabelCustomHeader.Name = "linkLabelCustomHeader";
            this.linkLabelCustomHeader.Size = new System.Drawing.Size(14, 13);
            this.linkLabelCustomHeader.TabIndex = 16;
            this.linkLabelCustomHeader.TabStop = true;
            this.linkLabelCustomHeader.Text = "C";
            this.linkLabelCustomHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCustomHeader_LinkClicked);
            // 
            // labelFilteredHost
            // 
            this.labelFilteredHost.AutoSize = true;
            this.labelFilteredHost.Location = new System.Drawing.Point(157, 168);
            this.labelFilteredHost.Name = "labelFilteredHost";
            this.labelFilteredHost.Size = new System.Drawing.Size(10, 13);
            this.labelFilteredHost.TabIndex = 15;
            this.labelFilteredHost.Text = ".";
            this.labelFilteredHost.Click += new System.EventHandler(this.labelFilteredHost_Click);
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Location = new System.Drawing.Point(80, 141);
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(400, 20);
            this.textBoxMethod.TabIndex = 14;
            this.textBoxMethod.Text = "GET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Method";
            // 
            // labelVulnerable
            // 
            this.labelVulnerable.AutoSize = true;
            this.labelVulnerable.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelVulnerable.Location = new System.Drawing.Point(270, 416);
            this.labelVulnerable.Name = "labelVulnerable";
            this.labelVulnerable.Size = new System.Drawing.Size(57, 13);
            this.labelVulnerable.TabIndex = 12;
            this.labelVulnerable.Text = "Vulnerable";
            this.labelVulnerable.Visible = false;
            // 
            // linkLabelRender
            // 
            this.linkLabelRender.AutoSize = true;
            this.linkLabelRender.Location = new System.Drawing.Point(614, 417);
            this.linkLabelRender.Name = "linkLabelRender";
            this.linkLabelRender.Size = new System.Drawing.Size(30, 13);
            this.linkLabelRender.TabIndex = 11;
            this.linkLabelRender.TabStop = true;
            this.linkLabelRender.Text = "View";
            this.linkLabelRender.Visible = false;
            this.linkLabelRender.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRender_LinkClicked);
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Location = new System.Drawing.Point(614, 7);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(35, 13);
            this.linkLabelAbout.TabIndex = 10;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "About";
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // checkBoxHTTPs
            // 
            this.checkBoxHTTPs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHTTPs.AutoSize = true;
            this.checkBoxHTTPs.Location = new System.Drawing.Point(494, 147);
            this.checkBoxHTTPs.Name = "checkBoxHTTPs";
            this.checkBoxHTTPs.Size = new System.Drawing.Size(60, 17);
            this.checkBoxHTTPs.TabIndex = 9;
            this.checkBoxHTTPs.Text = "HTTPs";
            this.checkBoxHTTPs.UseVisualStyleBackColor = true;
            // 
            // labelStatue
            // 
            this.labelStatue.AutoSize = true;
            this.labelStatue.Location = new System.Drawing.Point(24, 419);
            this.labelStatue.Name = "labelStatue";
            this.labelStatue.Size = new System.Drawing.Size(24, 13);
            this.labelStatue.TabIndex = 8;
            this.labelStatue.Text = "Idle";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(460, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payload";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domain";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(569, 72);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 92);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Send";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBoxResponseResult
            // 
            this.richTextBoxResponseResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxResponseResult.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxResponseResult.Location = new System.Drawing.Point(23, 180);
            this.richTextBoxResponseResult.Name = "richTextBoxResponseResult";
            this.richTextBoxResponseResult.Size = new System.Drawing.Size(621, 228);
            this.richTextBoxResponseResult.TabIndex = 4;
            this.richTextBoxResponseResult.Text = "";
            this.richTextBoxResponseResult.TextChanged += new System.EventHandler(this.richTextBoxResponseResult_TextChanged);
            // 
            // labelBanner
            // 
            this.labelBanner.AutoSize = true;
            this.labelBanner.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBanner.Location = new System.Drawing.Point(102, 7);
            this.labelBanner.Name = "labelBanner";
            this.labelBanner.Size = new System.Drawing.Size(378, 49);
            this.labelBanner.TabIndex = 19;
            this.labelBanner.Text = "Host Header Injector";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 454);
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
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFilteredHost;
        private System.Windows.Forms.LinkLabel linkLabelCustomHeader;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBanner;
    }
}

