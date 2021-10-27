using Adapter.Const;
using Adapter.Data;
using Adapter.Helpers;
using Adapter.IServices;
using Adapter.Sources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
    public class FileSourceAdapter : ISourceAdapter
    {
        private readonly FileSource _fileSource;
        private string _filePath;
        public FileSourceAdapter(string filePath, FileSource fileSource)
        {
            _filePath = filePath;
            _fileSource = fileSource;
        }
        public IEnumerable<Person> GetCharacter()
        {
            var list = _fileSource.GetFromFile(_filePath);
            return list;
        }
    }
}
