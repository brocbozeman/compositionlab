using System;

namespace composition_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Broc Bozeman" , 'M' , "brocbozeman@gmail.com");
            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("12345" , "How to Finish a Lab" , myAuthor );
            Console.WriteLine(myBook.ToString());

            Book otherBook = new Book("22222" , "How to Write a Lab", new Author("Jamie", 'F', "Jamie@gmail.com"));
            Console.WriteLine(otherBook.ToString());

            otherBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            otherBook.GetEmail();
            Console.WriteLine(otherBook.ToString());
        }
    }
}
