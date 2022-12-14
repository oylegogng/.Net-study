using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Test
    {
        public string name { get; set; }
        public bool pass { get; set; }

        public Test()
        {
            name = "none";
            pass = true;
        }
        public Test(string name, bool pass)
        {
            this.name = name;
            this.pass = pass;
        }

        public override string ToString()
        {
            string[] values = new string[] { name, pass.ToString() };
            string info = string.Join(" ", values);
            return info;
        }
    }
}
