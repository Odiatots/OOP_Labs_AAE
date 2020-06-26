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
    /// Форма фигур
    /// </summary>
    public partial class FigureForm : Form
    {
        /// <summary>
        /// Список классов
        /// </summary>
        private List<IFigure> _itemsList;

        /// <summary>
        /// Тип расчета
        /// </summary>
        private List<string> _selectedCalcType;

        /// <summary>
        /// Лист свойств расчетных полей
        /// </summary>
        private List<string> _calcTypesToForm;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        private double _areaFigure;

        /// <summary>
        /// Выбранная фигура
        /// </summary>
        private IFigure _classFigure;

        /// <summary>
        /// Последняя точка курсора
        /// </summary>
        private Point _lastPoint;

        /// <summary>
        /// Лист фигур из основной формы
        /// </summary>
        private BindingList<IFigure> _figures;

        /// <summary>
        /// Флаг выборка CalcTypeArea
        /// </summary>
        private bool _calcTypeFlag = false;

        /// <summary>
        /// Иниицаилизация формы фигур
        /// </summary>
        public FigureForm(BindingList<IFigure> figures)
        {
            InitializeComponent();

            _figures = figures;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DimensionsDataGridView.ScrollBars = ScrollBars.None;
            _itemsList = new List<IFigure>();
            _itemsList.Add(new Circle());
            _itemsList.Add(new FindAreaFigures.Rectangle());
            _itemsList.Add(new Triangle());

            TypeFigureComboBox.DataSource = _itemsList;
            TypeFigureComboBox.DisplayMember = "NameFigure";
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
        /// Запоминание последней позиции зажатой мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel_MouseDown(sender, e);
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
        /// Перемещение окна за мышью
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MovePanel_MouseMove(sender, e);
        }

        /// <summary>
        /// Раскрытие элемента TypeCalcComboBox и TypeCalcLabel
        /// при выборе Index TypeFigureComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeFigureComboBox_SelectionChangeCommitted(
            object sender, EventArgs e)
        {
            CalcTypeComboBox.Visible = true;
            CalcTypeLabel.Visible = true;
            GetResultButton.Visible = false;
            GiveDimensionButton.Visible = false;
            DimensionsDataGridView.Visible = false;
            DimensionsDataGridView.Rows.Clear();

            // Вытаскиваем класс фигуры из TypeFigureComboBox и 
            // передаем список методов расчета в CalcTypeComboBox
            _classFigure = TypeFigureComboBox.SelectedItem as IFigure;
            _selectedCalcType = new List<string>();
            foreach (string p in _classFigure.CalcTypeAreaDictionary.Values)
            {
                _selectedCalcType.Add(p);
            }
            CalcTypeComboBox.DataSource = _selectedCalcType;
        }

        /// <summary>
        /// Раскрытие элемента GiveDimensionButton
        /// при выборе Index CalcTypeComboBox
        /// и передача CalcType в IFigure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcTypeComboBox_SelectionChangeCommitted(
            object sender, EventArgs e)
        {
            _calcTypeFlag = true;
            GetResultButton.Visible = false;
            GiveDimensionButton.Visible = true;
            DimensionsDataGridView.Rows.Clear();

            // передача типа расчета в класс
            _classFigure.CalcTypeArea =
                CalcTypeComboBox.SelectedItem as String;


        }

        /// <summary>
        /// Нажатие на кнопку "дать ввести параметры"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiveDimensionButton_Click(object sender, EventArgs e)
        {
            DimensionsDataGridView.Visible = true;
            GetResultButton.Visible = true;
            FigureAreaTextBox.Visible = true;
            ResultLabel.Visible = true;

            DimensionsDataGridView.Rows.Clear();

            // создание списка расчетных параметров для выведения на форму
            _calcTypesToForm = _classFigure.NamesDimensionsFigure;

            // выведение названий параметров на форму
            for (int i = 0; i < _calcTypesToForm.Count; i++)
            {
                DimensionsDataGridView.Rows.Add(_calcTypesToForm[i]);
            }
        }

        /// <summary>
        /// Нажатие на кнопку "посчитай"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetResultButton_Click(object sender, EventArgs e)
        {
            // измерения с формы
            List<double> _calcBuffer = new List<double>();

            // сохранения введенных параметров с формы
            for (int i = 0; i < _calcTypesToForm.Count; i++)
            {
                double buffer = CheckDimensions(
                    DimensionsDataGridView[1, i].Value as string,
                    _calcTypesToForm[i] as string);

                _calcBuffer.Add(buffer);
            }

            // передача введенных параметров в расчетный класс
            try
            {
                _classFigure.ValuesDimensionsFigure = _calcBuffer;
            }
            catch (Exception exception)
            {
                if (exception is ArgumentOutOfRangeException ||
                    exception is ArithmeticException)
                    StandartMethods.GiveStandartMessageBox(
                        exception.Message);
            }
                       
            // расчет площади
            GetResultButtonForArea();

            // вывод результатов в текстбокс
            FigureAreaTextBox.Text = $"{_areaFigure}";

        }
        
        /// <summary>
        /// Проверка на существование треугольника
        /// </summary>
        bool flagTriangleExist = true;

        /// <summary>
        /// Вспомогательный метод для расчета площади
        /// </summary>
        private void GetResultButtonForArea()
        {
            try
            {
                flagTriangleExist = true;
                _areaFigure = _classFigure.FigureArea;
            }
            catch (ArgumentOutOfRangeException exception)
            {
                StandartMethods.GiveStandartMessageBox(exception.Message);

                flagTriangleExist = false;
            }
        }

        /// <summary>
        /// Проверка введеных параметров
        /// </summary>
        /// <param name="value">Параметр</param>
        /// <param name="name">Имя параметра</param>
        private double CheckDimensions(string value, string name)
        {
            double buffer;

            if (!Double.TryParse(value, out buffer))
            {
                StandartMethods.GiveStandartMessageBox($"{name} - INVALID.");
            }
            else if (String.IsNullOrEmpty(value))
            {
                StandartMethods.GiveStandartMessageBox(
                    $"{name} - is null or empty.");
            }
            else
            {
                buffer = Double.Parse(value);
            }

            return buffer;
        }
   
        /// <summary>
        /// Выход к основному окну с добавлением фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            if (_classFigure == null || !_calcTypeFlag)
            {
                StandartMethods.GiveStandartMessageBox(
                    $"The input is not complete!\nEnter all the data.");
            }
            else if (FigureAreaTextBox.Text == String.Empty)
            {
                StandartMethods.GiveStandartMessageBox($"No result!\n" +
                    $"click let me input, enter the data\n" +
                    $"and click Go! to get the result.");
            }
            else if (_classFigure.NameFigure == "Triangle" && !flagTriangleExist)
            {
                GetResultButtonForArea();
            }
            else
            {
                _figures.Add(_classFigure);
                Close();
            }
        }

        /// <summary>
        /// Просто закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
