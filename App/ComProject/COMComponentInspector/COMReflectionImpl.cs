using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using COM_inspectLib;


namespace COMComponentInspector
{
    public class COMReflectionImpl : COMReflection
    {

        Iinspect comInspector = new inspect();

        string classesCom = "classes_list";
        string interfacesCom = "interfaces_list";

        public List<string> getClasses(string componentPath)
        {
            List<string> classes = new List<string>();

            comInspector.inspect_component(componentPath, ref interfacesCom, ref classesCom);

            string[] classesArray = classesCom.Split(';');

            classes.AddRange(classesArray.Where(x => !string.IsNullOrEmpty(x)));

            return classes;
        }

        public List<string> getInterfaces(string componentPath)
        {
            List<string> interfaces = new List<string>();

            comInspector.inspect_component(componentPath, ref interfacesCom, ref classesCom);

            string[] interfacesArray = interfacesCom.Split(';');

            interfaces.AddRange(interfacesArray.Where(x=>!string.IsNullOrEmpty(x)));

            return interfaces;
        }

    }
}

