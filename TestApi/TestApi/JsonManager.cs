using Newtonsoft.Json;
using System;
using System.IO;

namespace TestAPI
{
    public static class JsonManager
    {
        public static string GetJsonString(StreamReader reader)
        {
            string json = reader.ReadToEnd();
            if (json.Length == 0)
                throw new Exception("Failed to get JSON data");

            return json;
        }

        public static TModel ConvertToModel<TModel>(string json) where TModel : class
        {
            TModel result = JsonConvert.DeserializeObject<TModel>(json);

            if (result == null)
                throw new Exception("Failed to convert from JSON data");

            return result;
        }
    }
}
