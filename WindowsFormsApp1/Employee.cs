using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Employee
    {
        public int empid { get; set; }
        public string empname { get; set; }

        public string empdept { get; set; }
    }
}
