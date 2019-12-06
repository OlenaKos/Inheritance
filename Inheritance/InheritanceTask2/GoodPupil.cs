using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil is studied");
        }
        public override void Read()
        {
            Console.WriteLine("Good Pupil is reading");
        }
        public override void Write()
        {
            Console.WriteLine("Good Pupil is writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Good Pupil is relaxing");
        }
    }
}
