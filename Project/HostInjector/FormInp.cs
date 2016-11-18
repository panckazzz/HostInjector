using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostInjector
{
    public partial class FormInp : Form
    { 

        public FormInp()
        {
            InitializeComponent();
        }

        public FormInp(string p)
        {
            InitializeComponent();
            this.textBox2.Text = p;
        }
        public string GetInput()
        {
            return textBox2.Text.Trim();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            string s = textBox2.Text.Trim();
            if (s.Length >4 )
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = textBox2.Text.Trim();
            button1.Text=(s.Length>=4)?"Add":"Cancel";

        }
    }
}
