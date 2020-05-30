using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindAreaFigures;

namespace FindAreaFiguresGUI
{
    /// <summary>
    /// Форма поиска
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Последняя точка курсора
        /// </summary>
        private Point _lastPoint;

        /// <summary>
        /// Лист фигур из основной формы
        /// </summary>
        private BindingList<IFigure> _figures;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SearchForm(BindingList<IFigure> figures, 
            Point pointClose,
            Point pointMinimaze, 
            int widthForm,
            int widthGrid)
        {
            InitializeComponent();

            _figures = figures;
            CloseLabel.Location = pointClose;
            MinimazeLabel.Location = pointMinimaze;
            this.Width = widthForm;
            DataFiguresGridView.Width = widthGrid;
            int buffer = SearchTextBox.Width;
            SearchTextBox.Width = widthGrid;
            SearchButton.Width = SearchButton.Width + 
                SearchTextBox.Width - buffer;

        }

        /// <summary>
        /// Отфильтрованный список
        /// </summary>
        private BindingList<IFigure> _figuresFilter 
            = new BindingList<IFigure>();

        /// <summary>
        /// Обработка клика для закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработка клика для сворачивания формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimazeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Запоминание последней позиции зажатой мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }
        
        /// <summary>
        /// Перемещение окна за мышью
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _lastPoint.X;
                this.Top += e.Y - _lastPoint.Y;
            }
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            DataFiguresGridView.ScrollBars = ScrollBars.None;
            DataFiguresGridView.AutoGenerateColumns = false;
            DataFiguresGridView.AutoSize = false;

            DataFiguresGridView.DataSource = _figuresFilter;
            var column1 = new DataGridViewTextBoxColumn();
            var column2 = new DataGridViewTextBoxColumn();
            var column3 = new DataGridViewTextBoxColumn();

            column1.DataPropertyName = "NameFigure";
            column2.DataPropertyName = "FigureArea";
            column3.DataPropertyName = "DimensionsToOutput";

            column1.Name = "Name Figure";
            column2.Name = "Figure Area";
            column3.Name = "Dimensions";

            DataFiguresGridView.Columns.Add(column1);
            DataFiguresGridView.Columns.Add(column2);
            DataFiguresGridView.Columns.Add(column3);

            FigureRadioButton.Checked = true;
        }
        
        /// <summary>
        /// Расширение формы при большом содержимом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            CloseLabel.Location = new Point(0, 3);
            MinimazeLabel.Location = new Point(0, 3);
            this.Width = 0;
            var fallAllPoint = DataFiguresGridView.Columns;
            int fallPoints = 0;
            foreach (DataGridViewColumn r in fallAllPoint)
            {
                fallPoints += r.Width;
            }

            var fallPoint = fallPoints;

            this.Width = 22 + fallPoint;
            DataFiguresGridView.Width = fallPoint;
            int buffer = SearchTextBox.Width;
            SearchTextBox.Width = fallPoint;
            SearchButton.Width = SearchButton.Width + 
                SearchTextBox.Width - buffer;

            CloseLabel.Location = new Point(fallPoint - 3, 3);
            MinimazeLabel.Location = new Point(fallPoint - 33, 3);

            fallPoint = 0;
            fallPoints = 0;
        }

        /// <summary>
        /// Поиск
        /// </summary>
        private void GoSearch()
        {
            _figuresFilter.Clear();

            if (FigureRadioButton.Checked)
            {
                try
                {
                    foreach (var row in _figures)
                    {
                        if (row.NameFigure == SearchTextBox.Text)
                        {
                            _figuresFilter.Add(row);
                        }
                    }
                }
                catch (Exception exception)
                {
                    GiveStandartMessageBox(
                        $"{exception}\nEnter the string!");
                }
            }
            else if (AreaRadioButton.Checked)
            {
                try
                {
                    foreach (var row in _figures)
                    {
                        if (row.FigureArea ==
                            Convert.ToDouble(SearchTextBox.Text))
                        {
                            _figuresFilter.Add(row);
                        }
                        if (Convert.ToDouble(SearchTextBox.Text) < 0)
                        {
                            GiveStandartMessageBox($"Enter non-negative " +
                                $"decimal number!");
                        }
                    }
                }
                catch
                {
                    GiveStandartMessageBox($"\nEnter decimal" +
                        $" number (separator - comma)!");
                }
            }
            else if (AreaAprRadioButton.Checked)
            {
                try
                {
                    foreach (var row in _figures)
                    {
                        if (row.FigureArea < 
                            1.05*Convert.ToDouble(SearchTextBox.Text) & 
                            row.FigureArea >
                            0.95 * Convert.ToDouble(SearchTextBox.Text))
                        {
                            _figuresFilter.Add(row);
                        }
                        if (Convert.ToDouble(SearchTextBox.Text) < 0)
                        {
                            GiveStandartMessageBox($"Enter non-negative " +
                                $"decimal number!");
                        }
                    }
                }
                catch
                {
                    GiveStandartMessageBox($"\nEnter decimal" +
                        $" number (separator - comma)!");
                }
            }

        }

        /// <summary>
        /// Вызов распространенного экспешина
        /// </summary>
        /// <param name="exception">Текст исключения</param>
        private void GiveStandartMessageBox(string exception)
        {
            Console.WriteLine(exception);
            MessageBox.Show($"{exception}.",
                "Message", MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        /// <summary>
        /// Нажаите кнопки искать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            GoSearch();
        }
    }
}
