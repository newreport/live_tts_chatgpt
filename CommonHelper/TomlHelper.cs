﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonHelper
{
    public static class TomlHelper
    {
        public static Tomlyn.Model.TomlTable? ToModel(string str)
        {
            return Toml.ToModel(str);
        }
    }
}
