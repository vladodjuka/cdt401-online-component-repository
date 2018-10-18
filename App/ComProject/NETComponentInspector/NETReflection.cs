using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETComponentInspector
{
    public interface NETReflection
    {
        List<String> getClasses(String componentPath);
        List<String> getInterfaces(String componentPath);
    }
}
