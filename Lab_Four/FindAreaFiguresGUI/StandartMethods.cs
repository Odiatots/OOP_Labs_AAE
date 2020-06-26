using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindAreaFigures;
using System.ComponentModel;
using System.Drawing;


namespace FindAreaFiguresGUI
{
    /// <summary>
    /// Стандартные для GUI методы
    /// </summary>
    public static class StandartMethods
    {
        /// <summary>
        /// Загрузка формы с добавлением таблицы
        /// </summary>
        /// <param name="dataGridView">таблица</param>
        /// <param name="bindingList">лист фигур</param>
        public static void LoadDataGrid(DataGridView dataGridView,
            BindingList<IFigure> bindingList)
        {
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSize = false;

            dataGridView.DataSource = bindingList;

            var column1 = new DataGridViewTextBoxColumn();
            var column2 = new DataGridViewTextBoxColumn();
            var column3 = new DataGridViewTextBoxColumn();

            column1.DataPropertyName = "NameFigure";
            column2.DataPropertyName = "FigureArea";
            column3.DataPropertyName = "DimensionsToOutput";

            column1.Name = "Name Figure";
            column2.Name = "Figure Area";
            column3.Name = "Dimensions";

            dataGridView.Columns.Add(column1);
            dataGridView.Columns.Add(column2);
            dataGridView.Columns.Add(column3);
        }

        /// <summary>
        /// Обновление формы
        /// </summary>
        /// <param name="closeLabel">закрыть</param>
        /// <param name="minimazeLabel">свернуть</param>
        /// <param name="form">форма</param>
        public static void RefreshForm(Label closeLabel,
            Label minimazeLabel)
        {
            closeLabel.Location = new Point(0, 3);
            minimazeLabel.Location = new Point(0, 3);

        }

        /// <summary>
        /// Вспомогательный метод определения изменения ширины формы
        /// </summary>
        /// <param name="dataGridView">таблица</param>
        /// <returns>изменение</returns>
        public static int FallPointsSearch(DataGridView dataGridView)
        {
            int fallPoints = 0;
            foreach (DataGridViewColumn r in dataGridView.Columns)
            {
                fallPoints += r.Width;
            }
            return fallPoints;
        }

        /// <summary>
        /// Распространенный вызов экспешена
        /// </summary>
        /// <param name="exception">Текст исключения</param>
        public static void GiveStandartMessageBox(string exception)
        {
            Console.WriteLine(exception);
            MessageBox.Show($"{exception}",
                "Message", MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

    }
}
