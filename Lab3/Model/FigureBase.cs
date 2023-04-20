using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// FigureBase class.
    /// </summary>
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
