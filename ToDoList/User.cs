using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class User
    {
        public string Id { get; private set; }
        public string UserName { get;  set; }
        public string Pass { private get;  set; }
        public string Date { get;  set; }
        static public  string TableName = "logins";
        public List<string> ColumnNames { get; private set; }
        //Создает массив с наименованием всеъ столбцов в базе данных
        private void SetColumnNames()
        {
            ColumnNames = new List<string>();
            ColumnNames.Add("id");
            ColumnNames.Add("user");
            ColumnNames.Add("pass");
            ColumnNames.Add("regDate");
        }
        //Стандартный конструктор
        public User  ( string UserName, string Password, string RegDate)
        {
            this.UserName = UserName;
            Pass = Password;
            Date= RegDate ;
            SetColumnNames();
        }
        //Конструктор принимающий List<string>
        public User(List<string> UserData) 
        {
            //Заполняет поля из UserData
            getDataFromList(UserData);
            SetColumnNames(); 
        }
        //Принимает лист с даннами о юзере и заполняет им поля
        public void getDataFromList(List<string> UserData)
        {
            Id = UserData[0];
            UserName = UserData[1];
            Pass = UserData[2];
            Date = UserData[3];
        }
    }
}
