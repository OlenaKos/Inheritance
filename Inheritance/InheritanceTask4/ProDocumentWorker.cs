using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask4
{
    class ProDocumentWorker : DocumentWorker
    {
        int Key { get; set; }
        public override void EditDocument()
        {
            Console.WriteLine("PRO:Document edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("PRO:Document is saved in old format, saving in other formats allowed in Expert version ");
        }
        public ProDocumentWorker(int key)
        {
            Key = key;
        }
    }
}
