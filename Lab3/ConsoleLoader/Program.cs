using Model;

namespace ConsoleLoader
{
    /// <summary>
    /// Class Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Method Main.
        /// </summary>
        /// <param name="args">Arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Let's calculate" +
                " areas of different figures!\n");

            var figuresList = new List<FigureBase>()
            {
                new Circle(5.6),
                new Rectangle(4, 5.7),
                new Triangle(3, 2, 4),
            };

            foreach (var figures in figuresList)
            {
                Console.WriteLine($"Area of a {figures.GetType().Name}: " +
                            ((IAreaCalculatable)figures).Calculate());
            }
            Console.WriteLine();
            Console.WriteLine("You can try it yourself!" +
                " Input the type of figure (1 - rectangular," +
                "2 - triangle, 3 - circle):");

        }
    }
}
