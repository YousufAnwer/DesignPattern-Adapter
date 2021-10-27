using Adapter.Apis;
using Adapter.Data;
using Adapter.IAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
   
    public class ApiSourceAdapter : ISourceAdapter
    {
        private readonly ApiSource _api;

        public ApiSourceAdapter(ApiSource api)
        {
            _api = api;
        }

        public IEnumerable<Employee> GetCharacter()
        {
            return _api.GetEmployeesFromApi();
        }
    }
}
