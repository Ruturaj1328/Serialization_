using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Student
    {
        public int rollno { get; set; }
        public string Name { get; set; }

        public double Percentage { get; set; }
    }
}
