using System;
using System.Xml.Serialization;

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
        /// Method which check sign of lenght of line segment.
        /// </summary>
        /// <param name="lineSegment">Length of the segment.</param>
        /// <returns>Length of the line segment.</returns>
        protected double CheckValue(double lineSegment)
        {
            return lineSegment <= 0
                ? throw new ArgumentException("The length of the" +
                " segment must be positive.")
                : lineSegment;
        }
    }
}
