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
        /// Enter the name of person.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            private set
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

            private set
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

            private set
            {
                _age = value;
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

            private set
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
        public Person(string name, string surname, int age, Gender gender)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _gender = gender;

        }
    }
}
