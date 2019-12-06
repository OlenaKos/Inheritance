using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Expert: document saved in new format");
        }
        public ExpertDocumentWorker(int key) : base (key)
        {
        }
    }
}
