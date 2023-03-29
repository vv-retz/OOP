using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    /// <summary>
    /// Class which describe persons.
    /// </summary>
    public abstract class PersonBase
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
        protected const int MinAge = 0;

        /// <summary>
        /// Maximum age value.
        /// </summary>
        protected const int MaxAge = 150;

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
                _ = CheckStringLanguage(value);
                _name = EditRegister(value);

                if (_surname != null)
                {
                    CheckNameSurname();
                }
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
                _ = CheckStringLanguage(value);
                _surname = EditRegister(value);

                if (_name != null)
                {
                    CheckNameSurname();
                }
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
                if (value > MinAge && value < MaxAge)
                {
                    _age = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Age value must" +
                          $" be in range [{MinAge}:{MaxAge}].");
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
        /// PersonBase's constructor.
        /// </summary>
        /// <param name="name">Name of person.</param>
        /// <param name="surname">Surname of person.</param>
        /// <param name="age">Age of person.</param>
        /// <param name="gender">Gender of person.</param>
        public PersonBase
            (string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonBase"/> class.
        /// </summary>
        public PersonBase()
        { }

        /// <summary>
        /// Converts class field value to string format.
        /// </summary>
        /// <returns>Information about person.</returns>
        public string GetPersonInfo()
        {
            return $"{Name} {Surname}; Age - {Age}; Gender - {Gender}";
        }

        /// <summary>
        /// Converts certain class field values to string format.
        /// </summary>
        /// <returns>Person's name and surname.</returns>
        public string GetPersonNameSurname()
        {
            return $"{Name} {Surname}";
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

        /// <summary>
        /// Compare languages of the person's surname and name.
        /// </summary>
        /// <exception cref="FormatException">Only one
        /// language.</exception>
        private void CheckNameSurname()
        {
            if ((string.IsNullOrEmpty(Name) == false)
                && (string.IsNullOrEmpty(Surname) == false))
            {
                var nameLanguage = CheckStringLanguage(Name);
                var surnameLanguage = CheckStringLanguage(Surname);

                if (nameLanguage != surnameLanguage)
                {
                    throw new FormatException("Name and Surname must" +
                            " be only in one language.");
                }
            }
        }

        /// <summary>
        /// Case conversion: first letter capital, other capitals.
        /// </summary>
        /// <param name="word">Name or surname of the person.</param>
        /// <returns>Edited name or surname of the person.</returns>
        private static string EditRegister(string word)
        {
            return CultureInfo.CurrentCulture.TextInfo.
                ToTitleCase(word.ToLower());
        }

        /// <summary>
        /// Get the information about a person.
        /// </summary>
        /// <returns>Info about person.</returns>
        public abstract string GetInfo();

        /// <summary>
        /// Check person's age.
        /// </summary>
        /// <param name="age">Person's age.</param>
        protected abstract void CheckAge(int age);
    }
}
