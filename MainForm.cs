using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComportProject
{
    public partial class MainForm : Form
    {

        static System.Threading.Timer timer;

        public LogForm logForm;

        private static object lockObj = new object();

        static BindingList<string> log = new BindingList<string>();
        static int limit = 100;

        public MainForm()
        {
            InitializeComponent();

            logForm = new LogForm();
            logForm.Hide();
            // Связал свой лог с listBox
            
            logForm.listBox1.DataSource = log;
            log_button.Click += (object sender, EventArgs e) =>
            {
                logForm.Focus();
                logForm.Show();
            };

            checkBox1.Checked = ParsedData.AUTOSTART;

            checkBox1.CheckedChanged += (object sender, EventArgs e) =>
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(File.Create(ParsedData.AUTOSTART_PATH)))
                    {
                        string str = checkBox1.Checked == true ? "TRUE" : "FALSE";
                        writer.WriteLine($"AUTOSTART={str}");
                    }

                }
                catch (Exception) { }
            };

            start_button.Click += StartbuttonClick;

            settings_button.Click += (object sender, EventArgs e) =>
            {
                LoginForm form = new LoginForm(this);
                form.Show();
            };

            try
            {
                ParsedData.data = ParsedData.ParseDataFromExcel();
                if (ParsedData.data == null)
                {
                    Close();
                }
                ParsedData.ParseAdminFromExcel();
                dataGridView1.DataSource = ParsedData.data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.ReadOnly = true;
            //Закрываю все формы и перезаписываю данные в параметрах, только потом закрываю форму

            FormClosing += (object sender, FormClosingEventArgs e) =>
            {
                
                Enabled = false;
                if (start_button.Text == "Стоп")
                {
                    StartbuttonClick(this, EventArgs.Empty);
                }

                logForm.needToClose = true;
                logForm.Close();
            };

            FormClosed += (_, _) =>{
                Environment.Exit(0);
            };
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            settings_mssql.Click += (object sender, EventArgs e) =>
            {
                LoginForm form = new LoginForm(this, settingSql: true);
                form.Show();
            };
            if (checkBox1.Checked)
            {
                StartbuttonClick(this, EventArgs.Empty);
            }
            NotifyApp.DoubleClick += (_, _) =>
            {
                Show();
                WindowState = FormWindowState.Normal;
            };
            Resize += (_, _) =>
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    NotifyApp.BalloonTipTitle = "DataExchangeWeight";
                    NotifyApp.BalloonTipText = "Приложение спрятано";
                    NotifyApp.ShowBalloonTip(1000);
                    logForm.Hide();
                }
            };

            //RegistryKey rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //if (!IsStartupItem())
            //rkApp.SetValue("MyApplication", Application.ExecutablePath.ToString());
            //rkApp.DeleteValue("MyApplication", true);
            //StartbuttonClick(this, EventArgs.Empty);

        }
        private void StartbuttonClick(object sender, EventArgs e)
        {
            // устанавливаем метод обратного вызова
            // создаем таймер
            if (start_button.Text == "Старт")
            {
                if (numericUpDown1.Value > 0)
                {

                    TimerCallback tm = new TimerCallback(TaskManager);
                    start_button.Text = "Стоп";
                    settings_button.Enabled = false;
                    settings_mssql.Enabled = false;
                    checkBox1.Enabled = false;
                    // Это нужно чтобы в многопоточке я мог контроливать GUI
                    var progress = new Progress<string>(s => AddToLog(s));
                    timer = new System.Threading.Timer(tm, progress, 0, 60000 * ((int)numericUpDown1.Value));
                }
                else
                {
                    MessageBox.Show("Значение должно быть > 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Enabled = false;
                start_button.Enabled = false;
                start_button.Text = "Завершение потоков....";
                Cursor.Current = Cursors.WaitCursor;
                timer.Change(System.Threading.Timeout.Infinite, 0);
                WaitHandle waitHandle = new AutoResetEvent(false);

                timer.Dispose(waitHandle);
                var count = ParsedData.data.Count > 0 ? ParsedData.data.Count : 1;
                waitHandle.WaitOne(count * 60000);
                Cursor.Current = Cursors.Default;
                Enabled = true;
                //ParcedData.WriteDataToExcel(ParcedData.data);
                start_button.Text = "Старт";
                settings_button.Enabled = true;
                settings_mssql.Enabled = true;
                start_button.Enabled = true;
                checkBox1.Enabled = true;

            }
        }

        // Здесь добавляю в свой лог строку,
        // если там больше limit удаляю первый а последний оставляю
        public static void AddToLog(string s)
        {
            if (log.Count > limit)
            {
                log.RaiseListChangedEvents = false;
                log.RemoveAt(0);
                log.RaiseListChangedEvents = true;
            }
            log.Add(s);
        }

        public void TaskManager(object o)
        {
            // Наш таймер многопоточный, здесь я блочу потоки, чтобы только один мог пройти и работать с базами данных
            lock (lockObj)
            {
                foreach (var data in ParsedData.data)
                {
                    // считываю строки
                    var importedData = WorkingWithDB.GetFromPostgreSql(data, (Progress<string>)o);
                    //  если без ошибки считал данные то записывваю в ms sql
                    if (importedData != null)
                    {
                        WorkingWithDB.WriteDataMSSql(importedData, (Progress<string>)o, data);
                    }
                }
                // Обновляю данные в параметрах
                dataGridView1.Invalidate();
                dataGridView1.Update();
                if (!ParsedData.WriteDataToExcel())
                    StartbuttonClick(this, EventArgs.Empty);
                ((IProgress<string>)o).Report("---------------------------");
            }
        }

    }
}
