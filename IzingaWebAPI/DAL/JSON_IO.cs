using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace IzingaWebAPI.DAL
{
    public class JSON_IO<T>
    {
        public static void Write(T obj, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(obj));
        }

        public static void Write(List<T> obj, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(obj));
        }

        public static T ReadToObject(string path)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }

        public static List<T> ReadToList(string path)
        {
            return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
        }
    }
}