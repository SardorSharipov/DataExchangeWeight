using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ComportProject
{
    public static class ParsedData
    {
        public static List<Data> data;


        public static string MS_SQL_SERVER = "";
        public static string MS_SQL_DATABASE = "";
        public static string MS_SQL_LOGIN = "";
        public static string MS_SQL_PASSWORD = "";
        public static string MS_SQL_TABLE = "";       
        public static bool AUTOSTART = false;
        public static string AUTOSTART_PATH = Application.StartupPath + "resources\\config.txt";
        public static string PATH_DB = Application.StartupPath + "resources\\parameters.db";
        public static string PATH_AD = Application.StartupPath + "resources\\admin.db";

        static ParsedData()
        {           
            if (File.Exists(AUTOSTART_PATH))
            {
                try
                {
                    using StreamReader reader = new StreamReader(AUTOSTART_PATH);
                    var curline = reader.ReadLine().Split("=");
                    if (curline.Length == 2 && curline[0] == "AUTOSTART")
                    {
                        if (curline[1] == "TRUE")
                        {
                            AUTOSTART = true;
                        }
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        using var fs = File.Create(AUTOSTART_PATH);
                        using StreamWriter writer = new StreamWriter(fs);
                        writer.WriteLine("AUTOSTART=FALSE");
                    }
                    catch (Exception) { }
                }
            }
            else
            {
                try
                {
                    using var fs = File.Create(AUTOSTART_PATH);
                    using StreamWriter writer = new(fs);
                    writer.WriteLine("AUTOSTART=FALSE");
                }
                catch (Exception) { }
            }
        }

        public static List<Data> ParseDataFromExcel()
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={PATH_DB};Mode=ReadWriteCreate;"))
                {
                    string createCommand = @"
                                       CREATE TABLE IF NOT EXISTS PARAMS
                                       (
                                            IP VARCHAR(255),
                                            DataBase VARCHAR(255),
                                            ПользовательSQL VARCHAR(255),
                                            ПарольSQL VARCHAR(255),
                                            ТаблицаSQL VARCHAR(255),
                                            inn INT,
                                            equipNum INT,
                                            typeProduct VARCHAR(255),
                                            lastValue TIMESTAMP,
                                            lastWeight REAL
                                       )                   
                                       ";
                    connection.Open();
                    using var commandCreate = new SQLiteCommand(createCommand, connection);
                    commandCreate.ExecuteNonQuery();
                    using var commandSelect = new SQLiteCommand("SELECT * FROM PARAMS", connection);
                    using var adapter = new SQLiteDataAdapter();
                    var dataset = new DataSet();
                    adapter.SelectCommand = commandSelect;
                    adapter.Fill(dataset, "PARAMS");
                    dataset.Tables["PARAMS"].AsEnumerable();
                    var data = dataset.Tables["PARAMS"].AsEnumerable();
                    return data.Where(x => !x.IsNull(0)).Select(x =>
                                            new Data(x.Field<string>("IP"),
                                                x.Field<string>("DataBase"),
                                                x.Field<string>("ПользовательSQL"),
                                                x.Field<string>("ПарольSQL") ?? "",
                                                x.Field<string>("ТаблицаSQL"),
                                                x.Field<int>("inn"),
                                                x.Field<int>("equipNum"),
                                                x.Field<string>("typeProduct"),
                                                x.Field<DateTime>("lastValue"),
                                                x.Field<double>("lastWeight"))
                                            ).ToList();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка чтения параметров", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
          
        }

        public static void ParseAdminFromExcel()
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={PATH_AD};Mode=ReadWriteCreate;"))
                {
                    string createCommand = @"
                                       CREATE TABLE IF NOT EXISTS ADMIN
                                       (
                                            SERVER VARCHAR(255),
                                            DATABASE VARCHAR(255),
                                            LOGIN VARCHAR(255),
                                            PASSWORD VARCHAR(255),
                                            TABLESQL VARCHAR(255)
                                       )                   
                                       ";
                    connection.Open();
                    using var commandCreate = new SQLiteCommand(createCommand, connection);
                    commandCreate.ExecuteNonQuery();
                    using var commandSelect = new SQLiteCommand("SELECT * FROM ADMIN", connection);
                    using var adapter = new SQLiteDataAdapter();
                    var dataset = new DataSet();
                    adapter.SelectCommand = commandSelect;
                    adapter.Fill(dataset, "ADMIN");
                    dataset.Tables["ADMIN"].AsEnumerable();
                    if (dataset.Tables["ADMIN"].AsEnumerable().Count() != 0)
                    {
                        var data = dataset.Tables["ADMIN"].AsEnumerable().First();
                        MS_SQL_SERVER = data.Field<string>("SERVER");
                        MS_SQL_DATABASE = data.Field<string>("DATABASE");
                        MS_SQL_LOGIN = data.Field<string>("LOGIN");
                        MS_SQL_PASSWORD = data.Field<string>("PASSWORD");
                        MS_SQL_TABLE = data.Field<string>("TABLESQL");
                    }
                    else
                    {
                        MessageBox.Show("Параметры админа пустые!", "Ошибка чтения параметров сервера", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MS_SQL_SERVER = "";
                        MS_SQL_DATABASE = "";
                        MS_SQL_LOGIN = "";
                        MS_SQL_PASSWORD = "";
                        MS_SQL_TABLE = "";
                    }
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка чтения параметров сервера", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        public static bool WriteDataToExcel()
        {
            if (data == null)
            {
                MessageBox.Show("Перезапустите приложение", "Файл поврежден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={PATH_DB};Mode=ReadWrite;"))
                {
                    connection.Open();

                    using (var command = new SQLiteCommand("DELETE  FROM PARAMS", connection)) { command.ExecuteNonQuery(); }

                    var commandText = $"INSERT INTO PARAMS " +
                        $"(IP, DataBase, ПользовательSQL, ПарольSQL, ТаблицаSQL, inn, equipNum, typeProduct, lastValue, lastWeight) " +
                        $"Values " +
                        $"(@IP, @DataBase, @ПользовательSQL, @ПарольSQL, @ТаблицаSQL, @inn, @equipNum, @typeProduct, @lastValue, @lastWeight)";

                    foreach (var d in data)
                    {
                        using var command = new SQLiteCommand(commandText, connection);
                        command.Parameters.AddWithValue("@IP", d.IP);
                        command.Parameters.AddWithValue("@DataBase", d.DataBase);
                        command.Parameters.AddWithValue("@ПользовательSQL", d.Login);
                        command.Parameters.AddWithValue("@ПарольSQL", d.Password);
                        command.Parameters.AddWithValue("@ТаблицаSQL", d.TableSQL);
                        command.Parameters.AddWithValue("@inn", d.INN);
                        command.Parameters.AddWithValue("@equipNum", d.EquipNum);
                        command.Parameters.AddWithValue("@typeProduct", d.TypeProduct);
                        command.Parameters.AddWithValue("@lastValue",
                            new DateTime(d.LastValue.Year, d.LastValue.Month, d.LastValue.Day, d.LastValue.Hour, d.LastValue.Minute, d.LastValue.Second)); //command.Parameters.AddWithValue("@lastValue", d.LastValue);
                        command.Parameters.AddWithValue("@lastWeight", d.LastWeight);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка записи параметров", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return false;           
        }

        public static void WriteMSSqlDataToExcel()
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={PATH_AD};Mode=ReadWrite;"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand("DELETE  FROM ADMIN", connection)) { command.ExecuteNonQuery(); }

                    var commandText = $"INSERT INTO ADMIN " +
                        $"(SERVER, DATABASE, LOGIN, PASSWORD, TABLESQL)" +
                        $"Values " +
                        $"(@SERVER, @DATABASE, @LOGIN, @PASSWORD, @TABLESQL)";
                    using (var command = new SQLiteCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("@SERVER", MS_SQL_SERVER);
                        command.Parameters.AddWithValue("@DATABASE", MS_SQL_DATABASE);
                        command.Parameters.AddWithValue("@LOGIN", MS_SQL_LOGIN);
                        command.Parameters.AddWithValue("@PASSWORD", MS_SQL_PASSWORD);
                        command.Parameters.AddWithValue("@TABLESQL", MS_SQL_TABLE);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка записи параметров сервера", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}


