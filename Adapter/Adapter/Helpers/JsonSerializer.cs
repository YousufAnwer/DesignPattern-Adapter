using Adapter.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Adapter.Helpers
{
    public class JsonSerializer
    {
        public List<Employee> GetPersonFromJsonString(string policyJson)
        {
            var obj = JsonConvert.DeserializeObject<List<Employee>>(policyJson);
            return obj;

        }
    }
}
