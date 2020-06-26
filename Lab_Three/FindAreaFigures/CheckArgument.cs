using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaFigures
{
    /// <summary>
    /// Проверка аргументов
    /// </summary>
    public static class CheckArgument
    {
        /// <summary>
        /// Метод проброса исключений для параметров
        /// </summary>
        /// <param name="dimension">Параметр</param>
        /// <param name="name">Название параметра</param>
        /// <returns>Проверенный параметр</returns>
        public static double ChekException(double dimension, string name)
        {
            if (dimension < 0)
            {
                throw new ArgumentOutOfRangeException(
                    $"{name} must be greater " +
                    $"than or equal to zero.");
            }
            else if (Double.IsNaN(dimension))
            {
                throw new ArithmeticException(
                    $"{name} is NaN");
            }
            else
            {
                return dimension;
            }
        }

        /// <summary>
        /// Метод проброса исключений для параметров угла
        /// </summary>
        /// <param name="dimension">Параметр</param>
        /// <param name="name">Название параметра</param>
        /// <returns>Проверенный параметр</returns>
        public static double ChekExceptionAngle(
            double dimension, string name)
        {
            if (dimension > 180)
            {
                throw new ArgumentOutOfRangeException(
                    $"{name} must be less than 180.");
            }
            else
            {
                return CheckArgument.ChekException(dimension, name:name);
            }
        }
    }
}
