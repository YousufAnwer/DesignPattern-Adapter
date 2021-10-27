using Adapter.Const;
using Adapter.Data;
using Adapter.Helpers;
using Adapter.IAdapter;
using Adapter.Sources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
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
        public IEnumerable<Employee> GetCharacter()
        {
            var list = _fileSource.GetFromFile(_filePath);
            return list;
        }
    }
}
