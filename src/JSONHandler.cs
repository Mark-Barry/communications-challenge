using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;

namespace Com_Challenge.src
{
    public class JSONHandler<T>
    {
        public static List<T> FileReader(string filename)
        {
            string filePath = @"../Resources/"+filename;
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<T>>(json);
                return items;
            }
        }

        public static void FileWriter(string filename, List<T> obj)
        {
            string filePath = @"../Resources/"+filename;
            string json = JsonConvert.SerializeObject(obj.ToArray());
            Console.WriteLine(json);

            //write string to file
            System.IO.File.WriteAllText(filePath, json);
        }
    }
}
