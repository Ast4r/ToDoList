using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ToDoList
{
   class SELECT
    {
        MySQLDBConnection _connection;
        public DataTable Table { get; private set;}
        //Стандартный конструктор
        public SELECT(MySQLDBConnection connection)
        {
            _connection = connection;
            Table = new DataTable();
        }
        //Делает select запрос базе данных с переданными настройками
        public void Select(string TableName,string options="1")
        {
            //Формирует запрос
            string query = "SELECT * from " + TableName + " where " + options;
            //Делает запрос
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, _connection.Connection);
            //Заполняет таблицу полученным результатом
            Table.Clear();
            dataAdapter.Fill(Table);
        }
        //Переводит тип DataTable в List<string>
        public List<string> TableToList(int index)
        {
            //Проверяет наличие строк в таблице
            if (index < Table.Rows.Count)
            {
                List<string> result = new List<string>();
                //Берет выбранную строку из Table
                DataRow row = Table.Rows[index];

                int len = row.ItemArray.Length;
                for (int i = 0; i < len; i++)
                    result.Add(row.ItemArray[i].ToString());
                return result;
            }
            return null;
        }
    }
}
