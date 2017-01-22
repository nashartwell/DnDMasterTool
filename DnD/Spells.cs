﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DnD
{
    [Serializable]
    public class Spell
    {
        public string name { get; set; }
        public string desc { get; set; }
        public string page { get; set; }
        public string range { get; set; }
        public string components { get; set; }
        public string material { get; set; }
        public string ritual { get; set; }
        public string duration { get; set; }
        public string concentration { get; set; }
        public string casting_time { get; set; }
        public string level { get; set; }
        public string school { get; set; }
        public string @class { get; set; }
        public string higher_level { get; set; }
        public string archetype { get; set; }
        public string domains { get; set; }
        public string oaths { get; set; }
        public string circles { get; set; }
        public string patrons { get; set; }
    }

    public class RootObject
    {
        public List<Spell> Spells { get; set; }
    }
}
