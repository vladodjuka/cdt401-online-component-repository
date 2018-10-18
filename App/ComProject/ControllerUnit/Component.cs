using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerUnit
{
   public class Component
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string type { get; set; }
        public string path { get; set; }

        public override string ToString()
        {
            return name;
        }

    }
}
