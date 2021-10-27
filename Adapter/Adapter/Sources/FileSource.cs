using Adapter.Data;
using Adapter.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sources
{
    public class FileSource
    {
        public List<Person> GetFromFile(string fielPath)
        {
            Console.WriteLine("From File");
            LoadPeopleFromJson loadPeopleFromJson = new LoadPeopleFromJson();
            var obj = loadPeopleFromJson.LoadJson(fielPath);

            JsonSerializer jsonSerializer = new JsonSerializer();
            var people = jsonSerializer.GetPersonFromJsonString(obj);
            return people;
        }
    }
}
