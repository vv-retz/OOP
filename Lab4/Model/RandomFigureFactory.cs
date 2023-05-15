using System;

namespace Model
{
    /// <summary>
    /// Class to get random parameters of figure.
    /// </summary>
    public class RandomFigureFactory
    {
        /// <summary>
        /// Random.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Max value of parameter.
        /// </summary>
        private const int MaxValue = 10;

        /// <summary>
        /// Min value of parameter.
        /// </summary>
        private const int MinValue = 1;

        /// <summary>
        /// Divider.
        /// </summary>
        private const double Divider = 1.0;

        /// <summary>
        /// Generate random double.
        /// </summary>
        /// <param name="minValue">Min value.</param>
        /// <param name="maxValue">Max value.</param>
        /// <param name="divider">Divider.</param>
        /// <returns>Double.</returns>
        public static double GetRandomDouble(int minValue, int maxValue,
            double divider)
        {
            var randomValue = Convert.ToDouble(_random.Next(minValue, maxValue));
            return randomValue / divider;
        }

        /// <summary>
        /// Get the instance of a certain figure.
        /// </summary>
        /// <param name="figureType">Figure type.</param>
        /// <returns>An instance of a certain figure.</returns>
        /// <exception cref="ArgumentException">Only designated figure
        /// types.</exception>
        public FigureBase GetInstance(FigureType figureType)
        {

            switch (figureType)
            {
                case (FigureType.Triangle):
                    {
                        var sideA = GetRandomDouble
                            (MinValue, MaxValue, Divider);

                        var sideB = GetRandomDouble
                            (MinValue, Convert.ToInt32(sideA), Divider);

                        var sideC = GetRandomDouble
                            (Convert.ToInt32(sideA)
                            + Convert.ToInt32(sideB) - 1, Convert.ToInt32(sideA)
                            + Convert.ToInt32(sideB), Divider);

                        return new Triangle
                            (sideA, sideB, sideC);
                    }

                case (FigureType.Rectangle):
                    {
                        var sideA = GetRandomDouble
                            (MinValue, MaxValue, Divider);

                        var sideB = GetRandomDouble
                            (MinValue, MaxValue, Divider);

                        return new Rectangle
                            (sideA, sideB);
                    }

                case (FigureType.Circle):
                    {
                        var radius = GetRandomDouble(MinValue, MaxValue, Divider);

                        return new Circle
                            (radius);
                    }

                default:
                    throw new ArgumentException
                        ("Enter only designated figure types.");
            }
        }
    }
}
