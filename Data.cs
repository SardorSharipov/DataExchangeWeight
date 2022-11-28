using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace ComportProject
{
    public class Data
    {
        public string IP { get; set; }
        public string DataBase { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string TableSQL { get; set; }
        public int INN { get; set; }
        public int EquipNum { get; set; }
        public string TypeProduct { get; set; }
        public DateTime LastValue { get; set; }
        public double LastWeight { get; private set; }


        public Data(string ip, string database, string login, string password,
            string tableSQL, int inn, int equipNum, string typeProduct, DateTime lastValue, double lastWeight)
        {
            IP = ip;
            DataBase = database;
            Login = login;
            Password = password;
            TableSQL = tableSQL;
            INN = inn;
            EquipNum = equipNum;
            TypeProduct = typeProduct;
            LastValue = lastValue;
            LastWeight = lastWeight;
        }

        public Data()
        {

        }


        public void EditData(Data other)
        {
            IP = other.IP;
            DataBase = other.DataBase;
            Login = other.Login;
            Password = other.Password;
            TableSQL = other.TableSQL;
            INN = other.INN;
            EquipNum = other.EquipNum;
            TypeProduct = other.TypeProduct;
        }

        public override string ToString()
        {
            return IP + " " + DataBase + " " + Login + " " + Password +
                " " + TableSQL + " " + INN + " " + EquipNum + " " + TypeProduct + " "
                + LastValue.ToShortDateString() + " " + LastWeight;

        }

        public void LastValueSet(DateTime dateTime)
        {
            LastValue = dateTime;
        }

        public void LastWeightSet(double lastWeight)
        {
            LastWeight = lastWeight;
        }

        public void LastValueSetNow()
        {
            LastValue = DateTime.Today;
        }

        public override bool Equals(object obj)
        {
            return obj is Data data &&
                data.IP.Equals(IP) &&
                data.DataBase.Equals(DataBase) &&
                data.TableSQL.Equals(TableSQL) &&
                data.INN == INN &&
                data.TypeProduct.Equals(TypeProduct) &&
                data.EquipNum.Equals(EquipNum);


        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IP, DataBase, Login, Password, TableSQL, INN, EquipNum, TypeProduct);
        }
    }
}
