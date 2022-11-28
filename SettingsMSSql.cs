using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComportProject
{
    public partial class SettingsMSSql : Form
    {
        public SettingsMSSql(LoginForm loginForm, MainForm form)
        {
            InitializeComponent();

            loginForm.Hide();
            form.Show();

            textBox1.Text = ParsedData.MS_SQL_SERVER;
            textBox2.Text= ParsedData.MS_SQL_DATABASE;
            textBox3.Text = ParsedData.MS_SQL_TABLE;
            textBox4.Text = ParsedData.MS_SQL_LOGIN;
            textBox5.Text = ParsedData.MS_SQL_PASSWORD;


            FormClosing += (object sender, FormClosingEventArgs e) =>
            {
                loginForm.Close();
            };


            button1.Click += (object sender, EventArgs e) =>
            {
                if (textBox1.Text != String.Empty &&
                textBox2.Text != String.Empty &&
                textBox3.Text != String.Empty &&
                textBox4.Text != String.Empty &&
                textBox5.Text != String.Empty)
                {
                    ParsedData.MS_SQL_SERVER = textBox1.Text;
                    ParsedData.MS_SQL_DATABASE = textBox2.Text;
                    ParsedData.MS_SQL_TABLE = textBox3.Text;
                    ParsedData.MS_SQL_LOGIN = textBox4.Text;
                    ParsedData.MS_SQL_PASSWORD = textBox5.Text;
                    ParsedData.WriteMSSqlDataToExcel();
                    Close();
                }
                else
                {
                    MessageBox.Show("Пустые строки!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }


    }
}
