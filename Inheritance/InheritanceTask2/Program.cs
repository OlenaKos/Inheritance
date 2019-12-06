using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodPupil pup1 = new GoodPupil();
            BadPupil pup2 = new BadPupil();
            ExcelentPupil pup3 = new ExcelentPupil();

            ClassRoom classRoom = new ClassRoom(pup1, pup2, pup3);

            classRoom.Show();

            Console.ReadLine();
        }
    }
}
