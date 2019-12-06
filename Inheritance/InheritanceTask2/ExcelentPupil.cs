using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent Pupil is studied");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent Pupil is reading");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent Pupil is writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent Pupil is relaxing");
        }
    }
}
