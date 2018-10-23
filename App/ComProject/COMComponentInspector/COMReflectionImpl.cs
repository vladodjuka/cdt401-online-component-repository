using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace COMComponentInspector
{
    public class COMReflectionImpl : COMReflection
    {
        [DllImport("oleaut32.dll", PreserveSig = false)]
        public static extern ITypeLib LoadTypeLib([In, MarshalAs(UnmanagedType.LPWStr)] string typelib);

        public List<string> getClasses(string componentPath)
        {
            List<string> classes = new List<string>();

            ITypeLib typeLibrary = LoadTypeLib(componentPath);

            for (int i = 0; i < typeLibrary.GetTypeInfoCount(); i++)
            {

                ITypeInfo tt;
               // typeLibrary.GetType
                typeLibrary.GetTypeInfo(i, out tt);
                string name;
                //string dd;
                //int ss;
                //string jj;
                //typeLibrary.
                //tt.GetDocumentation(i, out name, null, null, null);
                Type type = tt.GetType();
                //System.Runtime.InteropServices.ComTypes.TYPEKIND typeKind;
                //typeLibrary.GetTypeInfoType(i, out typeKind);
               // Type type = typeKind.GetType();

                if (type.IsClass)
                {
                    classes.Add(type.Name);
                }

            }
            return classes;
        }

        public List<string> getInterfaces(string componentPath)
        {
            List<string> interfaces = new List<string>();
            ITypeLib typeLibrary = LoadTypeLib(componentPath);

            for (int i = 0; i < typeLibrary.GetTypeInfoCount(); i++)
            {
                System.Runtime.InteropServices.ComTypes.TYPEKIND typeKind;
                typeLibrary.GetTypeInfoType(i, out typeKind);
                Type type = typeKind.GetType();

                if (type.IsClass)
                {
                    interfaces.Add(type.Name);
                }

            }
            return interfaces;
        }

    }
}

