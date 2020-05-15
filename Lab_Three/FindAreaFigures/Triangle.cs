using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaFigures
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : IFigure
    {

        #region Поля

        /// <summary>
        /// Поле параметр сторона 1
        /// </summary>
        private double _paramA;

        /// <summary>
        /// Поле параметр сторона 2
        /// </summary>
        private double _paramB;

        /// <summary>
        /// Поле параметр сторона 3
        /// </summary>
        private double _paramC;

        /// <summary>
        /// Поле параметр угол между сторонами 1 и 2
        private double _paramAlpha;

        /// <summary>
        /// Поле параметр высота, опущенная на сторону 1
        private double _paramH;

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
        /// Свойство параметр сторона 1
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
        /// Свойство параметр сторона 2
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
        /// Свойство параметр сторона 3
        /// </summary>
        public double ParamC
        {
            get => _paramC;
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
                    _paramC = value;
                }
            }
        }

        /// <summary>
        /// Свойство параметр угол между сторонами 1 и 2
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
        /// Свойство параметр высота, опущенная на сторону 1
        /// </summary>
        public double ParamH
        {
            get => _paramH;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be greater " +
                        $"than or equal to zero");
                }
                else if (Double.IsNaN(_paramH))
                {
                    throw new ArithmeticException(
                        $"{nameof(value)} is NaN");
                }
                else
                {
                    _paramH = value;
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
                    case "two sides and the angle":
                        bufferArea = ParamA * ParamB *
                            Math.Sin(ParamAlpha * Math.PI / 180) / 2;
                        break;
                    case "side and height lowered onto it":
                        bufferArea = ParamA * ParamH / 2;
                        break;
                    case "all sides":
                        if (IsExistTriangle(ParamA, ParamB, ParamC))
                        {
                            double halfP = (ParamA + ParamB + ParamC) / 2;
                            bufferArea = Math.Sqrt(halfP * (halfP - ParamA) *
                                (halfP - ParamB) * (halfP - ParamC));
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(
                                "triangle does not exist");
                        }
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
                bufferCalcType.Add("two sides and the angle");
                bufferCalcType.Add("side and height lowered onto it");
                bufferCalcType.Add("all sides");
                return bufferCalcType;
            }
        }

        #endregion

        #region Методы

        /// <summary>
        /// Проверка существования треугольника
        /// </summary>
        /// <param name="a">Сторона 1</param>
        /// <param name="b">Сторона 2</param>
        /// <param name="c">Сторона 3</param>
        /// <returns>да/нет</returns>
        public bool IsExistTriangle(double a, double b, double c)
        {
            a = ParamA;
            b = ParamB;
            c = ParamC;

            if (a + b > c & a + c > b & b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
