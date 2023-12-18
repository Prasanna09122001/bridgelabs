using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    public class NewAttribute : Attribute
    {
        string title;
        string description;
        public NewAttribute(string t, string d)
        {
            title = t;
            description = d;
        }
        public static void AttributeDispaly(Type classType)
        {
            Console.WriteLine("Methos of the class " + classType.Name);
            MethodInfo[] info = classType.GetMethods();
            for (int i = 0; i < info.Length; i++)
            {
                object[] attribute = info[i].GetCustomAttributes(true);
                foreach (var data in attribute)
                {
                    if (data is NewAttribute)
                    {
                        NewAttribute attributeobject = (NewAttribute)data;
                        Console.WriteLine("{0} - {1},{2}",info[i].Name,
                            attributeobject.title,attributeobject.description);
                    }
                }
            }
        }
    }
}
