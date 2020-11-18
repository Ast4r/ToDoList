using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class MySQLConnectionString :IConnectionString
    {
        string _server;
        string _user;
        string _pass;
        string _port;
        string _dataBase;
        //Стандартный конструктор
        public MySQLConnectionString ( string Server, string User, string Password,
            string DBName,string Port)
        {
            _server = Server;
            _user = User;
            _pass = Password;
            _port = Port;
            _dataBase = DBName;
        }
        //Перегрузка с конструктором по умолчанию
        public MySQLConnectionString(string Server, string User, string Password,
          string DBName)
        {
            _server = Server;
            _user = User;
            _pass = Password;
            _port = "3306";
            _dataBase = DBName;
        }
        //Создание ConnectionString для MySQL
        public string CreateConnectionString()
        {
            string connStr =
                    "Server=" + _server + ";" +
                    "Database=" + _dataBase + ";" +
                    "Uid=" + _user + ";" +
                    "Pwd=" + _pass + ";" +
                    "Port =" + _port + ";";
            return connStr;
        }
    }
}
