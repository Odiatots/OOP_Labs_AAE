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
                    case "side rectangle":
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
        public List<string> CalcType
        {
            get
            {
                var bufferCalcType = new List<string>();
                bufferCalcType.Add("side rectangle");
                bufferCalcType.Add("diagonal and angle");
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
                    case "side rectangle":
                        buffer.Add(LengthRectangle);
                        buffer.Add(WidthRectangle);
                        break;
                    case "diagonal and angle":
                        buffer.Add(AngleBetweenDiagonalsRectangle);
                        buffer.Add(DiagonalRectangle);
                        break;
                }

                return buffer;
            }
            set
            {
                var buffer = value;

                switch (_calcTypeArea)
                {
                    case "side rectangle":
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
