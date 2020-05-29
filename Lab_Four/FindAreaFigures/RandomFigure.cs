using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaFigures
{
    /// <summary>
    /// Создание случайной фигуры
    /// </summary>
    public static class RandomFigure
    {
        /// <summary>
        /// Поле рандома
        /// </summary>
        private static Random _random = new Random();

        public static IFigure CreateFigure()
        {
            IFigure figure = new Circle();

            //var Types = from type in System.Reflection.Assembly
            //            .GetExecutingAssembly().GetTypes()
            //            where typeof(IFigure).IsAssignableFrom(type)
            //            select type;
            //var numbTypes = Types.Count();

            int typeFigure = _random.Next(0, 3);

            if (typeFigure == 0)
            {
                figure = new Circle();
                figure.CalcTypeArea = "radius";
                List<double> buffer = new List<double>();
                buffer.Add(_random.Next(1, 51));
                figure.ValuesDimensionsFigure = buffer;
            }

            if (typeFigure == 1)
            {
                figure = new Rectangle();
                figure.CalcTypeArea = "sides rectangle";
                List<double> buffer = new List<double>();
                buffer.Add(_random.Next(1, 101));
                buffer.Add(_random.Next(1, 101));
                figure.ValuesDimensionsFigure = buffer;
            }

            if (typeFigure == 2)
            {
                figure = new Triangle();
                figure.CalcTypeArea = "side and height lowered onto it";
                List<double> buffer = new List<double>();
                buffer.Add(_random.Next(1, 101));
                buffer.Add(_random.Next(1, 101));
                figure.ValuesDimensionsFigure = buffer;
            }

            return figure;

        }

    }
}
