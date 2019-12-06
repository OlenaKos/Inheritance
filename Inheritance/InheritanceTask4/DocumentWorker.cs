using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace InheritanceTask4
{
    class DocumentWorker
    {

        public virtual void OpenDocument()
        {
            Console.WriteLine("Doc is opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Edit of document allowed in pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Document save is allowed in pro version");
        }

        public void Show()
        {
            Console.WriteLine("*********  Start printing methods **********");
            MethodInfo[] methods = this.GetType().GetMethods();
            foreach (var method in methods)
            {
                if (method.Name.EndsWith("Document"))
                {
                    Console.WriteLine("Method name is " + method.Name);
                    method.Invoke(this, null);
                    Console.WriteLine();
                }
            }
        }
    }
}
