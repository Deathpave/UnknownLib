using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Objects
{
    class ReadObject
    {
        public List<string> ObjectProperties(object o, List<string> result)
        {
            // gets the type of the input object
            Type type = o.GetType();

            // gets the properties of the object
            PropertyInfo[] props = type.GetProperties();

            // goes through all properties and adds the to result list as strings
            foreach (PropertyInfo prop in props)
            {
                result.Add(prop.GetValue(o, null).ToString());
            }

            // returns the result list with object properties
            return result;
        }
    }
}
