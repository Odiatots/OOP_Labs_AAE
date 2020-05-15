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

        private List<string> _calcTypeInForm;

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

        // TODO: Не рефрешится CalcTypeComboBox при перевыборе TypeFigureComboBox
        /// <summary>
        /// Добавление элемента ComboBox и  при выборе Index TypeFigureComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeFigureComboBox_SelectionChangeCommitted(
            object sender, EventArgs e)
        {
            // Создаем комбобокс и лейбл
            ComboBox CalcTypeComboBox = new ComboBox();
            Label TypeCalcLabel = new Label();

            // Задаем комбобокс
            CalcTypeComboBox.BackColor = Color.FromArgb(54, 57, 63);
            CalcTypeComboBox.Cursor = Cursors.PanSouth;
            CalcTypeComboBox.FlatStyle = FlatStyle.Flat;
            CalcTypeComboBox.Font = new Font("Segoe UI", 8.25F,
                FontStyle.Regular, GraphicsUnit.Point, 0);
            CalcTypeComboBox.ForeColor = Color.FromArgb(225, 255, 255);
            CalcTypeComboBox.Location = new Point(168, 69);
            CalcTypeComboBox.Name = "CalcTypeComboBox";
            CalcTypeComboBox.Size = new Size(121, 21);

            // Задаем лейбл
            TypeCalcLabel.AutoSize = true;
            TypeCalcLabel.Font = new Font("Segoe UI", 9.75F,
                FontStyle.Regular, GraphicsUnit.Point, 204);
            TypeCalcLabel.ForeColor = Color.FromArgb(225, 255, 255);
            TypeCalcLabel.Location = new Point(168, 43);
            TypeCalcLabel.Name = "TypeCalcLabel";
            TypeCalcLabel.Size = new Size(80, 17);
            TypeCalcLabel.Text = "Тип расчета:";

            // Добавляем комбобокс и лейбл в коллекцию
            this.Controls.Add(CalcTypeComboBox);
            this.Controls.Add(TypeCalcLabel);

            // Вытаскиваем класс фигуры из TypeFigureComboBox и 
            // передаем список методов расчета в CalcTypeComboBox
            var buffer = TypeFigureComboBox.SelectedItem as IFigure;
            _calcTypeInForm = buffer.CalcType;
            CalcTypeComboBox.DataSource = _calcTypeInForm;
            CalcTypeComboBox.Refresh();
        }
    }
}
