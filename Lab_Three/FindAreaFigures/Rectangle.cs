using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaFigures
{
    /// <summary>
    /// Класс прямоугольника
    /// </summary>
    public class Rectangle : IFigure
    {

        #region Поля

        /// <summary>
        /// Поле параметр длины
        /// </summary>
        private double _lengthRectangle;

        /// <summary>
        /// Поле параметр ширины
        /// </summary>
        private double _widthRectangle;

        /// <summary>
        /// Поле параметр диагональ
        /// </summary>
        private double _diagonalRectangle;

        /// <summary>
        /// Поле параметр угол между диагоналями
        /// </summary>
        private double _angleBetweenDiagonalsRectangle;

        /// <summary>
        /// Поле параметр площадь фигуры
        /// </summary>
        private double _figureArea;

        /// <summary>
        /// Поле параметр способ расчета
        /// </summary>
        private string _calcTypeArea;

        #endregion

        #region Свойства

        /// <summary>
        /// Свойство параметр длины
        /// </summary>
        public double LengthRectangle
        {
            get => _lengthRectangle;
            set => _lengthRectangle = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр ширины
        /// </summary>
        public double WidthRectangle
        {
            get => _widthRectangle;
            set => _widthRectangle = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр диагональ
        /// </summary>
        public double DiagonalRectangle
        {
            get => _diagonalRectangle;
            set => _diagonalRectangle = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр угол между диагоналями
        /// </summary>
        public double AngleBetweenDiagonalsRectangle
        {
            get => _angleBetweenDiagonalsRectangle;
            set => _angleBetweenDiagonalsRectangle = 
                CheckArgument.ChekExceptionAngle(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство площадь фигуры
        /// </summary>
        public double FigureArea
        {
            get
            {
                double bufferArea;

                switch (_calcTypeArea)
                {
                    case "sides rectangle":
                        bufferArea = LengthRectangle * WidthRectangle;
                        break;
                    case "diagonal and angle":
                        bufferArea = Math.Sin(
                            AngleBetweenDiagonalsRectangle *
                            Math.PI / 180) *
                            Math.Pow(DiagonalRectangle, 2) / 2;
                        break;
                    default:
                        bufferArea = 0;
                        break;
                }

                return bufferArea;
            }
            set => _figureArea = value;
        }

        /// <summary>
        /// Свойство параметр способ расчета
        /// </summary>
        public Dictionary<int, string> CalcTypeAreaDictionary
        {
            get
            {
                var bufferCalcType = new Dictionary<int, string>();
                bufferCalcType.Add(1,"sides rectangle");
                bufferCalcType.Add(2,"diagonal and angle");
                return bufferCalcType;
            }
        }

        /// <summary>
        /// Свойство параметр способ расчета
        /// </summary>
        public string CalcTypeArea
        {
            set => _calcTypeArea = value;
        }

        /// <summary>
        /// Свойство параметр индекс способа расчета
        /// </summary>
        public int CalcTypeAreaIndex
        {
            get
            {
                int buffer = 0;

                for (int i = 1; i < CalcTypeAreaDictionary.Count + 1; i++)
                {
                    if (CalcTypeAreaDictionary[i] == _calcTypeArea)
                    {
                        buffer = i;
                        break;
                    }
                }

                return buffer;
            }
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string NameFigure
        {
            get => "Rectangle";
        }

        /// <summary>
        /// Варианты измерений фигуры
        /// </summary>
        public List<object> DimensionsFigure
        {
            get
            {
                var buffer = new List<object>();

                switch (_calcTypeArea)
                {
                    case "sides rectangle":
                        buffer.Add("Length");
                        buffer.Add("Width");
                        break;
                    case "diagonal and angle":
                        buffer.Add("Angle, grad.");
                        buffer.Add("Diagonal");
                        break;
                }

                return buffer;
            }
            set
            {
                var buffer = value;

                switch (_calcTypeArea)
                {
                    case "sides rectangle":
                        LengthRectangle = Convert.ToDouble(buffer[0]);
                        WidthRectangle = Convert.ToDouble(buffer[1]);
                        break;
                    case "diagonal and angle":
                        AngleBetweenDiagonalsRectangle = 
                            Convert.ToDouble(buffer[0]);
                        DiagonalRectangle = Convert.ToDouble(buffer[1]);
                        break;
                }
            }
        }

        #endregion

    }
}
