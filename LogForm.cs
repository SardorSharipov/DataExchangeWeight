using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComportProject
{
    public partial class LogForm : Form
    {
        public bool needToClose = false;
        public LogForm()
        {
            InitializeComponent();

            FormClosing += (object sender, FormClosingEventArgs e) =>
            {
                if (!needToClose)
                {
                    e.Cancel = true;
                    Hide();
                }
            };
            hide_button.Click += (object sender, EventArgs e) => Hide();
        }
    }
}
