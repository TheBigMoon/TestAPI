using Data;
using System;
using System.Linq;
using TestApi.Models;

namespace TestAPI
{
    public static class DisplayManager
    {
        public static void ShowProductInfo(ProductModel model) 
        {
            int maxSpace = 30;

            string titleSpace = new string(' ', maxSpace - 7);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Product{titleSpace}Category");
            Console.ResetColor();

            foreach (Product prod in model.Products)
            {
                Category category = model.Categories
                    .Where(x => x.Id == prod.CategoryId)
                    .FirstOrDefault();

                int nameLength = prod.Name.Length;
                string space = new string(' ', maxSpace - nameLength);

                Console.WriteLine($"{prod.Name}{space}{category.Name}");
            }
        }

        public static string DisplayGetDataQuestion()
        {
            string result;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Constants.DisplayManager.GetDataQuestion);
            Console.WriteLine(Constants.DisplayManager.ConfirmInput);
            Console.ResetColor();
            
            result = Console.ReadLine().ToLower();
            
            return result;
        }

        public static string DisplayCloseAppQuestion()
        {
            string result;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Constants.DisplayManager.CloseAppQuestion);
            Console.WriteLine(Constants.DisplayManager.ConfirmInput);
            Console.ResetColor();

            result = Console.ReadLine().ToLower();

            return result;
        }
    }
}
