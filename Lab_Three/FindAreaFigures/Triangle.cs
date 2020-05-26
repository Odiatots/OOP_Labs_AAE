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

        // TODO: реализовать лучше через отдельный класс Params (value, name) или через enum
        /// <summary>
        /// Свойство параметр способы расчета
        /// </summary>
        public Dictionary<int, string> CalcTypeAreaDictionary
        {
            get
            {
                var bufferCalcType = new Dictionary<int, string>();
                bufferCalcType.Add(1, "two sides and the angle");
                bufferCalcType.Add(2, "side and height lowered onto it");
                bufferCalcType.Add(3, "all sides");
                return bufferCalcType;
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

                switch (CalcTypeAreaIndex)
                {
                    case 1:
                        bufferArea = FirstSideTriangle *
                            SecondSideTriangle *
                            Math.Sin(AngleBetweenSidesTriangle *
                            Math.PI / 180) / 2;
                        break;
                    case 2:
                        bufferArea = FirstSideTriangle *
                            SideDownTriangle / 2;
                        break;
                    case 3:
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
            get => "Triangle";
        }

        /// <summary>
        /// Варианты измерений фигуры
        /// </summary>
        public List<string> NamesDimensionsFigure
        {
            get
            {
                var buffer = new List<string>();

                switch (CalcTypeAreaIndex)
                {
                    case 1:
                        buffer.Add("Side 1");
                        buffer.Add("Side 2");
                        buffer.Add("Angle, grad.");
                        break;
                    case 2:
                        buffer.Add("Side 1");
                        buffer.Add("Side down");
                        break;
                    case 3:
                        buffer.Add("Side 1");
                        buffer.Add("Side 2");
                        buffer.Add("Side 3");
                        break;
                }

                return buffer;
            }
        }

        /// <summary>
        /// Значения измерений фигуры
        /// </summary>
        public List<double> ValuesDimensionsFigure
        {
            set
            {
                var buffer = value;

                switch (CalcTypeAreaIndex)
                {
                    case 1:
                        FirstSideTriangle = buffer[0];
                        SecondSideTriangle = buffer[1];
                        AngleBetweenSidesTriangle = buffer[2];
                        break;
                    case 2:
                        FirstSideTriangle = buffer[0];
                        SideDownTriangle = buffer[1];
                        break;
                    case 3:
                        FirstSideTriangle = buffer[0];
                        SecondSideTriangle = buffer[1];
                        ThirdSideTriangle = buffer[2];
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
        private bool IsExistTriangle(double a, double b, double c)
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
