using BOInterfaces;
using BOLogic;
using BOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSaveBO
{
    class Program
    {
        static void Main(string[] args)
        {
            IBORepository repo = new BOService();
            Console.WriteLine("demo save success start");
            BO SavedItem1 = new BO { MakeItTrue = true };
            repo.Save(SavedItem1);
            Console.WriteLine("demo save success end");

            Console.WriteLine("demo save fail start");
            BO SavedItem2 = new BO { MakeItTrue = false };
            repo.Save(SavedItem2);
            Console.WriteLine("demo save fail end");

            Console.ReadLine();
        }
    }
}
