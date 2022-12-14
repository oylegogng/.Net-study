using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class ExamExtension : IComparer<Exam>
    {
        public int Compare(Exam? x, Exam? y)
        {
            if(x.Date.CompareTo(y.Date) < 0)
            {
                return -1;
            }
            else if (x.Date.CompareTo(y.Date) > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
