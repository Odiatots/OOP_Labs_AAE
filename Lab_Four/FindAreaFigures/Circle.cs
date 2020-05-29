using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaFigures
{
    /// <summary>
    /// Класс круга
    /// </summary>
    [Serializable]
    public class Circle : IFigure
    {

        #region Поля

        /// <summary>
        /// Поле параметр радиус
        /// </summary>
        private double _radiusCircle;

        /// <summary>
        /// Поле параметр диаметр
        /// </summary>
        private double _diameterCircle;

        /// <summary>
        /// Поле параметр длина окружности
        /// </summary>
        private double _circumference;

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
        /// Свойство параметр радиус
        /// </summary>
        public double RadiusCircle
        {
            get => _radiusCircle;
            set => _radiusCircle = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр диаметр
        /// </summary>
        public double DiameterCircle
        {
            get => _diameterCircle;
            set => _diameterCircle = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр длина окружности
        /// </summary>
        public double Circumference
        {
            get => _circumference;
            set => _circumference = CheckArgument.ChekException(
                value, nameof(value));
        }


        /// <summary>
        /// Свойство параметр способ расчета
        /// </summary>
        public Dictionary<int, string> CalcTypeAreaDictionary
        {
            get
            {
                var bufferCalcType = new Dictionary<int, string>();
                bufferCalcType.Add(1, "radius");
                bufferCalcType.Add(2, "diameter");
                bufferCalcType.Add(3, "circumference");
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
                        bufferArea = Math.PI * Math.Pow(RadiusCircle, 2);
                        break;
                    case 2:
                        bufferArea = Math.PI *
                            Math.Pow(DiameterCircle, 2) / 4;
                        break;
                    case 3:
                        bufferArea = Math.Pow(Circumference, 2) / 
                            (4 * Math.PI);
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
            get => "Circle";
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
                        buffer.Add("Radius");
                        break;
                    case 2:
                        buffer.Add("Diameter");
                        break;
                    case 3:
                        buffer.Add("Circumference");
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
                        RadiusCircle = buffer[0];
                        break;
                    case 2:
                        DiameterCircle = buffer[0];
                        break;
                    case 3:
                        Circumference = buffer[0];
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
                        buffer = $"Radius = {RadiusCircle}";
                        break;
                    case 2:
                        buffer = $"Diameter = {DiameterCircle}";
                        break;
                    case 3:
                        buffer = $"Circumference = {Circumference}";
                        break;
                }

                return buffer;
            }
        }

        #endregion

    }
}
