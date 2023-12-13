using static System.Net.WebRequestMethods;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.addBook(new Book("Death on the Nile", "Victor", 2020, true));
            library.addBook(new Book("DK Cocktails", "Vasia", 2016, true));
            library.addBook(new Book("Prada Catwalk", "Joe", 2021, true));
            library.addBook(new Book("Sapiens. A Brief History of Humankind", "Jett", 2019, false));

            //remove
            library.removeBook("\nDeath on the Nile");
            Console.WriteLine("Remove Death on the Nile:");
            library.listAvailbleBooks();
            
            //find
            Console.WriteLine("\nFind Prada Catwalk");
            var findBook = library.searchBook("Prada Catwalk");
            Console.WriteLine(findBook);

            //took
            Console.WriteLine("\nTook DK Cocktails");
            var took = library.searchBook("DK Cocktails");
            took.borrow();
            Console.WriteLine("Avalible: ");
            library.listAvailbleBooks();

            //return
            Console.WriteLine("\nReturn Sapiens. A Brief History of Humankind");
            var returnB = library.searchBook("Sapiens. A Brief History of Humankind");
            returnB.returnBook();
            Console.WriteLine("Avalible: ");
            library.listAvailbleBooks();

            Console.ReadKey();
        }
    }
}