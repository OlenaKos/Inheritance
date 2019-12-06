using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask2
{
    class ClassRoom
    {
        public List<Pupil> Pupils { set; get; }
        public ClassRoom(Pupil first, Pupil second)
        {
            List<Pupil> pupils = new List<Pupil>();
            pupils.Add(first);
            pupils.Add(second);
            pupils.Add(new GoodPupil());
            pupils.Add(new GoodPupil());

            Pupils = pupils;

        }
        public ClassRoom(Pupil first, Pupil second, Pupil third)
        {
            List<Pupil> pupils = new List<Pupil>();
            pupils.Add(first);
            pupils.Add(second);
            pupils.Add(third);
            pupils.Add(new GoodPupil());

            Pupils = pupils;

        }
        public ClassRoom(Pupil first, Pupil second, Pupil third, Pupil fourth)
        {
            List<Pupil> pupils = new List<Pupil>();
            pupils.Add(first);
            pupils.Add(second);
            pupils.Add(third);
            pupils.Add(fourth);

            Pupils = pupils;

        }

        public void Show()
        {
            foreach (var pup in Pupils)
            {
                pup.Study();
                pup.Read();
                pup.Write();
                pup.Relax();
            }
        }
    }
}
