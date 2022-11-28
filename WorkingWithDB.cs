using Npgsql;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;

namespace ComportProject
{
    public static class WorkingWithDB
    {
        /// <param name="data">обеъкт с Параметро<в/param>
        /// <param name="log_progress">Label где будет записываться состояние сеансал</param>
        public static EnumerableRowCollection<DataRow> GetFromPostgreSql(Data data, IProgress<string> log_progress)
        {
            //Строка для подключения к серверу
            string connString =
                String.Format(
                    "Server={0};Database={1};User Id={2};Password={3};Timeout=30;SSL Mode=Require;Trust Server Certificate=true",
                    data.IP,
                    data.DataBase,
                    data.Login,
                    data.Password);

            using var connection = new NpgsqlConnection();
            using var command = new NpgsqlCommand();
            // Это нужно чтобы все считать с нашего запроса (command) и засунуть в наш датасет
            using var adapter = new NpgsqlDataAdapter();
            // наш датасет (выборка)
            var dataset = new DataSet();
            try
            {
                connection.ConnectionString = connString;
                command.CommandText = $"SELECT * FROM {data.TableSQL} " +
                    $"WHERE inDate > '{data.LastValue:yyyy-MM-dd HH:mm:ss.fff}' AND address = {data.EquipNum}" + //даинжа лекен больше истодас
                    $"ORDER BY inDate"; //check Я убрал DESC LIMIT 1, потому что он возвращал 1 элемент
                command.Connection = connection;
                command.CommandTimeout = 600;

                log_progress.Report($"{DateTime.Now:HH:mm:ss}: Идет соединение с PostgreSQL по {data.IP}.....");
                connection.Open();

                log_progress.Report($"{DateTime.Now:HH:mm:ss}: Соединение прошло успешно!");
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Data"); // инжаба автоматически мехонат как dateTime
                log_progress.Report($"{DateTime.Now:HH:mm:ss}: {dataset.Tables["Data"].Rows.Count} строк взято!");

                return dataset.Tables["Data"].AsEnumerable();
            }
            catch (Exception e)
            {
                log_progress.Report(e.ToString());
            }
            return null;

        }
        public static void WriteDataMSSql(
            EnumerableRowCollection<DataRow> collection,
            IProgress<string> log_progress,
            Data data)
        {
            string connString =
                String.Format(
                    "Server={0};Database={1};User Id={2};Password={3};Connect Timeout=30;Trusted_Connection=True;",
                    ParsedData.MS_SQL_SERVER,
                    ParsedData.MS_SQL_DATABASE,
                    ParsedData.MS_SQL_LOGIN,
                    ParsedData.MS_SQL_PASSWORD);

            using var connection = new SqlConnection();

            try
            {
                connection.ConnectionString = connString;

                log_progress.Report($"{DateTime.Now:HH:mm:ss}: Идет соединение с MS_SQL, сервер {ParsedData.MS_SQL_SERVER}.....");
                if (connection.State != ConnectionState.Open) { connection.Open(); }

                log_progress.Report($"{DateTime.Now:HH:mm:ss}: Соединение прошло успешно!");
                var commandText = $"INSERT INTO {ParsedData.MS_SQL_TABLE} " +
                $"(inDate, weight, INN, equipNum, typeProduct, currentkg) " +
                $"Values " +
                $"(@inDate, @weight, @INN, @equipNum, @typeProduct, @currentkg)";
                
                foreach (var row in collection)
                {
                    using (var command = new SqlCommand(commandText, connection))
                    {
                        Double currentWeight = row.Field<Double>("weight");
                        command.CommandTimeout = 600;
                        command.Parameters.AddWithValue("@inDate", row.Field<DateTime>("inDate"));
                        command.Parameters.AddWithValue("@weight", currentWeight);
                        command.Parameters.AddWithValue("@INN", data.INN);
                        command.Parameters.AddWithValue("@EquipNum", data.EquipNum);
                        command.Parameters.AddWithValue("@typeProduct", data.TypeProduct);
                        command.Parameters.AddWithValue("@currentkg", currentWeight - data.LastWeight);
                        command.ExecuteNonQuery();
                        data.LastWeightSet(currentWeight);
                    }
                }

                log_progress.Report($"{DateTime.Now:HH:mm:ss}: {collection.Count()} строк успешно записаны!");

                // после записи устанавливаю новое значение
                if (collection.Any())
                {
                    var currentDate = collection.Last().Field<DateTime>("inDate");
                    data.LastValueSet(currentDate.AddMilliseconds(1));
                }
                log_progress.Report($"{DateTime.Now:HH:mm:ss}: Соединение завершено!");

            }
            catch (Exception e)
            {
                log_progress.Report(e.Message);
            }
        }

    }
}
