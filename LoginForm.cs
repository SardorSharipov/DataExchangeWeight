using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComportProject
{
    public partial class LoginForm : Form
    {
        private readonly MainForm form;
        public LoginForm(MainForm mainForm, bool settingSql = false)
        {
            InitializeComponent();
            form = mainForm;
            textBox1.Text = "admin";
            textBox2.PasswordChar = '*';
            textBox2.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    signIn_button.PerformClick();
            };
            FormClosing += (object sender, FormClosingEventArgs e) =>
            {
                mainForm.Show();
            };

            signIn_button.Click += (object sender, EventArgs e) =>
            {
                if (textBox1.Text == "admin" && CheckPassword())
                {
                    if (settingSql)
                    {
                        SettingsMSSql form = new SettingsMSSql(this, this.form);
                        form.Show();
                    }
                    else
                    {
                        SettingsForm form = new SettingsForm(this, this.form);
                        form.Show();
                    }
                }
                else
                    MessageBox.Show("Неверный пароль\\логин", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            textBox2.TabIndex = 0;
        }

        private bool CheckPassword()
        {
            return textBox2.Text.ToLower() == "рокки" || textBox2.Text.ToLower() == "rokki" ||
                textBox2.Text.ToLower() == "cp0983943" || textBox2.Text.ToLower() == "ср0983943" ||
                textBox2.Text == "454043080";
        }

    }
}
