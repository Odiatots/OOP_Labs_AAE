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
        private string _calcType;

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
        /// Свойство площадь фигуры
        /// </summary>
        public double FigureArea
        {
            get
            {
                double bufferArea;

                switch (_calcType)
                {
                    case "radius":
                        bufferArea = Math.PI * Math.Pow(RadiusCircle, 2);
                        break;
                    case "diameter":
                        bufferArea = Math.PI * Math.Pow(DiameterCircle, 2) / 4;
                        break;
                    case "circumference":
                        bufferArea = Math.Pow(Circumference, 2) / (4 * Math.PI);
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
                bufferCalcType.Add("radius");
                bufferCalcType.Add("diameter");
                bufferCalcType.Add("circumference");
                return bufferCalcType;
            }
        }

        #endregion

    }
}
