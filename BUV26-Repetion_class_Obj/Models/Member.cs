using System;
using System.Collections.Generic;
using System.Text;

namespace BUV26_Repetion_class_Obj.Models
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Book> BorrowedBooks { get; set; }
         
        public const int MaxBorrowedBooks = 3;

        public Member(int id,string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }


        public bool CanBorrow()
        {
            return BorrowedBooks.Count < MaxBorrowedBooks;
        }

        public void Diplay()
        {
            Console.WriteLine($"{Id}  {Name} - {BorrowedBooks.Count} Lånade böcker");

            foreach (Book b in BorrowedBooks)
            {
                Console.WriteLine($"     - {b.Title}");
            }
        }

    }
}
