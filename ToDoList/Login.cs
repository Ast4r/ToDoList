using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Login : Form
    {
        //Стандартный конструктор
        public Login()
        {
            InitializeComponent();
        }
        MySQLConnectionString connStr; 
        MySQLDBConnection mySQLDB;
        SELECT select;
        //Ищет пользователя в таблице и возвращает его,отображает его Id
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //Запрос пользователя с введенным ником и паролем
            select.Select(User.TableName, "user = '" + TBName.Text + "' and pass ='" + TBPass.Text + "'");
            
            User loginUser = new User( select.TableToList(0));
            MessageBox.Show(loginUser.Id);
        }
        //Инициализация всех полей
        private void Login_Load(object sender, EventArgs e)
        {
            //Инициализация ConnectionString
            connStr = new MySQLConnectionString("localhost", "root", "root", "testDb");
            mySQLDB = new MySQLDBConnection(connStr);
            select = new SELECT(mySQLDB);
        }
    }
}
