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
        /// Имя
        /// </summary>
        public string NameFigure { get; }

        /// <summary>
        /// Свойство площадь фигуры
        /// </summary>
        public double FigureArea { get; set; }

        /// <summary>
        /// Выходные параметры для вывода
        /// </summary>
        public string DimensionsToOutput { get; }
        
        /// <summary>
        /// Словарь типов исходных данных
        /// </summary>
        public Dictionary<int, string> CalcTypeAreaDictionary { get; }

        /// <summary>
        /// Тип исходных данных
        /// </summary>
        public string CalcTypeArea { set; }

        /// <summary>
        /// Имена измерений фигуры
        /// </summary>
        public List<string> NamesDimensionsFigure { get; }

        /// <summary>
        /// Значения измерений фигуры
        /// </summary>
        public List<double> ValuesDimensionsFigure { set; }

    }
}
