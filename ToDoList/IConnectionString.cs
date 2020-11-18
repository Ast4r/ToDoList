using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    interface IConnectionString
    {
        //Содержит реализацию инициализации CreateConnectionString
        string CreateConnectionString();
    }
}
