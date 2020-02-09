using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formularz
{
    public class Person
    {
        private string name;
        private string surname;
        private string dateOfBirth; 
        private string height;
        private string position;
        private bool isMale;
        private int salary;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public string Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public bool IsMale
        {
            get
            {
                return isMale;
            }

            set
            {
                isMale = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public Person(string name, string surname, string dateOfBirth, string height, string position, bool isMale, int salary)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.height = height;
            this.position = position;
            this.isMale = isMale;
            this.salary = salary;
        }

        /*
        public Person(string name, string surname, string dateOfBirth, string height, string position, bool isMale)
        {

            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
            this.Height = height;
            this.Position = position;
            this.IsMale = isMale;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Height { get => height; set => height = value; }
        public string Position { get => position; set => position = value; }
        public bool IsMale { get => isMale; set => isMale = value; }
        */
    }
}
