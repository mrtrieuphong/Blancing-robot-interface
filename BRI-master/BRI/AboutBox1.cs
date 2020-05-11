using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRI
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {

            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://nguyentrieuphong.com");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {}
    }
}
