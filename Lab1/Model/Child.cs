using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Child : PersonBase
    {
        /// <summary>
        /// A child's farther.
        /// </summary>
        private Adult _father;

        /// <summary>
        /// A child's mother.
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// A child's place pf study.
        /// </summary>
        private string _school;

        /// <summary>
        /// Maximum age of a child.
        /// </summary>
        private const int ChildMaxAge = 16;

        /// <summary>
        /// Enter the information about child's father.
        /// </summary>
        public Adult Father
        {
            get => _father;
            set
            {
                _father = value;
            }
        }

        /// <summary>
        /// Enter the information about child's mother.
        /// </summary>
        public Adult Mother
        {
            get => _mother;
            set
            {
                _mother = value;
            }
        }

        /// <summary>
        /// Enter the information about child's school.
        /// </summary>
        public string School
        {
            get => _school;
            set
            {
                _school = value;
            }
        }

        /// <summary>
        /// Create an instance of class Child.
        /// </summary>
        /// <param name="name">Name of the person.</param>
        /// <param name="surname">Surname of the person.</param>
        /// <param name="age">Age of the person.</param>
        /// <param name="gender">Gender of the person.</param>
        /// <param name="father">Child's father.</param>
        /// <param name="mother">Child's mother</param>
        /// <param name="school">Child's school.</param>
        public Child(string name, string surname, int age,
            Gender gender, Adult father, Adult mother,
            string school) : base(name, surname, age, gender)
        {
            Father = father;
            Mother = mother;
            School = school;
        }

        /// <summary>
        /// Create an instance of class Child without parameters.
        /// </summary>
        public Child() : this("Unknown", "Unknown", 11,
            Gender.Male, null, null, null)
        { }
    }
}
