using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask4
{
    enum WorkerType {Base, Pro, Expert}

    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker docWorker = CreateWorker();
            docWorker.Show();
            Console.ReadLine();          
        }

        private static DocumentWorker CreateWorker()
        {
            DocumentWorker docWorker;
            WorkerType worker = DefineWorker();
            int Key = 0;
            if (worker != WorkerType.Base)
            {
               Key = DefineKey();
            }
          
            if ((worker == WorkerType.Pro) && (Key != 0))           // Pro worker with defined key
            {
                docWorker = new ProDocumentWorker(Key);
            }
            else if ((worker == WorkerType.Expert)  && (Key != 0))  // Expert worker with defined key
            {
                docWorker = new ExpertDocumentWorker(Key);
            }
            else 
            {
                docWorker = new DocumentWorker();                   // Base worker definition
            }  
            return docWorker;
        }

        private static int DefineKey()
        {
            int key;
            Console.WriteLine("Please enter a pro or expert key, if 0 = no key");
            bool success = Int32.TryParse(Console.ReadLine(), out key);
            if (success)
            {
                if (key != 0)
                {
                    Console.WriteLine("Key set");
                }
            }
            else
            {
                Console.WriteLine("Key hasn't been set");
                key = 0;
            }

            return key;
        }

        private static WorkerType DefineWorker()
        {
            WorkerType workerType = WorkerType.Base ;
            Console.WriteLine("Please enter a desired DocumentWorker type: 0 - base, 1 - pro, 2 - expert");

            int workerMark;
            bool success = Int32.TryParse(Console.ReadLine(), out workerMark);
            if (success)
            {
                switch (workerMark)
                {
                    case 0:
                        {
                            Console.WriteLine("Basic has been chosen");
                            workerType = WorkerType.Base;
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Pro has been chosen");
                            workerType = WorkerType.Pro;
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Expert has been chosen");
                            workerType = WorkerType.Expert;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Couldn't define workerType. Basic has been chosen");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Couldn't define workerType. Basic has been chosen");
                workerType = WorkerType.Base;
            }
            return workerType;

        }
    }
}
