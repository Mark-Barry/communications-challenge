using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Com_Challenge.src
{
    public class JSONHandler
    {
        public static List<object> FileReader(string filename, List<object> type)
        {
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<object>>(json);
                return items;
            }
        }

        public static void FileWriter(string filename, List<object> obj)
        {

            string json = JsonConvert.SerializeObject(obj.ToArray());

            //write string to file
            System.IO.File.WriteAllText(filename, json);
        }
    }
}
