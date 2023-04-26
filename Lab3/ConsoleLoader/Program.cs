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
            IAreaCalculatable figure = new Rectangle();

            var startAction = new Action<string>((string property) =>
            {
                Console.Write
                        ($"Input the {property} (1 - rectangle," +
                        "2 - triangle, 3 - circle):");
                _ = int.TryParse(Console.ReadLine(), out int figureType);

                if (figureType < 1 || figureType > 3)
                {
                    throw new IndexOutOfRangeException
                        ("Number must be in range [1; 3].");
                }

                switch (figureType)
                {
                    case 1:
                        figure = new Rectangle();
                        break;
                    case 2:
                        figure = new Triangle();
                        break;
                    case 3:
                        figure = new Circle();
                        break;
                    default:
                        break;
                }

            });

            var rectangleAction = new List<(Action<string>, string)>
            {
                (new Action<string>((string property) =>
                {
                    Rectangle rectangle = (Rectangle)figure;
                    Console.Write($"Input {property} length: ");
                    rectangle.SideA = CheckNumberDouble(Console.ReadLine());

                }), "side A"),
                (new Action<string>((string property) =>
                {
                    Rectangle rectangle = (Rectangle)figure;
                    Console.Write($"Input {property} length: ");
                    rectangle.SideB = CheckNumberDouble(Console.ReadLine());

                }), "side B"),
                (new Action<string>((string property) =>
                {
                    Rectangle rectangle = (Rectangle)figure;
                    Console.WriteLine($"{property}" +
                    $" of a {rectangle.GetType().Name}: " +
                    ((IAreaCalculatable)rectangle).Calculate());
                    Console.WriteLine();

                }), "Area"),

            };

            var triangleAction = new List<(Action<string>, string)>
            {

                (new Action<string>((string property) =>
                {
                    double triangleArea = 0;
                    while(triangleArea == 0 || double.IsNaN(triangleArea))
                    {

                        Triangle triangle = (Triangle)figure;

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
                    Triangle triangle = (Triangle)figure;
                    Console.WriteLine($"{property}" +
                    $" of a {triangle.GetType().Name}: " +
                    ((IAreaCalculatable)triangle).Calculate());
                    Console.WriteLine();

                }), "Area"),
            };

            var circleAction = new List<(Action<string>, string)>
            {
                (new Action<string>((string property) =>
                {
                    Circle circle = (Circle)figure;
                    Console.Write($"Input {property} length: ");
                    circle.Radius = CheckNumberDouble(Console.ReadLine());

                }), "radius"),
                (new Action<string>((string property) =>
                {
                    Circle circle = (Circle)figure;
                    Console.WriteLine($"{property}" +
                    $" of a {circle.GetType().Name}: " +
                    ((IAreaCalculatable)circle).Calculate());
                    Console.WriteLine();

                }), "Area"),

            };

            ActionHandler(startAction, "figure ID");

            var calculateActionDictionary =
                new Dictionary<Type, List<(Action<string>, string)>>
            {
                {typeof(Rectangle), rectangleAction },
                {typeof(Triangle), triangleAction },
                {typeof(Circle), circleAction },
            };

            foreach (var action in
                calculateActionDictionary[figure.GetType()])
            {
                ActionHandler(action.Item1, action.Item2);
            }
        }

        /// <summary>
        /// A method that checks the valid format of input string.
        /// </summary>
        /// <param name="inputString">Input string.</param>
        /// <returns>Number.</returns>
        /// <exception cref="ArgumentException">Exception.</exception>
        private static double CheckNumberDouble(string inputString)
        {
            if (inputString.Contains('.'))
            {
                inputString = inputString.Replace('.', ',');
            }

            bool isParsed = double.TryParse(inputString,
                        out double checkNumber);

            return !isParsed
                ? throw new ArgumentException("Input number only")
                : checkNumber;
        }
    }
}
