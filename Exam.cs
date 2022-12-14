using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Exam: IComparable<Exam>, IComparer<Exam>
    {
        public string Name { get; set; } // свойство отвечающее за назвние экзамена
        public int Mark { get; set; } // свойство отвечающее за оценку
        public System.DateTime Date { get; set; } // свойство отвечающее за дату экзамена

        public Exam(string Name, int Mark, System.DateTime Date) // конструктор с параметрами
        {
            this.Name = Name;
            this.Mark = Mark;
            this.Date = Date;
        }

        public Exam() // конструктор по умолчанию
        {
            this.Name = "none";
            this.Mark = 0;
            this.Date = new DateTime(1, 1, 1);
        }

        public override string ToString() // переобределение метода ToString - вывод всей информации 
        {
            string[] values = new string[] { Name,Mark.ToString(),Date.ToString()};
            string info = string.Join(" ", values);
            return info;
        }

        public int CompareTo(Exam? other)
        {
            if (this.Name.CompareTo(other.Name) < 0)
            {
                return -1;
            }
            else if (this.Name.CompareTo(other.Name) > 0)
            {
                return 1;
            }
            return 0;
            
        }

        public int Compare(Exam? x, Exam? y)
        {
            if (x.Mark < y.Mark)
            {
                return -1;
            }
            else if (x.Mark > y.Mark)
            {
                return 1;
            }
            return 0;
        }
    }
}
