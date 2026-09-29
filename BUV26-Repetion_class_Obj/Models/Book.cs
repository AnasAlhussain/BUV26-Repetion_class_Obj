using System;
using System.Collections.Generic;
using System.Text;

namespace BUV26_Repetion_class_Obj.Models
{
    internal class Book
    {
        //Data som varje bok har (Egenskaper)

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsBorrowed { get; set; }



        public Book() : this("No Title ","No Author",00)
        {

        }

        public Book(string title,string author,int year)
        {
            Title = title;
            Author = author;
            Year = year;
            IsBorrowed = false; // En bok är alltid tillgänglig 
        }

        // Method i Book 
        public void Display()
        {

           string status = IsBorrowed ? "Utlånad" : "Tillgänglig";
            Console.WriteLine($"{Title} av {Author} {Year } - {status}");
        }

    }
}
