using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;
using logic;

namespace JAVAComponentInspector
{
    public class JAVAReflectionImpl : JAVAReflection
    {

        public List<string> getClasses(string componentPath)
        {
            try
            {
                List<string> classes = new List<string>();
                Inspector inspector = new ComponentInspector();

                string[] arrayOfClasses = inspector.getClasses(componentPath).toArray().Where(x => x != null)
                           .Select(x => x.ToString())
                           .ToArray();
                classes.AddRange(arrayOfClasses);

                return classes;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<string> getInterfaces(string componentPath)
        {
            try
            {
                Inspector inspector = new ComponentInspector();
                List<string> interfaces = new List<string>();

                string[] arrayOfInterfaces = inspector.getInterfaces(componentPath).toArray().Where(x => x != null)
                           .Select(x => x.ToString())
                           .ToArray();
                interfaces.AddRange(arrayOfInterfaces);

                return interfaces;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}
