using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Asset
    {
        public enum Culture { all, decadent, degenerate, restricted }
        private Culture _cultureLeve = Culture.all;

        public string Name { get; set; }
        public bool Good { get; set; }
        public bool Poor { get; set; }
        public Culture CultureLevel { get { return _cultureLeve; } set { _cultureLeve = value; } }
        public string Description { get; set; }

        public Asset(string name, int good, int poor, int cLevel, string desc)
        {
            Name = name;
            Good = Convert.ToBoolean(good);
            Poor = Convert.ToBoolean(poor);
            CultureLevel = (Culture)cLevel;
            Description = desc;
        }
    }
}
