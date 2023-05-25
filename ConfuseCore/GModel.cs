﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfuseCore
{
    public static class GModel
    {
        public static ConfigModel Conf = ConfigModel.RefreshConfig();
        public static List<string> SensitiveWords { get; internal set; }
        public static List<string> SensitiveWordsPY { get; internal set; }


        public static void Refresh(this ConfigModel value)
        {
            value = ConfigModel.RefreshConfig();
        }

        public static bool IsDev => Conf.Env == "dev";
    }
}
