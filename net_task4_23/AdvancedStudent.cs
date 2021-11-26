using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_task4_23
{
    class AdvancedStudent : Student
    {
        bool isStudyEnglishSubjects;
        public AdvancedStudent(string studSurname, double studScore, int studStudyYear, bool isStudStudyEnglishSubjects)
            : base(studSurname, studScore, studStudyYear)
        {
            isStudyEnglishSubjects = isStudStudyEnglishSubjects;
        }

        public override double DefineQuality()
        {
            if (isStudyEnglishSubjects) return 2 * base.DefineQuality();
            return 0.9 * base.DefineQuality();

        }
    }
}
