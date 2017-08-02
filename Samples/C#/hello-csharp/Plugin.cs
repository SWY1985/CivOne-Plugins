using System;
using CivOne.Interfaces;

namespace CivOne
{
    public class Plugin : IPlugin
    {
        public string Name => "Hello C#!";

        public string Author => "SWY1985";

        public string Version => "0.1.0";
    }
}