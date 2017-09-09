using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ObjectSerializer
{
    public interface IObjectSaver<T>
    {
        void Save(T objToSave, Stream saveStream);
        T Load(Stream loadStream);
    }
}
