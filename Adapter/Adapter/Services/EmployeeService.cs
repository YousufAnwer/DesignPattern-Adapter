using Adapter.Apis;
using Adapter.Const;
using Adapter.Data;
using Adapter.Helpers;
using Adapter.IAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
   

    public class EmployeeService
    {
        private readonly ISourceAdapter _characterServiceAdapter;

        /// <summary>
        /// This is the adapter 
        /// by this constructer we can use get data from both sources either it is File or any api
        /// </summary>
        /// <param name="characterServiceAdapter"></param>
        public EmployeeService(ISourceAdapter characterServiceAdapter)
        {
            _characterServiceAdapter = characterServiceAdapter;
        }
        public void ListEmployees()
        {
            var people = _characterServiceAdapter.GetCharacter();

            foreach (var item in people)
            {
                Console.WriteLine("NAME: {0} FATHER_NAME: {1}", item.Name, item.FatherName);

            }
        }


    }
}
