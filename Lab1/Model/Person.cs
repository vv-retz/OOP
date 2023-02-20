namespace Model
{
    public class Person
    {
        private string _name;

        private string _surname;

        private int _age;

        private Gender _gender;

        public Person(string name, string surname, int age, Gender gender)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _gender = gender;

        }
    }
}
