using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Triangle class.
    /// </summary>
    public class Triangle : FigureBase, IAreaCalculatable
    {
        /// <summary>
        /// Side A length.
        /// </summary>
        private double _sideA;

        /// <summary>
        /// Side B length.
        /// </summary>
        private double _sideB;

        /// <summary>
        /// Side C length.
        /// </summary>
        private double _sideC;

        /// <summary>
        /// Initializes a new instance of the <see cref="SideA"/> class.
        /// </summary>
        public double SideA
        {
            get => _sideA;
            set => _sideA = CheckValue(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SideB"/> class.
        /// </summary>
        public double SideB
        {
            get => _sideB;
            set => _sideB = CheckValue(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SideC"/> class.
        /// </summary>
        public double SideC
        {
            get => _sideC;
            set => _sideC = CheckValue(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="sideA">The length of one of the sides of
        /// the triangle.</param>
        /// <param name="sideB">The length of one of the sides of
        /// the triangle.</param>
        /// <param name="sideC">The length of one of the sides of
        /// the triangle.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC
                || sideB + sideC <= sideA
                || sideC + sideA <= sideB)
            {
                throw new ArgumentException("It is impossible to" +
                    " construct a triangle from the entered" +
                    " lengths of segments.");
            }
            else
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
        }

        /// <summary>
        /// Gets triangle area.
        /// </summary>
        public double Calculate()
        {
            return Math.Sqrt((SideA + SideB + SideC) / 2 *
                      ((SideA + SideB + SideC) / 2 - SideA) *
                      ((SideA + SideB + SideC) / 2 - SideB) *
                      ((SideA + SideB + SideC) / 2 - SideC));
        }
    }
}
