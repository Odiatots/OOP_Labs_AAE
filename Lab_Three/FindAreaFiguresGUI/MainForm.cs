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

        /// <summary>
        /// Лист свойств расчетных полей
        /// </summary>
        private List<object> _calcTypesToForm;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        private double _areaFigure;

        /// <summary>
        /// Иниицаилизация главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
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

            // Вытаскиваем класс фигуры из TypeFigureComboBox и 
            // передаем список методов расчета в CalcTypeComboBox
            var bufferClassFigure = TypeFigureComboBox.SelectedItem as IFigure;
            _selectedCalcType = bufferClassFigure.CalcType;
            CalcTypeComboBox.DataSource = _selectedCalcType;
        }

        /// <summary>
        /// Раскрытие элемента GiveDimensionButton
        /// при выборе Index CalcTypeComboBox
        /// и передача CalcType в IFigure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GiveDimensionButton.Visible = true;

            var bufferClassFigure = TypeFigureComboBox.SelectedItem as IFigure;
            bufferClassFigure.CalcTypeArea = CalcTypeComboBox.SelectedItem as String;


        }

        /// <summary>
        /// Нажатие на кнопку "дать ввести параметры"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiveDimensionButton_Click(object sender, EventArgs e)
        {
            DimensionsDataGridView.Visible = true;
            var bufferClassFigure = TypeFigureComboBox.SelectedItem as IFigure;
            _calcTypesToForm = bufferClassFigure.DimensionsFigure;

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
            var bufferClassFigure = TypeFigureComboBox.SelectedItem as IFigure;
            
            var _calcBuffer = _calcTypesToForm;

            for (int i = 0; i < _calcTypesToForm.Count; i++)
            {
                _calcBuffer[i] = Convert.ToDouble(DimensionsDataGridView[1, i].Value);
            }

            bufferClassFigure.DimensionsFigure = _calcBuffer;

            _areaFigure = bufferClassFigure.FigureArea;

            FigureAreaTextBox.Text = $"{_areaFigure}";

            // TODO: rectangle не посчитал
            // TODO: длины строк по РСДН
        }
    }
}
