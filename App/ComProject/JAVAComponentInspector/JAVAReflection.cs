using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAVAComponentInspector
{
    public interface JAVAReflection
    {
        List<string> getClasses(string componentPath);
        List<string> getInterfaces(string componentPath);
    }
}
