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
        /// Поле параметр площадь фигуры
        /// </summary>
        private double _figureArea;

        #endregion

        #region Свойства

        /// <summary>
        /// Свойство параметр радиус
        /// </summary>
        public double ParamR
        {
            get { return _paramR; }
            set { _paramR = value; }
        }

        /// <summary>
        /// Свойство площадь фигуры
        /// </summary>
        public double FigureArea
        {
            get
            {
                double bufferArea = 0;

                if (ParamR != 0)
                {
                    bufferArea = 2 * Math.PI * ParamR;
                }

                return bufferArea;
            }
            set
            {
                _figureArea = value;
            }
        }

        #endregion

    }
}
