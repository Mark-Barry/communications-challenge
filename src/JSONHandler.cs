using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Com_Challenge.src
{
    public class JSONHandler<T>
    {
        public static List<T> FileReader(string filename)
        {
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<T>>(json);
                return items;
            }
        }

        public static void FileWriter(string filename, List<T> obj)
        {

            string json = JsonConvert.SerializeObject(obj.ToArray());
            Console.WriteLine(json);

            //write string to file
            System.IO.File.WriteAllText(filename, json);
        }
    }
}
