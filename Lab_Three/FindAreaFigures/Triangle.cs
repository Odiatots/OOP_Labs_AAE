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
        /// Поле параметр площадь фигуры
        /// </summary>
        private double _figureArea;

        #endregion

        #region Свойства

        /// <summary>
        /// Свойство параметр сторона 1
        /// </summary>
        public double ParamA
        {
            get { return _paramA; }
            set { _paramA = value; }
        }

        /// <summary>
        /// Свойство параметр сторона 2
        /// </summary>
        public double ParamB
        {
            get { return _paramB; }
            set { _paramB = value; }
        }

        /// <summary>
        /// Свойство параметр сторона 3
        /// </summary>
        public double ParamC
        {
            get { return _paramC; }
            set { _paramC = value; }
        }

        /// <summary>
        /// Свойство площадь фигуры
        /// </summary>
        public double FigureArea
        {
            get
            {
                double bufferArea = 0;

                double halfPerimeter = (ParamA + ParamB + ParamC) / 2;

                if ((ParamA != 0) & (ParamB != 0) & (ParamC != 0))
                {
                    bufferArea = halfPerimeter * 
                        (halfPerimeter - ParamA) * 
                        (halfPerimeter - ParamB) * 
                        (halfPerimeter - ParamC);
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
