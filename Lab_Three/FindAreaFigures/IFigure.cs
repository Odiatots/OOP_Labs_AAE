using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaFigures
{
    /// <summary>
    /// Базовый класс фигуры
    /// </summary>
    public interface IFigure
    {

        /// <summary>
        /// Свойство площадь фигуры
        /// </summary>
        double FigureArea { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string NameFigure { get; }

        /// <summary>
        /// Тип исходных данных
        /// </summary>
        public List<string> CalcType { get; }

    }
}
