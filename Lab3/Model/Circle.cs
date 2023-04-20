using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Circle class.
    /// </summary>
    public class Circle : FigureBase, IAreaCalculatable
    {
        /// <summary>
        /// Circle radius.
        /// </summary>
        private double _radius;

        /// <summary>
        /// Enter the circle radius.
        /// </summary>
        public double Radius
        {
            get => _radius;
            set => _radius = CheckValue(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Gets circle area.
        /// </summary>
        public double Calculate()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
