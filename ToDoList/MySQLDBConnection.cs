using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    //Реализует подключение к базе данных с помощью ConnectionString
    class MySQLDBConnection : IDisposable
    {
        public MySqlConnection Connection { get; private set; }
        //Стандартный конструктор,во время создания объекта подключается к базе данных
        public MySQLDBConnection(IConnectionString ConnString)
        {
            Connection = new MySqlConnection(ConnString.CreateConnectionString());
            Connection.Open();
        }
        //Деструктор, закрывает подключение к базе данных 
        public void Dispose()
        {
            Connection.Close();
        }
    }
}
