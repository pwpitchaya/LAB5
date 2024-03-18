using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    internal class Student
    {
        private string studentname;
        private double gpa;

        public Student(string name,double gpa)
        {
            this.studentname = name;
            this.gpa = gpa;
        }
        public double getGpa() {  return gpa; }
    }
}
