using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MobileApi3
{
    public static class Constants
    {
        public static string RestUrl = "https://api.openweathermap.org/data/2.5/weather";
        public static string GetApiKey()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "MobileApi3.ApiKey.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return result;
            }
        }
    }
}
