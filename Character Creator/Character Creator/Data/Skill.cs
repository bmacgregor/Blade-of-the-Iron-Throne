using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Data
{
    class Skill
    {
        public enum Attribute { brawn, daring, tenacity, heart, sagacity, cunning }
        private Attribute _attr = Attribute.brawn;

        public string Name { get; set; }
        public Attribute Attr { get { return _attr; } set { _attr = value; } }
        public string Description { get; set; }

        public Skill(string name, int attribute, string desc)
        {
            Name = name;
            Attr = (Attribute)attribute;
            Description = desc;
        }
    }
}
