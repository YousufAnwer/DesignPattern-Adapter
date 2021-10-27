using Adapter.Apis;
using Adapter.Const;
using Adapter.Data;
using Adapter.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
    public enum CharacterSource
    {
        file,
        api
    }

    public class CharacterService
    {

        public void ListCharacters(CharacterSource source)
        {
            List<Person> people = null;
            if (source == CharacterSource.file)
            {
                Console.WriteLine("From File");
                people = new List<Person>();

                LoadPeopleFromJson loadPeopleFromJson = new LoadPeopleFromJson();
                var obj = loadPeopleFromJson.LoadJson(SystemConstants.FilePath);

                JsonSerializer jsonSerializer = new JsonSerializer();
                people = jsonSerializer.GetPersonFromJsonString(obj);
            }
            else if (source == CharacterSource.api)
            {
                Console.WriteLine("From Api");
                people = new List<Person>();
                people = DummyPeopleApi.GetPeopleFromApi();

            }


            foreach (var item in people)
            {
                Console.WriteLine("{0}-{1}", item.Name, item.HairColor);

            }
        }


    }
}
