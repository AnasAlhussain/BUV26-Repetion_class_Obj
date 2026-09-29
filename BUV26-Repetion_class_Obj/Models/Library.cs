using System;
using System.Collections.Generic;
using System.Text;

namespace BUV26_Repetion_class_Obj.Models
{
    internal class Library
    {
        private List<Book> Books = new List<Book>();
        private List<Member> Members = new List<Member>();



        // Visa alla böcker som finns 
        public void ShowAllBooks()
        {
            if(Books.Count == 0)
            {
                Console.WriteLine("Det finns inga böcker i biblioteket.......");
            }
            for(int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine($"{i + 1}.");
                Books[i].Display();
            }
        }

        public void ShowAvailableBooks()
        {
            int antal = 0;
            foreach (Book item in Books)
            {
                if (!item.IsBorrowed)
                {
                    item.Display();
                    antal++;
                }
            }
            if(antal == 0)
            {
                Console.WriteLine("Inga böcker är tillgängliga jus nu");
            }
        }


        // Lägger in lite testdata 
        public void AddTestData()
        {
            Books.Add(new Book("C# för nybörjare", "Anna Svenson", 2024));
            Books.Add(new Book("CLean Code", "Robert ", 2009));
            Books.Add(new Book("Avancerad Java kod", "Reidar", 2010));
        }

    }
}
