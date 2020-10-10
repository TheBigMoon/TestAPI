using System;
using TestApi.Models;
using TestAPI;

namespace TestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string requestString = "http://tester.consimple.pro";
            APIManager manager = new APIManager();

            bool isOpen = true;
            while (isOpen)
            {
                string getData = Informer.IsGetData();

                if(getData == "y")
                {
                    try
                    {
                        var request = manager.GetRequest(requestString);
                        var response = manager.GetResponse(request);
                        ProductModel data = manager.GetData<ProductModel>(response);
                        Informer.ShowProductInfo(data);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Данные введены неверно");
                }

                string isClose = Informer.IsCloseApp();

                if(isClose == "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Данные введены неверно");
                }
            }
        }
    }
}
