using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_task4_23
{
    class Student
    {
        private string surname;
        private double score;
        private int studyYear;

        public Student(string studSurname, double studScore, int studStudyYear)
        {
            surname = studSurname;
            score = studScore;
            studyYear = studStudyYear;
            
        }

        virtual public double DefineQuality()
        {
            return 0.2*score*studyYear;
        }

        public string GetInfo() 
        {
            return surname + ": средний балл " + score.ToString() + ", год обучения " + studyYear.ToString();
        }

    }
}
