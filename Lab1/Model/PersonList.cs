namespace Model
{
    /// <summary>
    /// Class which describe list of persons (as an array).
    /// </summary>
    internal class PersonList
    {
        /// <summary>
        /// Array of persons.
        /// </summary>
        private Person[] _arrayOfPersons = new Person[0];

        /// <summary>
        /// Function for add a person at the end of the array.
        /// </summary>
        /// <param name="person">The person being added.</param>
        public void AddPerson(Person person)
        {
            var indexOfNewPerson = _arrayOfPersons.Length;
            Array.Resize(ref _arrayOfPersons, indexOfNewPerson + 1);
            _arrayOfPersons[indexOfNewPerson] = person;
        }



    }
}
