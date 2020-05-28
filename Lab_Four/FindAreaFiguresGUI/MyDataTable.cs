using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FindAreaFiguresGUI
{
    /// <summary>
    /// Таблица данных для фигур
    /// </summary>
    public class MyDataTable : DataTable
    {
        /// <summary>
        /// Конструктор MyDataTable
        /// </summary>
        public MyDataTable()
        {
            Columns.Add("Name", typeof(string));
            Columns.Add("Area", typeof(string));
        }
    }
}
