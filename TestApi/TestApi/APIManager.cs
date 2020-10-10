using System;
using System.IO;
using System.Net;
using TestAPI;

namespace TestApi
{
    public class APIManager
    {
        public WebRequest GetRequest(string address)
        {
            var request = WebRequest.Create(address);

            return request;
        }

        public WebResponse GetResponse(WebRequest request)
        {
            var response = request.GetResponse();

            return response;
        }

        public TModel GetData<TModel>(WebResponse response) where TModel : class
        {
            TModel data;

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = JsonManager.GetJsonString(reader);
                    data = JsonManager.ConvertToModel<TModel>(json);
                }
            }
            response.Close();

            if (data == null)
                throw new Exception("Failed to get data");

            return data;
        }

    }
}
