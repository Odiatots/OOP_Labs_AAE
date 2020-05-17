﻿using System;
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
        private double _firstSideTriangle;

        /// <summary>
        /// Поле параметр сторона 2
        /// </summary>
        private double _secondSideTriangle;

        /// <summary>
        /// Поле параметр сторона 3
        /// </summary>
        private double _thirdSideTriangle;

        /// <summary>
        /// Поле параметр угол между сторонами 1 и 2
        private double _angleBetweenSidesTriangle;

        /// <summary>
        /// Поле параметр высота, опущенная на сторону 1
        private double _sideDownTriangle;

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
        /// Свойство параметр сторона 1
        /// </summary>
        public double FirstSideTriangle
        {
            get => _firstSideTriangle;
            set => _firstSideTriangle = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр сторона 2
        /// </summary>
        public double SecondSideTriangle
        {
            get => _secondSideTriangle;
            set => _secondSideTriangle = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр сторона 3
        /// </summary>
        public double ThirdSideTriangle
        {
            get => _thirdSideTriangle;
            set => _thirdSideTriangle = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр угол между сторонами 1 и 2
        /// </summary>
        public double AngleBetweenSidesTriangle
        {
            get => _angleBetweenSidesTriangle;
            set => _angleBetweenSidesTriangle = 
                CheckArgument.ChekExceptionAngle(value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр высота, опущенная на сторону 1
        /// </summary>
        public double SideDownTriangle
        {
            get => _sideDownTriangle;
            set => _sideDownTriangle = CheckArgument.ChekException(
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
                    case "two sides and the angle":
                        bufferArea = FirstSideTriangle *
                            SecondSideTriangle *
                            Math.Sin(AngleBetweenSidesTriangle *
                            Math.PI / 180) / 2;
                        break;
                    case "side and height lowered onto it":
                        bufferArea = FirstSideTriangle *
                            SideDownTriangle / 2;
                        break;
                    case "all sides":
                        if (IsExistTriangle(FirstSideTriangle, 
                            SecondSideTriangle, ThirdSideTriangle))
                        {
                            double halfP = 
                                (FirstSideTriangle +
                                SecondSideTriangle + 
                                ThirdSideTriangle) / 2;
                            bufferArea = Math.Sqrt(halfP * 
                                (halfP - FirstSideTriangle) * 
                                (halfP - SecondSideTriangle) * 
                                (halfP - ThirdSideTriangle));
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
            set => _figureArea = value;
        }

        /// <summary>
        /// Свойство параметр способы расчета
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

        /// <summary>
        /// Свойство параметр способ расчета
        /// </summary>
        public string CalcTypeArea
        {
            set => _calcTypeArea = value;
            get => _calcTypeArea;
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string NameFigure
        {
            get => "Triangle";
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
                    case "two sides and the angle":
                        buffer.Add(FirstSideTriangle);
                        buffer.Add(SecondSideTriangle);
                        buffer.Add(AngleBetweenSidesTriangle);
                        break;
                    case "side and height lowered onto it":
                        buffer.Add(FirstSideTriangle);
                        buffer.Add(SideDownTriangle);
                        break;
                    case "all sides":
                        buffer.Add(FirstSideTriangle);
                        buffer.Add(SecondSideTriangle);
                        buffer.Add(ThirdSideTriangle);
                        break;
                }

                return buffer;
            }
            set
            {
                var buffer = value;

                switch (_calcTypeArea)
                {
                    case "two sides and the angle":
                        FirstSideTriangle = Convert.ToDouble(buffer[0]);
                        SecondSideTriangle = Convert.ToDouble(buffer[1]);
                        AngleBetweenSidesTriangle = 
                            Convert.ToDouble(buffer[2]);
                        break;
                    case "side and height lowered onto it":
                        FirstSideTriangle = Convert.ToDouble(buffer[0]);
                        SideDownTriangle = Convert.ToDouble(buffer[1]);
                        break;
                    case "all sides":
                        FirstSideTriangle = Convert.ToDouble(buffer[0]);
                        SecondSideTriangle = Convert.ToDouble(buffer[1]);
                        ThirdSideTriangle = Convert.ToDouble(buffer[2]);
                        break;
                }
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
