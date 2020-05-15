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
            set => _paramA = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр ширины
        /// </summary>
        public double ParamB
        {
            get => _paramB;
            set => _paramB = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр диагональ
        /// </summary>
        public double ParamDg
        {
            get => _paramDg;
            set => _paramDg = CheckArgument.ChekException(
                value, nameof(value));
        }

        /// <summary>
        /// Свойство параметр угол между диагоналями
        /// </summary>
        public double ParamAlpha
        {
            get => _paramAlpha;
            set => _paramAlpha = CheckArgument.ChekExceptionAngle(
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
