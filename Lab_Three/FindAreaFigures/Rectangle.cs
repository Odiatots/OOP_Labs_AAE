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
        private double _paramA;

        /// <summary>
        /// Поле параметр ширины
        /// </summary>
        private double _paramB;

        /// <summary>
        /// Поле параметр диагональ
        /// </summary>
        private double _paramDg;

        /// <summary>
        /// Поле параметр угол между диагоналями
        /// </summary>
        private double _paramAlpha;

        /// <summary>
        /// Поле параметр площадь фигуры
        /// </summary>
        private double _figureArea;

        /// <summary>
        /// Поле параметр способ расчета
        /// </summary>
        private string _calcType;

        #endregion

        #region Свойства

        /// <summary>
        /// Свойство параметр длины
        /// </summary>
        public double ParamA
        {
            get => _paramA;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be greater " +
                        $"than or equal to zero");
                }
                else if (Double.IsNaN(_paramA))
                {
                    throw new ArithmeticException(
                        $"{nameof(value)} is NaN");
                }
                else
                {
                    _paramA = value;
                }
            }
        }

        /// <summary>
        /// Свойство параметр ширины
        /// </summary>
        public double ParamB
        {
            get => _paramB;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be greater " +
                        $"than or equal to zero");
                }
                else if (Double.IsNaN(_paramB))
                {
                    throw new ArithmeticException(
                        $"{nameof(value)} is NaN");
                }
                else
                {
                    _paramB = value;
                }
            }
        }

        /// <summary>
        /// Свойство параметр диагональ
        /// </summary>
        public double ParamDg
        {
            get => _paramDg;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be greater " +
                        $"than or equal to zero");
                }
                else if (Double.IsNaN(_paramDg))
                {
                    throw new ArithmeticException(
                        $"{nameof(value)} is NaN");
                }
                else
                {
                    _paramDg = value;
                }
            }
        }

        /// <summary>
        /// Свойство параметр угол между диагоналями
        /// </summary>
        public double ParamAlpha
        {
            get => _paramAlpha;
            set
            {
                if (value < 0 || value > 180)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 180");
                }
                else if (Double.IsNaN(_paramAlpha))
                {
                    throw new ArithmeticException(
                        $"{nameof(value)} is NaN");
                }
                else
                {
                    _paramAlpha = value;
                }
            }
        }

        /// <summary>
        /// Свойство площадь фигуры
        /// </summary>
        public double FigureArea
        {
            get
            {
                double bufferArea;

                switch (_calcType)
                {
                    case "side rectangle":
                        bufferArea = ParamA * ParamB;
                        break;
                    case "diagonal and angle":
                        bufferArea = Math.Sin(ParamAlpha * Math.PI / 180) *
                            Math.Pow(ParamDg, 2) / 2;
                        break;
                    default:
                        bufferArea = 0;
                        break;
                }

                return bufferArea;
            }
            set
            {
                _figureArea = value;
            }
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

        #endregion

    }
}
