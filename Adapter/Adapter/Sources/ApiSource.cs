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
    public class ApiSource
    {
        public List<Person> GetPeopleFromApi()
        {
            Console.WriteLine("From Api");
            LoadPeopleFromJson loadPeopleFromJson = new LoadPeopleFromJson();
            var obj = loadPeopleFromJson.LoadJson(SystemConstants.FilePath);

            JsonSerializer jsonSerializer = new JsonSerializer();
            var people = jsonSerializer.GetPersonFromJsonString(obj);
            return people;
        }
    }
}
