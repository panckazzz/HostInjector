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
    public partial class FormRender : Form
    {
        public FormRender()
        {
            InitializeComponent();
        }
        public FormRender(string doc)
        {
            InitializeComponent();
            this.webBrowser1.DocumentText = doc;
        }
        private void FormRender_Load(object sender, EventArgs e)
        {

        }
    }
}
