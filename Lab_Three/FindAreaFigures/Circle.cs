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
        private double _paramR;

        /// <summary>
        /// Поле параметр диаметр
        /// </summary>
        private double _paramD;

        /// <summary>
        /// Поле параметр длина окружности
        /// </summary>
        private double _paramCr;

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
        public double ParamR
        {
            get => _paramR;
            set
            {
                _paramR = CheckArgument.ChekException(value, nameof(value));
            }
        }

        /// <summary>
        /// Свойство параметр диаметр
        /// </summary>
        public double ParamD
        {
            get => _paramD;
            set
            {
                _paramD = CheckArgument.ChekException(value, nameof(value));
            }
        }

        /// <summary>
        /// Свойство параметр длина окружности
        /// </summary>
        public double ParamCr
        {
            get => _paramCr;
            set
            {
                _paramCr = CheckArgument.ChekException(value, nameof(value));
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
                    case "radius":
                        bufferArea = Math.PI * Math.Pow(ParamR, 2);
                        break;
                    case "diameter":
                        bufferArea = Math.PI * Math.Pow(ParamD, 2) / 4;
                        break;
                    case "circumference":
                        bufferArea = Math.Pow(ParamCr, 2) / (4 * Math.PI);
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
