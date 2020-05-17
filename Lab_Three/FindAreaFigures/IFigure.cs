﻿using System;
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
        /// Словарь типов исходных данных
        /// </summary>
        public Dictionary<int, string> CalcTypeAreaDictionary { get; }

        /// <summary>
        /// Тип исходных данных
        /// </summary>
        public string CalcTypeArea { set; }

        /// <summary>
        /// Варианты измерений фигуры
        /// </summary>
        public List<object> DimensionsFigure { get; set; }

    }
}
