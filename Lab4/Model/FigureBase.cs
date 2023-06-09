using System;
using System.Xml.Serialization;
using System.ComponentModel;

namespace Model
{
    /// <summary>
    /// FigureBase class.
    /// </summary>
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Triangle))]
    [XmlInclude(typeof(Circle))]
    public abstract class FigureBase
    {
        /// <summary>
        /// Figure type field's property sent to DataGridView.
        /// </summary>
        public abstract string FigureType { get; }

        /// <summary>
        /// Parameters field's property sent to DataGridView.
        /// </summary>
        public abstract string Parameters { get; }

        /// <summary>
        /// Area field's property.
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// Method which check None and negative of length of line segment.
        /// </summary>
        /// <param name="lineSegment">Length of the segment.</param>
        /// <returns>Length of the line segment.</returns>
        protected double CheckValue(double lineSegment)
        {
            if (double.IsNaN(lineSegment))
            {
                throw new ArgumentOutOfRangeException("The length of the" +
                " segment must not be NaN.");
            }

            return lineSegment <= 0
                ? throw new ArgumentException("The length of the" +
                " segment must be positive.")
                : lineSegment;
        }

        /// <summary>
        /// Method which calculate area.
        /// </summary>
        /// <returns>Area.</returns>
        public abstract double Calculate { get; }
    }
}
