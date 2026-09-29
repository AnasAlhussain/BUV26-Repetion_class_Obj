using BUV26_Repetion_class_Obj.Models;

namespace BUV26_Repetion_class_Obj
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Library library = new Library();
            library.AddTestData();



            //Console.WriteLine("Vill du köra systemt ");
            //string svar = Console.ReadLine().ToLower();

            bool run = true;
            while (run)
            {
                Console.WriteLine();
                Console.WriteLine("====== Library System =======");
                Console.WriteLine("1. Visa alla böcker ");
                Console.WriteLine("2. Visa tillgängliga böcker ");
                Console.WriteLine("0. Avsluta systemet ");
           


            string val = Console.ReadLine();

            Console.WriteLine();

            switch (val)
            {
                case "1":
                    library.ShowAllBooks();
                    break;
                case "2":
                    library.ShowAvailableBooks();
                    break;

                case "0":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val ");
                    break;
            }

        }

            Console.ReadKey();
        }
    }
}
