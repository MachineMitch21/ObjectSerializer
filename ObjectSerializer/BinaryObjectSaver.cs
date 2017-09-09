using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace ObjectSerializer
{
    public class BinaryObjectSaver<T> : ObjectSaver<T>
    {
        public BinaryObjectSaver()
        {
            _formatter = new BinaryFormatter();
        }
    }
}
