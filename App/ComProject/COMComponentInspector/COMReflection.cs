using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMComponentInspector
{
    public interface COMReflection
    {
        List<string> getClasses(string componentPath);
        List<string> getInterfaces(string componentPath);
    }
}
