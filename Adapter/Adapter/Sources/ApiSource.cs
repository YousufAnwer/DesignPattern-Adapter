using Adapter.Const;
using Adapter.Data;
using Adapter.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Apis
{
    /// <summary>
    /// This is dummy Api  source
    /// TODO:Implement real api 
    /// </summary>
    public class ApiSource
    {
        List<Employee> employees = new List<Employee>();
        public ApiSource()
        {
            if (employees.Count == 0)
            {
                employees.Add(new Employee() { Name = "Sana", FatherName = "Javaid" });
                employees.Add(new Employee() { Name = "Sara", FatherName = "waheed" });
                employees.Add(new Employee() { Name = "sania", FatherName = "kareem" });
            }

        }

        public List<Employee> GetEmployeesFromApi()
        {
            Console.WriteLine("From Api");
            return employees;
        }
    }
}
