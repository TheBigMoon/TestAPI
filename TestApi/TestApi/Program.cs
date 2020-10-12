using Data;
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

            bool isOpenApp = true;
            while (isOpenApp)
            {
                string getDataAnswer = DisplayManager.DisplayGetDataQuestion();

                if(getDataAnswer == "y")
                {
                    try
                    {
                        var request = manager.GetRequest(requestString);
                        var response = manager.GetResponse(request);
                        ProductModel data = manager.GetData<ProductModel>(response);
                        DisplayManager.ShowProductInfo(data);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(Constants.ErrorMessages.IncorrectInputData);
                }

                string closeAppAnswer = DisplayManager.DisplayCloseAppQuestion();

                if(closeAppAnswer == "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Constants.ErrorMessages.IncorrectInputData);
                }
            }
        }
    }
}
