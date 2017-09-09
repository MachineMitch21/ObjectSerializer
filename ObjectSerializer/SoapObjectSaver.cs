using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;

namespace ObjectSerializer
{
    public class SoapObjectSaver<T> : ObjectSaver<T>
    {
        public SoapObjectSaver()
        {
            _formatter = new SoapFormatter();
        }
    }
}
