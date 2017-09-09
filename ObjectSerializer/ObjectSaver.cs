using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace ObjectSerializer
{
    public abstract class ObjectSaver<T> : IObjectSaver<T>
    {
        protected IFormatter _formatter;

        public void Save(T objToSave, Stream saveStream)
        {
            try
            {
                _formatter.Serialize(saveStream, objToSave);
            }
            catch(SerializationException e)
            {
                Console.WriteLine(string.Format("Error saving {0} to {1} \n ERROR REPORT: {2}", objToSave.ToString(), saveStream.ToString(), e.Message));
            }
            finally
            {
                saveStream.Close();
            }
        }

        public T Load(Stream loadStream)
        {
            T loadObj = default(T);

            try
            {
                loadObj = (T)_formatter.Deserialize(loadStream);
                return loadObj;
            }
            catch(SerializationException e)
            {
                Console.WriteLine(string.Format("Error loading object from {1} \n ERROR REPORT: {2}", loadStream.ToString(), e.Message));
            }
            finally
            {
                loadStream.Close();
            }

            return default(T);
        }

    }
}
