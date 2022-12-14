using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Person: IDateAndCopy
    {
        protected string name;
        protected string surname;
        protected System.DateTime birthDate;
        public string Name // свойство для доступа к полю name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Surname 
        { get { return this.surname; } 
          set { this.surname = value; }
        } // свойство для доступа к полю surname

        public DateTime Date 
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        } // свойство для доступа к полю birthdate

        public Person(string name, string surname, System.DateTime Birthdate) // конструктор с параметрами
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = Birthdate;
        }

        public Person() // конструктор по умолчанию
        {
            this.name = "none";
            this.surname = "none";
            this.birthDate = new DateTime(1, 1, 1);
        }
        public int Birth_Year // свойство для изменения года рождения в поле birthdate
        {
            get
            {
                return birthDate.Year;
            }
            set
            {
                birthDate.AddYears(value - birthDate.Year);
            }
        }

        public override string ToString() // переопределение метода ToString - вывод всей информации
        {
            string[] values = new string[] { name, surname, birthDate.ToString()};
            string info = string.Join(" ", values);
            return info;
        }

        public virtual string ToShortString() // вывод только имени и фамилии
        {
            string[] values = new string[] { name, surname};
            string full_name = string.Join(" ", values);
            return full_name;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null && this.birthDate == other.birthDate
                && this.name == other.name && this.surname == other.surname;
        }

        public static bool operator ==(Person left, Person right)
        {
            if (ReferenceEquals(left, right)) return true;
            return left.Equals(right);
        }

        public static bool operator!=(Person left, Person right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() ^ surname.GetHashCode() ^ birthDate.GetHashCode();
        }

        public virtual object DeepCopy()
        {
            return new Person(name, surname, birthDate);
        }

    }
}
