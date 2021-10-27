using Adapter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.IServices
{
    public interface ISourceAdapter
    {
        IEnumerable<Person> GetCharacter();
    }
}
