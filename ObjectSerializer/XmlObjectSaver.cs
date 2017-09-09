using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSerializer
{
    public class XmlObjectSaver<T> : ObjectSaver<T>
    {
        public XmlObjectSaver()
        {
            _formatter = new XmlFormatter<T>();
        }
    }
}
