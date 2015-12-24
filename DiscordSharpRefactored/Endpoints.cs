﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordSharpRefactored
{
    /// <summary>
    /// The class that contains the end points needed by DiscordSharp.
    /// </summary>
    public static class Endpoints
    {
        public static string BaseAPI = "https://discordapp.com/api";
        public static string Gateway = "/gateway";
        public static string Auth = "/auth";
        public static string Login = "/login";
    }
}