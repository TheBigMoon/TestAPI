using Data;
using System;
using System.Linq;
using TestAPI.Models;

namespace TestAPI
{
    public static class Informer
    {
        public static void ShowProductInfo(IProductModel model) 
        {
            int maxSpace = 30;

            string titleSpace = new string(' ', maxSpace - 7);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Product{titleSpace}Category");
            Console.ResetColor();

            foreach (Product prod in model.Products)
            {
                IModelBase category = model.Categories
                    .Where(x => x.Id == prod.CategoryId)
                    .FirstOrDefault();

                int nameLength = prod.Name.Length;
                string space = new string(' ', maxSpace - nameLength);

                Console.WriteLine($"{prod.Name}{space}{category.Name}");
            }
        }

        public static string IsGetData()
        {
            string result;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Получить данные с сервера?");
            Console.WriteLine("Для подтверждения нажмите \"Y\" и нажмите ENTER");
            Console.ResetColor();
            
            result = Console.ReadLine().ToLower();
            
            return result;
        }

        public static string IsCloseApp()
        {
            string result;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Закрыть приложение?");
            Console.WriteLine("Для подтверждения введите \"Y\" и нажмите ENTER");
            Console.ResetColor();

            result = Console.ReadLine().ToLower();

            return result;
        }


    }
}
