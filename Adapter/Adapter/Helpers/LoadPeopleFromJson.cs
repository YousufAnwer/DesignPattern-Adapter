﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Helpers
{
    public class LoadPeopleFromJson
    {
        public string LoadJson(string filepath)
        {
            string peolpe =  File.ReadAllText(filepath);
            return peolpe;
        }
    }
}
