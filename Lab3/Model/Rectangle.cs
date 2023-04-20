namespace Model
{
    internal class Rectangle
    {
        /// <summary>
        /// Rectangle class.
        /// </summary>
        public class Rectangle : FigureBase, IAreaCalculatable
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
            /// Gets or sets initializes a new instance of the <see cref="SideA"/> class.
            /// </summary>
            public double SideA
            {
                get => _sideA;
                set => _sideA = CheckValue(value);
            }

            /// <summary>
            /// Gets or sets initializes a new instance of the <see cref="SideB"/> class.
            /// </summary>
            public double SideB
            {
                get => _sideB;
                set => _sideB = CheckValue(value);
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Rectangle"/> class.
            /// </summary>
            /// <param name="sideA">The length of one of the sides of
            /// the triangle.</param>
            /// <param name="sideB">The length of one of the sides of
            /// the triangle.</param>
            public Rectangle(double sideA, double sideB)
            {
                SideA = sideA;
                SideB = sideB;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public double Calculate()
            {
                return SideA * SideB;
            }
        }
    }
}
