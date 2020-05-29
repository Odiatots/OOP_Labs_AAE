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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FindAreaFiguresGUI
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Основной лист фигур
        /// </summary>
        private static BindingList<IFigure> _figures = 
            new BindingList<IFigure>();

        /// <summary>
        /// Последняя точка курсора
        /// </summary>
        private Point _lastPoint;

        /// <summary>
        /// Инициализация главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            #if !DEBUG
            RandomButton.Visible = false;
            #endif

        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataFiguresGridView.DataSource = _figures;
        }

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
        /// Вызов формы добавления фигур
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFigure_Click(object sender, EventArgs e)
        {
            var figure = new FigureForm(_figures);
            figure.Show();

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

            this.Width = 45 + 22 + fallPoint;
            DataFiguresGridView.Width = 45 + fallPoint;

            CloseLabel.Location = new Point(45 + fallPoint - 3, 3);
            MinimazeLabel.Location = new Point(45 + fallPoint - 33, 3);

            fallPoint = 0;
            fallPoints = 0;
        }

        /// <summary>
        /// Удаление элемента из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFigure_Click(object sender, EventArgs e)
        {
            int _counter = DataFiguresGridView.SelectedRows.Count;

            for (int i = 0; i < _counter; i++)
            {
                _figures.RemoveAt(DataFiguresGridView.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Открытие формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var search = new SearchForm(_figures,
                CloseLabel.Location,
                MinimazeLabel.Location,
                this.Width,
                DataFiguresGridView.Width);
            search.Show();
        }

        /// <summary>
        /// Нажаите кнопки рандом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomBurron_Click(object sender, EventArgs e)
        {
            _figures.Add(RandomFigure.CreateFigure());
        }

        /// <summary>
        /// Сохранение листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream(
                "Figures.figcalc", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, _figures);
                MessageBox.Show("File saved!",
                    "Message", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        /// <summary>
        /// Загрузка листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream(
                "Figures.figcalc", FileMode.OpenOrCreate))
            {
                var newFigures = (BindingList<IFigure>)
                    formatter.Deserialize(fileStream);

                _figures.Clear();

                foreach (var figure in newFigures)
                {
                    _figures.Add(figure);
                }

                MessageBox.Show("File downloaded!",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
