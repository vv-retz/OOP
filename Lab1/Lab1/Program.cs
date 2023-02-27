using Model;

namespace Lab1
{
    /// <summary>
    /// Class Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Class Main.
        /// </summary>
        static void Main(string[] args)
        {
            // Create two lists
            var olds = new PersonList();
            var youth = new PersonList();

            // Create 6 people to fill the lists
            var ivanov = new Person
                ("Ivan", "Ivanov", 50, Gender.Male);
            var petrov = new Person
                ("Petr", "Petrov", 45, Gender.Male);
            var sidorov = new Person
                ("Sidor", "Sidorov", 40, Gender.Male);

            var rets1 = new Person
                ("Vladislav", "Rets", 12, Gender.Male);
            var rets2 = new Person
                ("Alexander", "Rets", 11, Gender.Male);
            var rets3 = new Person
                ("Vladimir", "Rets", 10, Gender.Male);

            // Add people to the lists
            olds.AddPerson(ivanov);
            olds.AddPerson(petrov);
            olds.AddPerson(sidorov);

            youth.AddPerson(rets1);
            youth.AddPerson(rets2);
            youth.AddPerson(rets3);


        }
    }
}
