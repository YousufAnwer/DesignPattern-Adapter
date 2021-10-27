using Adapter.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Adapter.Helpers
{
    public class JsonSerializer
    {
        public List<Person> GetPersonFromJsonString(string policyJson)
        {
            var obj = JsonConvert.DeserializeObject<List<Person>>(policyJson);
            return obj;

        }
    }
}
