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
        public List<string> ObjectProperties(object o)
        {
            List<string> result = new List<string>();
            Type type = o.GetType();
            PropertyInfo[] props = type.GetProperties();

            foreach (PropertyInfo prop in props)
            {
                result.Add(prop.GetValue(o, null).ToString());
            }
            return result;
        }
    }
}
