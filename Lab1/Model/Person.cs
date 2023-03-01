using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    /// <summary>
    /// Class which describe persons.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Name of person.
        /// </summary>
        private string _name;

        /// <summary>
        /// Surname of person.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Age of person.
        /// </summary>
        private int _age;

        /// <summary>
        /// Gender of person.
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Minimum age value.
        /// </summary>
        private const int MinAge = 0;

        /// <summary>
        /// Maximum age value.
        /// </summary>
        private const int MaxAge = 150;

        /// <summary>
        /// Enter the name of person.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Enter the surname of person.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }

        /// <summary>
        /// Enter the age of person.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new IndexOutOfRangeException("Age value must" +
                          $" be in range [{MinAge}:{MaxAge}].");
                }
                else
                {
                    _age = value;
                }
            }
        }

        /// <summary>
        /// Enter the gender of person.
        /// </summary>
        public Gender Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Person's constructor.
        /// </summary>
        /// <param name="name">Name of person.</param>
        /// <param name="surname">Surname of person.</param>
        /// <param name="age">Age of person.</param>
        /// <param name="gender">Gender of person.</param>
        public Person
            (string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        { }

        /// <summary>
        /// Converts class field value to string format.
        /// </summary>
        /// <returns>Information about person.</returns>
        public override string ToString()
        {
            return $"{Name} {Surname}; Age - {Age}; Gender - {Gender}";
        }

        /// <summary>
        /// Method which allows to enter a random person.
        /// </summary>
        /// <returns>Random person.</returns>
        public static Person GetRandomPerson()
        {
            string[] maleNames =
            {
                "Alex", "Tom", "John", "Vlad", "Eugene",
                "Viktor", "Ivan", "Petr", "Khariton"
            };

            string[] femaleNames =
            {
                "Darya", "Valentina", "Varvara", "Julia", "Alyona",
                "Elena", "Katerine", "Olga", "Sofia"
            };

            string[] surnames =
            {
                "Abramson", "Alford", "Anderson", "Bates", "Bethel",
                "Becker", "Richards", "Pearcy", "Peterson", "Philips"
            };

            var random = new Random();
            var tmpNumber = random.Next(1, 3);

            Gender tmpGender = tmpNumber == 1
                ? Gender.Male
                : Gender.Female;

            string tmpName = tmpGender == Gender.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];

            var tmpSurname = surnames[random.Next(surnames.Length)];
            var tmpAge = random.Next(MinAge, MaxAge);

            return new Person(tmpName, tmpSurname, tmpAge, tmpGender);
        }

        /// <summary>
        /// Check language of the string.
        /// </summary>
        /// <param name="name">String.</param>
        private static Language CheckStringLanguage(string name)
        {
            var latinSymbols = new Regex
                (@"^[A-z]+(-[A-z])?[A-z]*$");
            var cyrillicSymbols = new Regex
                (@"^[А-я]+(-[А-я])?[А-я]*$");

            if (string.IsNullOrEmpty(name) == false)
            {
                if (latinSymbols.IsMatch(name))
                {
                    return Language.English;
                }
                else if (cyrillicSymbols.IsMatch(name))
                {
                    return Language.Russian;
                }
                else
                {
                    throw new ArgumentException("Incorrect input." +
                        " Please, try again!");
                }
            }

            return Language.Unknown;
        }
    }
}
