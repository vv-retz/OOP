using System;

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
        /// Gets or sets <see cref="SideA"/>.
        /// </summary>
        public double SideA
        {
            get => _sideA;
            set => _sideA = CheckValue(value);
        }

        /// <summary>
        /// Gets or sets <see cref="SideB"/>.
        /// </summary>
        public double SideB
        {
            get => _sideB;
            set => _sideB = CheckValue(value);
        }

        /// <summary>
        /// Gets or sets <see cref="SideC"/>.
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
        /// Method which calcualte triangle area.
        /// </summary>
        /// <returns>Triangle area.</returns>
        public double Calculate()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p *
                      (p - SideA) *
                      (p - SideB) *
                      (p - SideC));
        }
    }
}
