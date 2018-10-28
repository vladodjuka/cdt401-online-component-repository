using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerUnit
{
    public interface ComponentDbUser
    {
        List<Component> getComponents();
        List<Component> getComponentsByName(string name);
        
        List<string> reflectComponentClasses(Component component);
        List<string> reflectComponentInterfaces(Component component);
    }
}
