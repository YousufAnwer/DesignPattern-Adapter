using Adapter.Apis;
using Adapter.Data;
using Adapter.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
    public class ApiSourceAdapter : ISourceAdapter
    {
        private readonly ApiSource _api;

        public ApiSourceAdapter(ApiSource api)
        {
            _api = api;
        }

        public IEnumerable<Person> GetCharacter()
        {
            return _api.GetPeopleFromApi();
        }
    }
}
