using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CountAnything {
    static class CloneHelper {
        public static T Clone<T>(T obj)
        {
            using(var stream = new MemoryStream(1024)) {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Position = 0;

                return (T) formatter.Deserialize(stream);
            }
        }
    }
}
