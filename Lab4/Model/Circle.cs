using System;

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
        /// Gets or sets circle radius.
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
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle()
        {
        }

        /// <summary>
        /// Figure type field's property sent to DataGridView.
        /// </summary>
        public override string FigureType => "Circle";

        /// <summary>
        /// Parameters field's property sent to DataGridView.
        /// </summary>
        public override string Parameters => $"radius = {Radius}";

        /// <summary>
        /// Area field's property.
        /// </summary>
        public override double Area => Calculate();

        /// <summary>
        /// Method which calcualte circle area.
        /// </summary>
        /// <returns>Circle area.</returns>
        public double Calculate()
        {
            return Math.Round(Math.Pow(Radius, 2) * Math.PI, 3);
        }
    }
}
