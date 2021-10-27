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
    public static class DummyPeopleApi
    {
        public static List<Person> GetPeopleFromApi()
        {
            LoadPeopleFromJson loadPeopleFromJson = new LoadPeopleFromJson();
            var obj = loadPeopleFromJson.LoadJson(SystemConstants.FilePath);

            JsonSerializer jsonSerializer = new JsonSerializer();
            var people = jsonSerializer.GetPersonFromJsonString(obj);
            return people;
        }
    }
}
