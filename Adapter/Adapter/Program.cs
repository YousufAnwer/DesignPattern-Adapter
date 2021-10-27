using Adapter.Apis;
using Adapter.Const;
using Adapter.Services;
using Adapter.Sources;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSourceAdapter fileSourceAdapter = new FileSourceAdapter(SystemConstants.FilePath, new FileSource());
            ApiSourceAdapter apiSourceAdapter = new ApiSourceAdapter(new ApiSource());


            CharacterService obj = new CharacterService(fileSourceAdapter);
            obj.ListCharacters();
        }
    }
}
