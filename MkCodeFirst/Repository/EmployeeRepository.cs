using MkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace MkCodeFirst.Repository
{
    public class EmployeeRepository : Repository<Emloyee>, IEmployeeRepository
    {
        public  EmployeeRepository(EmployeeContext _entities) : base(_entities)
        {
        }

        public  void DoSomething(int id)
        {
            Emloyee k = this.entities.Employees.Find(id);
                
            this.entities.Employees.Remove(k);


           
        }
    }
}