using Adapter.Services;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterService starWarCharacterDisplayService = new CharacterService();
            starWarCharacterDisplayService.ListCharacters(CharacterSource.file);
        }
    }
}
