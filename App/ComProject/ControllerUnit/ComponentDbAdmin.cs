using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerUnit
{
    public interface ComponentDbAdmin
    {
        List<Component> getComponents();
        List<Component> getComponentsByName(string name);
        bool insertNewComponent(string name, string description, string author, string type, string path);
        bool deleteComponent(string id, string name);
        bool editComponentInfo(string id, string newName, string newDescription, string newAuthor, string newType, string newPath);
        List<string> reflectComponentClasses(Component component);
        List<string> reflectComponentInterfaces(Component component);
    }
}
