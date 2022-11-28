
namespace ComportProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.log_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.settings_mssql = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NotifyApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.15029F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.84971F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 366F));
            this.tableLayoutPanel1.Controls.Add(this.log_button, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.start_button, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.settings_mssql, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.settings_button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 3, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(780, 260);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.889126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.11088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1212, 616);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // log_button
            // 
            this.log_button.BackColor = System.Drawing.Color.GreenYellow;
            this.log_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.log_button.Location = new System.Drawing.Point(1011, 542);
            this.log_button.MinimumSize = new System.Drawing.Size(150, 40);
            this.log_button.Name = "log_button";
            this.log_button.Size = new System.Drawing.Size(188, 61);
            this.log_button.TabIndex = 25;
            this.log_button.Text = "Показать логи";
            this.log_button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(155, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Таймер  (в минутах)";
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.GreenYellow;
            this.start_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.start_button.Location = new System.Drawing.Point(343, 542);
            this.start_button.MinimumSize = new System.Drawing.Size(150, 40);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(150, 61);
            this.start_button.TabIndex = 24;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 482);
            this.dataGridView1.TabIndex = 23;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(343, 13);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(143, 27);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // settings_mssql
            // 
            this.settings_mssql.BackColor = System.Drawing.Color.GreenYellow;
            this.settings_mssql.Dock = System.Windows.Forms.DockStyle.Right;
            this.settings_mssql.Location = new System.Drawing.Point(643, 542);
            this.settings_mssql.MinimumSize = new System.Drawing.Size(150, 40);
            this.settings_mssql.Name = "settings_mssql";
            this.settings_mssql.Size = new System.Drawing.Size(188, 61);
            this.settings_mssql.TabIndex = 22;
            this.settings_mssql.Text = "Настройки MS_SQL";
            this.settings_mssql.UseVisualStyleBackColor = false;
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.GreenYellow;
            this.settings_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.settings_button.Location = new System.Drawing.Point(13, 542);
            this.settings_button.MinimumSize = new System.Drawing.Size(150, 40);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(150, 61);
            this.settings_button.TabIndex = 21;
            this.settings_button.Text = "Настройки";
            this.settings_button.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(837, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(362, 35);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Автостарт";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NotifyApp
            // 
            this.NotifyApp.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyApp.Icon")));
            this.NotifyApp.Text = "DataExchangeWeight";
            this.NotifyApp.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 616);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scales";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button log_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button settings_mssql;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NotifyIcon NotifyApp;
    }
}

