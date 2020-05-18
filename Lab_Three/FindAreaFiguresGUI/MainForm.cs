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
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список классов
        /// </summary>
        private List<IFigure> _itemsList;

        /// <summary>
        /// Тип расчета
        /// </summary>
        private List<string> _selectedCalcType;

        // TODO: Слабая типизация - плохо придумать как разделить свойство
        /// <summary>
        /// Лист свойств расчетных полей
        /// </summary>
        private List<object> _calcTypesToForm;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        private double _areaFigure;

        /// <summary>
        /// Выбранная фигура
        /// </summary>
        private IFigure _classFigure;

        /// <summary>
        /// Иниицаилизация главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
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
        /// Последняя точка курсора
        /// </summary>
        private Point _lastPoint;

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
            _calcTypesToForm = _classFigure.DimensionsFigure;

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
            List<object> _calcBuffer = new List<object>();
            
            // сохранения введенных параметров с формы
            for (int i = 0; i < _calcTypesToForm.Count; i++)
            {
                double buffer = CheckDimensions(
                    DimensionsDataGridView[1, i].Value as string,
                    _calcTypesToForm[i] as string);

                _calcBuffer.Add(Convert.ToDouble(buffer));
            }

            // передача введенных параметров в расчетный класс
            try
            {
                _classFigure.DimensionsFigure = _calcBuffer;
            }
            catch (ArgumentOutOfRangeException exception)
            {
                GiveStandartMessageBox(exception.Message);
            }

            // расчет площади
            try
            {
                _areaFigure = _classFigure.FigureArea; ;
            }
            catch (ArgumentOutOfRangeException exception)
            {
                GiveStandartMessageBox(exception.Message);
            }

            // вывод результатов в текстбокс
            FigureAreaTextBox.Text = $"{_areaFigure}";

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
                GiveStandartMessageBox($"{name} - INVALID");

            }
            else if (String.IsNullOrEmpty(value))
            {
                GiveStandartMessageBox($"{name} - is null or empty");
            }
            else
            {
                buffer = Double.Parse(value);
            }

            return buffer;
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
    }
}
