using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MkCodeFirst.Repository;
namespace MkCodeFirst.UnitofWork
{
  public interface IUnitofWork:IDisposable
    {

        
        void Save();


        
    }
}
