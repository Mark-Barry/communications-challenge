using System;
using System.Collections.Generic;
using System.IO;
using Json.Net;

namespace Com_Challenge.src
{
    public class JSONHandler
    {
        public static void FileReader(string filename, object type)
        {
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                List<type> items = JsonConverter.DeserializeObject<List<type>>(json);
            }
        }

        public static void FileWriter(string filename, object obj)
        {

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(filename, JsonConverter.SerializeObject(obj));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, (Json.Net.SerializationOptions)obj);
            }
        }
    }
}
