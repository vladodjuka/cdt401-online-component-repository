using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace NETComponentInspector
{
    public class NETReflectionImpl : NETReflection
    {

        public List<string> getClasses(string componentPath)
        {
            List<string> classes = new List<string>();
            try
            {
                Assembly assembly = Assembly.LoadFrom(componentPath);
                foreach (Type ty in assembly.GetTypes())
                {
                    if (ty.IsClass)
                    {
                        classes.Add(ty.Name);
                    }
                }
                return classes;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<string> getInterfaces(string componentPath)
        {
            List<string> interfaces = new List<string>();
            try
            {
                Assembly assembly = Assembly.LoadFrom(componentPath);
                foreach (Type ty in assembly.GetTypes())
                {
                    if (ty.IsInterface)
                    {
                        interfaces.Add(ty.Name);
                    }
                }
                return interfaces;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
