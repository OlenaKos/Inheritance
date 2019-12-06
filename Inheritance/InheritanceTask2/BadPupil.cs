using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil is studied");
        }
        public override void Read()
        {
            Console.WriteLine("Bad Pupil is reading");
        }
        public override void Write()
        {
            Console.WriteLine("Bad Pupil is writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad Pupil is relaxing");
        }

    }
}
