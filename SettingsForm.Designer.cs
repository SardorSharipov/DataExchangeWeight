
namespace ComportProject
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.db_textbox = new System.Windows.Forms.TextBox();
            this.sqlTable_textbox = new System.Windows.Forms.TextBox();
            this.inn_textbox = new System.Windows.Forms.TextBox();
            this.typeProduct_cb = new System.Windows.Forms.ComboBox();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.save_exit_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_row = new System.Windows.Forms.Button();
            this.equipNum_textbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataBase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "SQLTable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "INN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(496, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 43);
            this.label6.TabIndex = 9;
            this.label6.Text = "EquipNum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(496, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 43);
            this.label7.TabIndex = 10;
            this.label7.Text = "TypeProduct";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(496, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(496, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 43);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // ip_textbox
            // 
            this.ip_textbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ip_textbox.Location = new System.Drawing.Point(204, 14);
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(265, 27);
            this.ip_textbox.TabIndex = 14;
            // 
            // db_textbox
            // 
            this.db_textbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.db_textbox.Location = new System.Drawing.Point(204, 57);
            this.db_textbox.Name = "db_textbox";
            this.db_textbox.Size = new System.Drawing.Size(265, 27);
            this.db_textbox.TabIndex = 15;
            // 
            // sqlTable_textbox
            // 
            this.sqlTable_textbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.sqlTable_textbox.Location = new System.Drawing.Point(204, 100);
            this.sqlTable_textbox.Name = "sqlTable_textbox";
            this.sqlTable_textbox.Size = new System.Drawing.Size(265, 27);
            this.sqlTable_textbox.TabIndex = 16;
            // 
            // inn_textbox
            // 
            this.inn_textbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.inn_textbox.Location = new System.Drawing.Point(204, 143);
            this.inn_textbox.Name = "inn_textbox";
            this.inn_textbox.Size = new System.Drawing.Size(265, 27);
            this.inn_textbox.TabIndex = 17;
            // 
            // typeProduct_cb
            // 
            this.typeProduct_cb.Dock = System.Windows.Forms.DockStyle.Left;
            this.typeProduct_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeProduct_cb.Items.AddRange(new object[] {
            "Пахта",
            "Чигит",
            "Тола",
            "Шрот",
            "Шелуха",
            "СеменаЗаготовка",
            "Масло",
            "СеменаНаПроизводства",
            "Соапсток",
            "Прочие"});
            this.typeProduct_cb.Location = new System.Drawing.Point(690, 57);
            this.typeProduct_cb.Name = "typeProduct_cb";
            this.typeProduct_cb.Size = new System.Drawing.Size(230, 28);
            this.typeProduct_cb.TabIndex = 21;
            // 
            // login_textbox
            // 
            this.login_textbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.login_textbox.Location = new System.Drawing.Point(690, 100);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(230, 27);
            this.login_textbox.TabIndex = 22;
            // 
            // password_textbox
            // 
            this.password_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_textbox.Location = new System.Drawing.Point(690, 143);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(230, 27);
            this.password_textbox.TabIndex = 23;
            // 
            // save_exit_button
            // 
            this.save_exit_button.BackColor = System.Drawing.Color.GreenYellow;
            this.tableLayoutPanel1.SetColumnSpan(this.save_exit_button, 2);
            this.save_exit_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_exit_button.Location = new System.Drawing.Point(358, 545);
            this.save_exit_button.Name = "save_exit_button";
            this.save_exit_button.Size = new System.Drawing.Size(326, 40);
            this.save_exit_button.TabIndex = 24;
            this.save_exit_button.Text = "Закрыть";
            this.save_exit_button.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 310);
            this.dataGridView1.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.91716F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.94621F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.28751F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.84911F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.add_button, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ip_textbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.password_textbox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.db_textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.login_textbox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.typeProduct_cb, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sqlTable_textbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.inn_textbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.save_exit_button, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.delete_row, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.equipNum_textbox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1215, 540);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.51507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.515071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.515071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.515071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.519969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.89978F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.519969F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 599);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(496, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 43);
            this.label9.TabIndex = 33;
            this.label9.Text = "LastValue Date";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.GreenYellow;
            this.add_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.add_button.Location = new System.Drawing.Point(1026, 545);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(195, 40);
            this.add_button.TabIndex = 31;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            // 
            // delete_row
            // 
            this.delete_row.BackColor = System.Drawing.Color.GreenYellow;
            this.delete_row.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_row.Location = new System.Drawing.Point(13, 545);
            this.delete_row.Name = "delete_row";
            this.delete_row.Size = new System.Drawing.Size(185, 40);
            this.delete_row.TabIndex = 25;
            this.delete_row.Text = "Удалить строку";
            this.delete_row.UseVisualStyleBackColor = false;
            // 
            // equipNum_textbox
            // 
            this.equipNum_textbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.equipNum_textbox.Location = new System.Drawing.Point(690, 14);
            this.equipNum_textbox.Name = "equipNum_textbox";
            this.equipNum_textbox.Size = new System.Drawing.Size(230, 27);
            this.equipNum_textbox.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(690, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 27);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 13, 18, 21, 32, 0);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1250, 607);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.TextBox db_textbox;
        private System.Windows.Forms.TextBox sqlTable_textbox;
        private System.Windows.Forms.TextBox inn_textbox;
        private System.Windows.Forms.ComboBox typeProduct_cb;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button save_exit_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button delete_row;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox equipNum_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}