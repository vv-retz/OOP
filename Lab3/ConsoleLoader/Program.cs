using Model;

namespace ConsoleLoader
{
    /// <summary>
    /// Class Program.
    /// </summary>
    internal class Program
    {
        // TODO: Interface vs Abstract method

        /// <summary>
        /// Method Main.
        /// </summary>
        private static void Main()
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
                    Math.Round(((IAreaCalculatable)figures).Calculate(), 3));
            }

            Console.WriteLine();
            Console.WriteLine("You can try it yourself!\n");

            while (true)
            {
                Console.WriteLine("Try to calculate area of the" +
                    " figure - enter 1," +
                    " end the program - enter 2.");

                bool isParsed = int.TryParse(Console.ReadLine(),
                            out int actionNumber);

                if (!isParsed || actionNumber < 1 || actionNumber > 2)
                {
                    Console.WriteLine("1 or 2?");
                    continue;
                }

                switch (actionNumber)
                {
                    case 1:
                        {
                            CalculateAreaByConsole();
                            break;
                        }

                    case 2:
                        {
                            return;
                        }

                    default:
                        {
                            break;
                        }
                }
            }

        }

        /// <summary>
        /// Method which is used for doing actions from the list.
        /// </summary>
        /// <param name="action">A certain action.</param>
        /// <param name="propertyName">Additional parameter
        /// for exception.</param>
        private static void ActionHandler
            (Action<string> action, string propertyName)
        {
            while (true)
            {
                try
                {
                    action.Invoke(propertyName);
                    break;
                }
                catch (Exception exception)
                {
                    if (exception.GetType()
                        == typeof(IndexOutOfRangeException)
                        || exception.GetType() == typeof(FormatException)
                        || exception.GetType() == typeof(ArgumentException))
                    {
                        Console.WriteLine($"Incorrect {propertyName}." +
                        $" Error: {exception.Message}" +
                        $"Please, enter the {propertyName} again.");
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }

        /// <summary>
        /// Method which allows to enter information by console.
        /// </summary>
        /// <exception cref="ArgumentException">Only numbers.</exception>
        public static void CalculateAreaByConsole()
        {
            var startAction = new Action<string>((string property) =>
            {
                Console.Write
                        ($"Input the {property} (1 - rectangle," +
                        "2 - triangle, 3 - circle):");
                _ = int.TryParse(Console.ReadLine(), out int figureType);

                switch (figureType)
                {
                    case 1:
                        RectangleArea();
                        break;
                    case 2:
                        TriangleArea();
                        break;
                    case 3:
                        CircleArea();
                        break;
                    default:
                        throw new IndexOutOfRangeException(
                            "Number must be in range [1; 3].");
                }

            });

            ActionHandler(startAction, "figure ID");
        }

        /// <summary>
        /// A method that checks the valid format of input string.
        /// </summary>
        /// <param name="inputString">Input string.</param>
        /// <returns>Number.</returns>
        /// <exception cref="ArgumentException">Exception.</exception>
        private static double CheckNumberDouble(string inputString)
        {
            inputString = inputString.Replace('.', ',');
            bool isParsed = double.TryParse(inputString,
                        out double checkNumber);

            return !isParsed
                ? throw new ArgumentException("Input number only")
                : checkNumber;
        }

        /// <summary>
        /// Method which allows to calculate area of some rectangle.
        /// </summary>
        /// <exception cref="ArgumentException">Only numbers.</exception>
        public static void RectangleArea()
        {
            Rectangle rectangle = new Rectangle();

            var rectangleAction = new List<(Action<string>, string)>
            {
                (new Action<string>((string property) =>
                {
                    Console.Write($"Input {property} length: ");
                    rectangle.SideA = CheckNumberDouble(Console.ReadLine());

                }), "side A"),
                (new Action<string>((string property) =>
                {
                    Console.Write($"Input {property} length: ");
                    rectangle.SideB = CheckNumberDouble(Console.ReadLine());

                }), "side B"),
                (new Action<string>((string property) =>
                {
                    Console.WriteLine($"{property}" +
                    $" of a {rectangle.GetType().Name}: " +
                    ((IAreaCalculatable)rectangle).Calculate());
                    Console.WriteLine();

                }), "Area"),

            };

            foreach (var action in rectangleAction)
            {
                ActionHandler(action.Item1, action.Item2);
            }

        }

        /// <summary>
        /// Method which allows to calculate area of some triangle.
        /// </summary>
        /// <exception cref="ArgumentException">Only numbers.</exception>
        public static void TriangleArea()
        {
            Triangle triangle = new Triangle();

            var triangleAction = new List<(Action<string>, string)>
            {
                (new Action<string>((string property) =>
                {
                    double triangleArea = 0;
                    while(triangleArea == 0 || double.IsNaN(triangleArea))
                    {

                        var triangleAction1 =
                        new List<(Action<string>, string)>
                        {
                            (new Action<string>((string property) =>
                            {
                                Console.Write($"Input {property} length: ");
                                triangle.SideA = CheckNumberDouble
                                (Console.ReadLine());

                            }), "side A"),
                            (new Action<string>((string property) =>
                            {
                                Console.Write($"Input {property} length: ");
                                triangle.SideB = CheckNumberDouble
                                (Console.ReadLine());

                            }), "side B"),
                            (new Action<string>((string property) =>
                            {
                                Console.Write($"Input {property} length: ");
                                triangle.SideC = CheckNumberDouble
                                (Console.ReadLine());

                            }), "side C"),
                            (new Action<string>((string property) =>
                            {
                                try
                                {
                                    triangle = new Triangle
                                        (triangle.SideA,
                                        triangle.SideB,
                                        triangle.SideC);
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }), "triangle"),
                            (new Action<string>((string property) =>
                            {
                                triangleArea =
                                ((IAreaCalculatable)triangle).Calculate();

                            }), "area"),

                        };

                        foreach (var action in
                            triangleAction1)
                        {
                            ActionHandler(action.Item1, action.Item2);
                        }

                    }
                }), "triangle"),

                (new Action<string>((string property) =>
                {
                    Console.WriteLine($"{property}" +
                    $" of a {triangle.GetType().Name}: " +
                    triangle.Calculate());
                    Console.WriteLine();

                }), "Area"),
            };

            foreach (var action in triangleAction)
            {
                ActionHandler(action.Item1, action.Item2);
            }

        }

        /// <summary>
        /// Method which allows to calculate area of some circle.
        /// </summary>
        /// <exception cref="ArgumentException">Only numbers.</exception>
        public static void CircleArea()
        {
            Circle circle = new Circle();

            var circleAction = new List<(Action<string>, string)>
            {
                (new Action<string>((string property) =>
                {
                    Console.Write($"Input {property} length: ");
                    circle.Radius = CheckNumberDouble(Console.ReadLine());

                }), "radius"),
                (new Action<string>((string property) =>
                {
                    Console.WriteLine($"{property}" +
                    $" of a {circle.GetType().Name}: " +
                    ((IAreaCalculatable)circle).Calculate());
                    Console.WriteLine();

                }), "Area"),

            };

            foreach (var action in circleAction)
            {
                ActionHandler(action.Item1, action.Item2);
            }

        }
    }
}
