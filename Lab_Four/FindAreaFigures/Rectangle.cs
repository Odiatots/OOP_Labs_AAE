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
    [Serializable]
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
                value, name: "Length");
        }

        /// <summary>
        /// Свойство параметр ширины
        /// </summary>
        public double WidthRectangle
        {
            get => _widthRectangle;
            set => _widthRectangle = CheckArgument.ChekException(
                value, name: "Width");
        }

        /// <summary>
        /// Свойство параметр диагональ
        /// </summary>
        public double DiagonalRectangle
        {
            get => _diagonalRectangle;
            set => _diagonalRectangle = CheckArgument.ChekException(
                value, name: "Diagonal");
        }

        /// <summary>
        /// Свойство параметр угол между диагоналями
        /// </summary>
        public double AngleBetweenDiagonalsRectangle
        {
            get => _angleBetweenDiagonalsRectangle;
            set => _angleBetweenDiagonalsRectangle = 
                CheckArgument.ChekExceptionAngle(
                value, name: "Angle, grad.");
        }

        /// <summary>
        /// Свойство параметр способ расчета
        /// </summary>
        public Dictionary<int, string> CalcTypeAreaDictionary
        {
            get
            {
                var bufferCalcType = new Dictionary<int, string>();
                bufferCalcType.Add(1, "sides rectangle");
                bufferCalcType.Add(2, "diagonal and angle");
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
                        bufferArea = LengthRectangle * WidthRectangle;
                        break;
                    case 2:
                        bufferArea = Math.Sin(
                            AngleBetweenDiagonalsRectangle *
                            Math.PI / 180) *
                            Math.Pow(DiagonalRectangle, 2) / 2;
                        break;
                    default:
                        bufferArea = 0;
                        break;
                }

                return Math.Round(bufferArea, 3);
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
            get => "Rectangle";
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
                        buffer.Add("Length");
                        buffer.Add("Width");
                        break;
                    case 2:
                        buffer.Add("Angle, grad.");
                        buffer.Add("Diagonal");
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
                        LengthRectangle = buffer[0];
                        WidthRectangle = buffer[1];
                        break;
                    case 2:
                        AngleBetweenDiagonalsRectangle = buffer[0];
                        DiagonalRectangle = buffer[1];
                        break;
                }
            }
        }

        /// <summary>
        /// Выходные параметры для вывода
        /// </summary>
        public string DimensionsToOutput
        {
            get
            {
                string buffer = string.Empty;

                switch (CalcTypeAreaIndex)
                {
                    case 1:
                        buffer = $"Length = {LengthRectangle}," +
                            $" Width = {WidthRectangle}";
                        break;
                    case 2:
                        buffer = $"Angle = {AngleBetweenDiagonalsRectangle}," +
                            $" Diagonal = {DiagonalRectangle}";
                        break;
                }

                return buffer;
            }
        }

        #endregion

    }
}
