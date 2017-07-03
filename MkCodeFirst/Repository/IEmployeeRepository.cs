using MkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
namespace MkCodeFirst.Repository
{
   public interface IEmployeeRepository :IRepository<Emloyee>
    {


      void  DoSomething(int obj);
       
    }
}
