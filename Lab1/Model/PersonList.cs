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

        /// <summary>
        /// Method that check input index for valid.
        /// </summary>
        /// <param name="index">Input index.</param>
        /// <exception cref="IndexOutOfRangeException">Index is out
        /// of the bounds.</exception>
        private void IsIndexInArray(int index)
        {
            if (index < 0 || index >= _arrayOfPersons.Length)
            {
                throw new IndexOutOfRangeException
                    ("Index is out of the bounds.");
            }
        }

        /// <summary>
        /// Method that delete person by input index.
        /// </summary>
        /// <param name="index">Input index.</param>
        public void DeletePersonByIndex(int index)
        {
            IsIndexInArray(index);

            for (int i = index; i < _arrayOfPersons.Length - 1; i++)
            {
                _arrayOfPersons[i] = _arrayOfPersons[i + 1];
            }

            Array.Resize(ref _arrayOfPersons, _arrayOfPersons.Length - 1);
        }

        //TODO: its maybe need to add try catch for the case unknown person
        /// <summary>
        /// Method that delete person.
        /// </summary>
        /// <param name="person">The person being deleted.</param>
        public void DeletePerson(Person person)
        {
            int index = Array.IndexOf(_arrayOfPersons, person);
            DeletePersonByIndex(index);
        }
    }
}
