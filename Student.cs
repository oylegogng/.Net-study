using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Student
    {
        private Person person; 
        private Education education; // степень образования
        private int number; // номер группы
        private Exam[] exams; // массив экзаменов

        

        public Person Person 
        {
            get { return person; }
            set { person = value; }
        } // свойство для досутпа к person
        public Education Education 
        { 
            get { return education; }
            set { education = value; }
        } // свойство для досутпа к education
        public int Number 
        { 
            get { return number; }
            set { number = value; }
        } // свойство для досутпа к number
        public Exam[] Exams 
        { 
            get { return exams; }
            set { exams = value; }
        } // свойство для досутпа к exams

        public Student(Person person, Education education, int number) // конструктор с параметрами
        {
            this.person.Name = person.Name;
            this.person.Surname = person.Surname;
            this.person.Date = person.Date;
            this.education = education;
            this.number = number;
        }
        public Student() // конструктор по умолчанию
        {
            this.person = new Person();
            this.education = 0;
            this.number = 0;
            this.exams = new Exam[3];
        }
        public double avg_mark // свойство для подсчета средней оценки 
        {
            get
            {
                if (exams != null || exams.Length == 0)
                {
                    double AVG_MARK = 0;
                    foreach (Exam exam in exams)
                    {
                        if (exam != null)
                        {
                            AVG_MARK += exam.Mark;
                        }
                    }

                    return AVG_MARK / exams.Length;
                }
                else { return 0; };
            }
        }

        public bool this[Education EDUCATION] // индексатор для проверки степени образования
        {
            get
            {
                return education == EDUCATION;
            }
        }

        public void AddExams(params Exam[] EXAMS) // // свойство для добавления экзамена в массив экзаменов
        {
            Exam[] result = new Exam[exams.Length + EXAMS.Length];

            exams.CopyTo(result, 0);
            for(int i = 0; i < EXAMS.Length; i++)
            {
                result[exams.Length + i] = EXAMS[i];
            }

            exams = result;
        }

        public override string ToString() // переопределение метода ToString - вывод всей информации
        {
            string[] values = new string[] { person.ToString(), education.ToString(), number.ToString() };
            string info = string.Join(" ", values);

            foreach (Exam exam in exams)
            {
                if (exam != null)
                {
                    info += exam;
                    info += " ";
                }
            }

            return info;
        }

        public virtual string ToShortString() // вывод всей информации, кроме экзаменов
        {
            string[] values = new string[] { person.ToString(), education.ToString(), number.ToString(), avg_mark.ToString() };
            string info = string.Join(" ", values);
            return info;
        }
    }
}
