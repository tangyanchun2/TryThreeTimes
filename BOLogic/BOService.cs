using BOInterfaces;
using BOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLogic
{
    public class BOService : IBORepository
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void Save(BO bo)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    if (bo.MakeItTrue)
                    {
                        Console.WriteLine("successfully Saved BO");
                        break;
                    }else
                    {
                        throw new Exception("got error");
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("save failed try again");
                    count += 1;
                    if(count >=3)
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}
