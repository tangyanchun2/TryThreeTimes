using BOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOInterfaces
{
    public interface IBORepository:IDisposable
    {
        void Save(BO bo);
    }
}
