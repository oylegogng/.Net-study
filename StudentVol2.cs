using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class StudentVol2: Person, IDateAndCopy
    {
        private Education education; // степень образования
        private int number; // номер группы
        
        private List<Test> testList;
        private List<Exam> examList;

        public StudentVol2(): base()
        {
            this.education = 0;
            this.number = 0;
            this.testList = new List<Test>();
            this.examList = new List<Exam>();
        }


        public StudentVol2(string name, string surname, System.DateTime Birthdate, 
            Education education, int number, List<Test> testList, List<Exam> examList ) : base(name, surname, Birthdate)
        {
            this.education = education;
            this.number = number;
            this.testList = testList;
            this.examList = examList;
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value <= 100 || value > 599)
                {
                    throw new Exception("Значение в промежутке от 101 до 599");
                }
                else { this.number = value; }
            }
        }
        public Person person
        {
            get
            {
                return new Person(base.name, base.surname, base.birthDate);
            }
            set
            {
                base.name = value.Name;
                base.surname = value.Surname;
                base.birthDate = value.Date;
            }
        }

        public double Avg_mark
        {
            get 
            {
                double total = 0;

                foreach(Exam exam in examList)
                {
                    if(exam!=null)
                    {
                        total += exam.Mark;
                    }
                }

                return total / examList.Count;
            }
        }
        
        public List<Test> TestList
        {
            get
            {
                return this.testList;
            }

            set
            {
                this.testList = value;
            }
        }

        public List<Exam> ExamList
        {
            get
            {
                return this.ExamList;
            }

            set
            {
                this.ExamList = value;
            }
        }
        
        public void AddExams(params Exam[] Exams)
        {
            foreach(Exam exam in Exams)
            {
                this.examList.Add(exam);
            }
        }

        public override string ToString()
        {
            string[] values = new string[] { base.name, base.surname, base.birthDate.ToString(), this.education.ToString(), 
                this.number.ToString()};
            string info = string.Join(" ", values);

            foreach(Exam exam in examList)
            {
                if(exam != null)
                {
                    info += " " + exam.Name.ToString();
                }
                
            }

            foreach (Test test in testList)
            {
                if(test != null)
                {
                    info += " " + test.name.ToString();
                }
                
            }
            return info;
        }
        public override string ToShortString()
        {
            string[] values = new string[] { base.name, base.surname, base.birthDate.ToString(), this.education.ToString(),
                this.number.ToString(), this.Avg_mark.ToString()};
            string info = string.Join(" ", values);
            return info;
        }
        public override object DeepCopy()
        {
            List<Test> new_testlist = new List<Test>();
            foreach(Test test in testList)
            {
                new_testlist.Add(new Test(test.name, test.pass));
            }



            List<Exam> new_examlist = new List<Exam>();
            foreach (Exam exam in examList)
            {
                new_examlist.Add(new Exam(exam.Name, exam.Mark, exam.Date));
            }
            

            return new StudentVol2(base.name, base.surname, base.birthDate, this.education, this.number, new_testlist, new_examlist);
        }
        
        public IEnumerable GetTests()
        {
            foreach(Test test in this.testList)
            {
                yield return test;
            }
        }
        public IEnumerable GetExams()
        {
            foreach (Exam exam in this.examList)
            {
                yield return exam;
            }
        }

        public IEnumerable GetExamsMore(int value)
        {
            foreach (Exam exam in this.examList)
            {
                if(exam.Mark > value) { yield return exam; }
            }
        }

        public void SortExamByName()
        {
            bool Flag = true;
            while (Flag)
            {

                Flag = false;
                for (int i = 0; i < this.examList.Count; i++)
                {
                    if (this.examList[i].CompareTo(examList[i + 1]) < 0)
                    {
                        Exam buf = this.examList[i];
                        this.examList[i] = this.examList[i + 1];
                        this.examList[i + 1] = buf;
                        Flag = true;
                    }
                }
            }
        }
        public void SortExamByMark()
        {
            bool Flag = true;
            while (Flag)
            {

                Flag = false;
                for (int i = 0; i < this.examList.Count; i++)
                {
                    if (this.examList[i].Compare(examList[i], examList[i + 1]) < 0)
                    {
                        Exam buf = this.examList[i];
                        this.examList[i] = this.examList[i + 1];
                        this.examList[i + 1] = buf;
                        Flag = true;
                    }
                }
            }
        }

        public void SortExamByDatek()
        {
            bool Flag = true;
            ExamExtension examExtension = new ExamExtension();
            while (Flag)
            {

                Flag = false;
                for (int i = 0; i < this.examList.Count; i++)
                {
                    if (examExtension.Compare(this.examList[i], this.examList[i+1]) < 0)
                    {
                        Exam buf = this.examList[i];
                        this.examList[i] = this.examList[i + 1];
                        this.examList[i + 1] = buf;
                        Flag = true;
                    }
                }
            }
        }
    }

}
