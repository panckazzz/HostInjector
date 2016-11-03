using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HostInjector
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = IsValidDomain(textBox1.Text);
            comboBox1.Items.Clear();
            string h =TrimHost( textBox1.Text.Trim().Replace(" ", ""));
            //string tmp="";
            //foreach(char c in h)
            //    if ((c=='.')||(c>='0'&& c<='9')||((c>='A' && c<='z')))
            //        tmp+=c.ToString();
            //h=tmp;

            comboBox1.Items.Add(h + ".evil.net");
            comboBox1.Items.Add(h+  ".evil.net"+h);
            comboBox1.Items.Add(h+  ":80.evil.net");
            comboBox1.Items.Add(h + "@evil.net");
            comboBox1.Items.Add(h + ":80.evil.net"+h);
            comboBox1.Items.Add(h + "@evil.net"+h);
            comboBox1.Items.Add("%55" + h);
            comboBox1.Items.Add("%%35%%36." + h);
            comboBox1.SelectedIndex = 0;


        }

        private bool IsValidDomain(string p)
        {
            return p.Length > 3;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += " v."+Program.version+" Beta";
            this.MinimumSize = this.Size;
            textBox1.Text = "google.com";
            try
            {

                string last = System.IO.File.ReadAllText("last.host").Trim();
                if (last.Length > 2)
                    textBox1.Text = last;
            }
            catch { }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string ResponseMessage="";
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("invalid domain");
                return;
            }
            richTextBoxResponseResult.Text = "";
            labelStatue.Text = "";
            try
            {
                this.counter++;
                string url = textBox1.Text;
                string domain = TrimHost(textBox1.Text);

                storeLastHost(domain);
                if (textBox1.Text.StartsWith("http://") == false && textBox1.Text.StartsWith("https") == false)
                    url = "http"+(checkBoxHTTPs.Checked?"s":"")+"://" + url;
                var req = (HttpWebRequest)WebRequest.Create(url);
                req.AllowAutoRedirect = false;
                req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:49.0) Gecko/20100101 Firefox/49.0";
                req.Host= comboBox1.SelectedItem.ToString();
               
            
                var res = (HttpWebResponse)req.GetResponse();
                string stcod = ((int)res.StatusCode).ToString();
                string stDesc = res.StatusDescription;
                ResponseMessage = "HTTP/1.1 "+(stcod+" "+stDesc) +"\n";
                for (int i = 0; i < res.Headers.Count; i++)
                {
                    try{
                    string k=res.Headers.GetKey(i);
                    string v=res.Headers[k];
                    ResponseMessage += k + ": " + v + "\n";
                    }catch{}
                }
                ResponseMessage += "\n";
                StreamReader s = new StreamReader(res.GetResponseStream());
                this.CurrentBody += s.ReadToEnd();
                ResponseMessage += "\n\n" + this.CurrentBody;
                richTextBoxResponseResult.Text = ResponseMessage;
                labelStatue.Text = "[" + this.counter.ToString() + "] success";
            }
            catch (Exception x)
            {
                labelStatue.Text = x.Message;
                string code = ExtractCode(x.Message);
                try
                {
                    var s = (x as System.Net.WebException).Response;
                    var sc = s.GetResponseStream();
                    string body = new StreamReader(sc).ReadToEnd();
                    string responseMessage = "HTTP/1.1 "+(code)+"\n";
                    for (int i = 0; i < s.Headers.Count; i++)
                    {
                        try
                        {
                            string k = s.Headers.GetKey(i);
                            string v = s.Headers[k];
                            responseMessage += k + ": " + v + "\n";
                        }
                        catch { }
                    }
                    this.CurrentBody = body;
                    responseMessage = responseMessage + "\n\n" + body;
                    richTextBoxResponseResult.Text = responseMessage;
                    labelStatue.Text = "["+this.counter.ToString()+"] success";


                }
                catch(Exception xsa) { labelStatue.Text = "["+this.counter.ToString()+"] Error "+xsa.Message; }

            }
           
        }

        private void storeLastHost(string h)
        {
            try
            {
                System.IO.File.WriteAllText("Last.host", h);
            }
            catch { }
        }

        private string TrimHost(string p)
        {
            p = p.ToLower();
            if (p.ToLower().Contains("http://"))
                p = p.Replace("http://", "");
            if (p.ToLower().Contains("https://"))
                p = p.Replace("https://", "");
            string ptrn = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.1234567890";
            string res = "";
            foreach (char c in p)
            {
                if (ptrn.Contains(c))
                    res += c.ToString();
                else
                    break;
            }
            return res;

        }
        private int counter=0;
        private string ExtractCode(string p)
        {
            //The remote server returned an error: (402) Payment Required.

            if (p.Contains("error: ("))
            {
                return p.Split(new string[] { "error: (", ")" }, StringSplitOptions.RemoveEmptyEntries)[1];

               
            }
            else return "";
        }

        public string CurrentBody ="";

        private void richTextBoxResponseResult_TextChanged(object sender, EventArgs e)
        {
            linkLabelRender.Visible = richTextBoxResponseResult.TextLength > 4;
            bool b2 = richTextBoxResponseResult.Text.Contains("Location: " + comboBox1.SelectedItem.ToString());
            bool b3 = richTextBoxResponseResult.Text.Contains("Location: http://" + comboBox1.SelectedItem.ToString());
            bool b4 = richTextBoxResponseResult.Text.Contains("Location: https://" + comboBox1.SelectedItem.ToString());
            labelVulnerable.Visible = b2||b3||b4;

        }

        private void linkLabelRender_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRender f = new FormRender(this.CurrentBody);
            f.Icon = this.Icon;
            f.Show();
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAbout a = new FormAbout();
            a.Icon = this.Icon;
            a.ShowDialog();
        } 
    }
}
