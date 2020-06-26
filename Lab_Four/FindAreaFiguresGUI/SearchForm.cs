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
            //TODO: Дублируется - решено
            StandartMethods.LoadDataGrid(
                DataFiguresGridView, _figuresFilter);

            FigureRadioButton.Checked = true;
        }
        
        /// <summary>
        /// Расширение формы при большом содержимом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //TODO: Дублируется - частично решено?

            StandartMethods.RefreshForm(CloseLabel, MinimazeLabel, this);

            var fallPoint = StandartMethods.FallPointsSearch(
                DataFiguresGridView);

            this.Width = 22 + fallPoint;
            DataFiguresGridView.Width = fallPoint;
            int buffer = SearchTextBox.Width;
            SearchTextBox.Width = fallPoint;
            SearchButton.Width = SearchButton.Width +
                SearchTextBox.Width - buffer;

            CloseLabel.Location = new Point(fallPoint - 3, 3);
            MinimazeLabel.Location = new Point(fallPoint - 33, 3);

            fallPoint = 0;
        }

        /// <summary>
        /// Поиск
        /// </summary>
        //TODO: RSDN переименовать - решено
        private void StartSearch()
        {
            //TODO: Разбить метод - решено
            _figuresFilter.Clear();

            if (FigureRadioButton.Checked)
            {
                StartSearchFigure();
            }
            else if (AreaRadioButton.Checked)
            {
                StartSearchArea();
            }
            else if (AreaAprRadioButton.Checked)
            {
                StartSearchAreaApr();
            }

        }

        /// <summary>
        /// Поиск по фигуре
        /// </summary>
        private void StartSearchFigure()
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
                StandartMethods.GiveStandartMessageBox(
                    $"{exception}\nEnter the string!");
            }
        }

        /// <summary>
        /// Поиск по площади
        /// </summary>
        private void StartSearchArea()
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
                        StandartMethods.GiveStandartMessageBox(
                            $"Enter non-negative decimal number!");
                    }
                }
            }
            catch
            {
                StandartMethods.GiveStandartMessageBox(
                    $"\nEnter decimal number (separator - comma)!");
            }
        }

        /// <summary>
        /// Поиск по примерной площади
        /// </summary>
        private void StartSearchAreaApr()
        {
            try
            {
                foreach (var row in _figures)
                {
                    if (row.FigureArea <
                        1.05 * Convert.ToDouble(SearchTextBox.Text) &
                        row.FigureArea >
                        0.95 * Convert.ToDouble(SearchTextBox.Text))
                    {
                        _figuresFilter.Add(row);
                    }
                    if (Convert.ToDouble(SearchTextBox.Text) < 0)
                    {
                        StandartMethods.GiveStandartMessageBox(
                            $"Enter non-negative decimal number!");
                    }
                }
            }
            catch
            {
                StandartMethods.GiveStandartMessageBox(
                    $"\nEnter decimal number (separator - comma)!");
            }
        }

        /// <summary>
        /// Нажаите кнопки искать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            StartSearch();
        }
    }
}
