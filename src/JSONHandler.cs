using System;
namespace Com_Challenge.src
{
    public class JSONHandler
    {
        public static void FileReader(string filename, object type)
        {

        }

        public static void ReplaceJsonValue()
        {
            string filepath = "../../json1.json";
            string result = string.Empty;
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);
                foreach (var item in jobj.Properties())
                {
                    item.Value = item.Value.ToString().Replace("v1", "v2");
                }
                result = jobj.ToString();
                Console.WriteLine(result);
            }
            File.WriteAllText(filepath, result);
        }
    }
}
