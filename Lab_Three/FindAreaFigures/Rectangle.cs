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
        /// Поле параметр площадь фигуры
        /// </summary>
        private double _figureArea;

        #endregion

        #region Свойства

        /// <summary>
        /// Свойство параметр длины
        /// </summary>
        public double ParamA
        {
            get { return _paramA; }
            set { _paramA = value; }
        }

        /// <summary>
        /// Свойство параметр ширины
        /// </summary>
        public double ParamB
        {
            get { return _paramB; }
            set { _paramB = value; }
        }

        /// <summary>
        /// Свойство площадь фигуры
        /// </summary>
        public double FigureArea
        {
            get
            {
                {
                    double bufferArea = 0;

                    if ((ParamA != 0) & (ParamB != 0))
                    {
                        bufferArea = ParamA * ParamB;
                    }

                    return bufferArea;
                }
            }
            set
            {
                _figureArea = value;
            }
        }

        #endregion

    }
}
