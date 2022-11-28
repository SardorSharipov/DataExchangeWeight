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
    public partial class SettingsForm : Form
    {
        Data dataChanged = new Data();
        bool isAccess = false;
        public SettingsForm(LoginForm loginForm, MainForm form)
        {
            InitializeComponent();
            loginForm.Hide();
            form.Show();
            FormClosing += (object sender, FormClosingEventArgs e) =>
            {
                form.dataGridView1.DataSource = null;
                form.dataGridView1.DataSource = ParsedData.data;
                ParsedData.WriteDataToExcel();
                loginForm.Close();
            };
            save_exit_button.Click += (object sender, EventArgs e) =>
            {
                Close();
            };

            add_button.Click += (object sender, EventArgs e) =>
            {
                FillData();
                if (dataChanged != null)
                {
                    if (ParsedData.data.Contains(dataChanged))
                    {
                        var needToEdit = ParsedData.data.First(x => x.Equals(dataChanged));
                        ParsedData.data.Remove(needToEdit);
                        needToEdit.EditData(dataChanged);
                        ParsedData.data.Add(needToEdit);
                    }
                    else
                    {
                        //dataChanged.LastValueSetNow();
                        ParsedData.data.Add(dataChanged);
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ParsedData.data;


                    ip_textbox.Text = "";
                    db_textbox.Text = "";
                    sqlTable_textbox.Text = "";
                    inn_textbox.Text = "";
                    equipNum_textbox.Text = "";
                    typeProduct_cb.SelectedItem = null;
                    login_textbox.Text = "";
                    password_textbox.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker1.Text = DateTime.Now.ToShortDateString();

                }
                else
                {
                    MessageBox.Show("Пустые поля\\неккоректный ввод данных", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            delete_row.Click += (object sender, EventArgs e) =>
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count != 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        Data current = (Data)row.DataBoundItem;
                        ParsedData.data.Remove(current);
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ParsedData.data;
                    dataGridView1.ClearSelection();
                }
            };
            dataGridView1.DataSource = ParsedData.data;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeaderMouseDoubleClick += (object sender, DataGridViewCellMouseEventArgs e) =>
            {
                var curData = (Data)dataGridView1.SelectedRows[0].DataBoundItem;
                ip_textbox.Text = curData.IP;
                db_textbox.Text = curData.DataBase;
                sqlTable_textbox.Text = curData.TableSQL;
                inn_textbox.Text = curData.INN.ToString();
                equipNum_textbox.Text = curData.EquipNum.ToString();
                typeProduct_cb.SelectedItem = curData.TypeProduct.ToString();
                login_textbox.Text = curData.Login;
                password_textbox.Text = curData.Password;
                dateTimePicker1.Value = curData.LastValue;
                dateTimePicker1.Text = curData.LastValue.ToShortDateString();

            };
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

        }


        public void FillData()
        {
            dataChanged = new Data();
            int errors = 0;
            if (ip_textbox.Text.Length != 0 || isAccess)
                dataChanged.IP = ip_textbox.Text;
            else
                errors++;
            if (db_textbox.Text.Length != 0 || isAccess)
                dataChanged.DataBase = db_textbox.Text;
            else
                errors++;
            if (sqlTable_textbox.Text.Length != 0)
                dataChanged.TableSQL = sqlTable_textbox.Text;
            else
                errors++;
            if (inn_textbox.Text.Length != 0 && int.TryParse(inn_textbox.Text, out int current))
                dataChanged.INN = current;
            else
                errors++;
            if (int.TryParse(equipNum_textbox.Text, out int cur))
                dataChanged.EquipNum = cur;
            else
                errors++;
            if (typeProduct_cb.SelectedItem != null)
                dataChanged.TypeProduct = (string)typeProduct_cb.SelectedItem;
            else
                errors++;
            if (login_textbox.Text.Length != 0 || isAccess)
                dataChanged.Login = login_textbox.Text;
            else
                errors++;
            if (password_textbox.Text.Length != 0 || isAccess)
                dataChanged.Password = password_textbox.Text;
            else
                errors++;
            if (dateTimePicker1.Text.Length != 0)
                dataChanged.LastValue = dateTimePicker1.Value;
            else
                errors++;
            if (errors > 0)
            {
                dataChanged = null;
            }

        }

    }
}
