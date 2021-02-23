using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace HomeWork10._3.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public static class SerializeExample
    {
        public static void Serialize<T>(T data, string path)
        {
            try
            {
                var jsonData = JsonSerializer.Serialize(data,
                    new JsonSerializerOptions
                        {WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)});
                File.WriteAllText(path, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static T Deserialize<T>(string path)
        {
            try
            {
                var jsonData = File.ReadAllText(path);
                return JsonSerializer.Deserialize<T>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return default;
        }
    }
}
