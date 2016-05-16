using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Mystery
    {
        public string Name { get; set; }
        public bool Greater { get; set; }
        public string Description { get; set; }

        public Mystery(string name, int greater, string desc)
        {
            Name = name;
            Greater = Convert.ToBoolean(greater);
            Description = desc;
        }
    }
}
