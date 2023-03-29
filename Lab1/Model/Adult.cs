using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Class which describes a certain adult.
    /// </summary>
    internal class Adult : PersonBase
    {
        /// <summary>
        /// Number of adult's passport.
        /// </summary>
        private int _passportNumber;

        /// <summary>
        /// Adult's employer.
        /// </summary>
        private string _employer;

        /// <summary>
        /// Husband or wife.
        /// </summary>
        private Adult _spouse;

        /// <summary>
        /// Minimum age of an adult.
        /// </summary>
        private const int AdultMinAge = 17;

        /// <summary>
        /// Low bound of passport number range.
        /// </summary>
        private const int PassportLowBound = 100000;

        /// <summary>
        /// High bound of passport number range.
        /// </summary>
        private const int PassportHighBound = 999999;

        /// <summary>
        /// Enter the adult's passport number.
        /// </summary>
        public int PassportNumber
        {
            get => _passportNumber;
            set
            {
                _passportNumber = value;
            }
        }

        /// <summary>
        /// Enter the adult's employer.
        /// </summary>
        public string Employer
        {
            get => _employer;
            set
            {
                _employer = value;
            }
        }

        /// <summary>
        /// Enter the adult's spouse.
        /// </summary>
        public Adult Spouse
        {
            get => _spouse;
            set
            {
                _spouse = value;
            }
        }

        /// <summary>
        /// Create an instance of class Adult.
        /// </summary>
        /// <param name="name">Name of the person.</param>
        /// <param name="surname">Surname of the person.</param>
        /// <param name="age">Age of the person.</param>
        /// <param name="gender">Gender of the person.</param>
        /// <param name="passportNumber">Adult's passport number.</param>
        /// <param name="spouse">Adult's spouse.</param>
        /// <param name="employer">Adult's employer.</param>
        public Adult(string name, string surname, int age,
            Gender gender, int passportNumber, Adult spouse,
            string employer) : base(name, surname, age, gender)
        {
            PassportNumber = passportNumber;
            Employer = employer;
            Spouse = spouse;
        }

        /// <summary>
        /// Create an instance of class Adult without parameters.
        /// </summary>
        public Adult() : this("Unknown", "Unknown", 17,
            Gender.Male, 100000, null, null)
        { }

        /// <summary>
        /// Converts class field values to string format.
        /// </summary>
        /// <returns>Information about adult.</returns>
        public override string GetInfo()
        {
            var marrigaeStatus = "Not married";
            if (Spouse != null)
            {
                marrigaeStatus = $"Married to:" +
                    $" {Spouse.GetPersonNameSurname()}";
            }

            var employerStatus = "Unemployed";
            if (!string.IsNullOrEmpty(Employer))
            {
                employerStatus = $"Current job: {Employer}";
            }

            return $"{GetPersonInfo()};\n " +
                $"Passport number: {PassportNumber};" +
                $" {marrigaeStatus}; {employerStatus}\n ";
        }

        /// <summary>
        /// Check adult's age.
        /// </summary>
        /// <param name="age">Adult's age.</param>
        /// <exception cref="IndexOutOfRangeException">Age must be in a
        /// certain range.</exception>
        protected override void CheckAge(int age)
        {
            if (age is < AdultMinAge or > MaxAge)
            {
                throw new IndexOutOfRangeException($"Adult age value must" +
                    $" be in range [{AdultMinAge}...{MaxAge}].");
            }
        }
    }
}
