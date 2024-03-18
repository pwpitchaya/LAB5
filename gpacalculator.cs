using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    internal class Gpacalculator
    {
        private List<Student> _students =
            new List<Student>();
        double sum;
        public void setStudent(Student student)
        {
            this._students.Add(student);
        }
        public double sumgpa()
        {
            sum = 0;
            foreach (Student student in _students)
            {
                sum += student.getGpa();
            }
            return sum;
                


        }
        public  double getGPAX()
        {
            
            double sum = (sumgpa() * 3) / (3*this._students.Count);
            return sum;

        }
        public double GetHighScore()
        {
            double High = 0;
            foreach (Student student in _students)
            {
                if (student.getGpa() > High)
                {
                    High = student.getGpa();
                }
            }
            return High;
        }

        public double GetLowScore()
        {
            double Low = this.GetHighScore();
            foreach (Student student in _students)
            {
                if (student.getGpa() < Low)
                {
                    Low = student.getGpa();
                }
            }
            return Low;
        }
        public double avScore()
        {
            double avScore;
            
            avScore = this.sumgpa() / this._students.Count();
            return avScore;
        }
    }
}
