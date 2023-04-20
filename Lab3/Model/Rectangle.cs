namespace Model
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
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="sideA">Length of one side of rectangle.</param>
        /// <param name="sideB">Length of one side of rectangle.</param>
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        /// <summary>
        /// Method which calcualte rectangle area.
        /// </summary>
        /// <returns>Rectangle area.</returns>
        public double Calculate()
        {
            return SideA * SideB;
        }
    }
}
