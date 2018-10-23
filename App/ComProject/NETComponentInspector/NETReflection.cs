using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETComponentInspector
{
    public interface NETReflection
    {
        List<String> getClasses(string componentPath);
        List<String> getInterfaces(string componentPath);
    }
}
