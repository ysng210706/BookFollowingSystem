namespace BookFollowingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryManager manager = new LibraryManager();

            while (true)
            {
                Console.WriteLine("1-Kitap Ekle");
                Console.WriteLine("2-Kitapları listele");
                Console.WriteLine("3-Kitap ödünç al");
                Console.WriteLine("4-Kitap iade et");
                Console.WriteLine("5-Çıkış");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Please enter the book name: ");
                    string bookName = Console.ReadLine();
                    Console.Write("Please enter the name of the author: ");
                    string authorName = Console.ReadLine();
                    Console.Write("Please enter the ID of the book: ");
                    int bookID = int.Parse(Console.ReadLine());
                    Book newbook = new Book();
                    newbook.Title = bookName;
                    newbook.Author = authorName;
                    newbook.ID= bookID;
                    manager.AddBook(newbook);
                }
                else if (choice == 2)
                {
                    manager.ListAllItems();
                }
                else if (choice == 3)
                {
                    Console.Write("Please enter your name: ");
                    string memberName = Console.ReadLine();
                    Console.Write("Please enter the ID of the book: ");
                    int bookID = int.Parse(Console.ReadLine());
                    manager.BorrowBook(bookID, memberName);
                }
                else if (choice == 4)
                {

                    Console.Write("Please enter the ID of the book: ");
                    int bookID = int.Parse(Console.ReadLine());
                    manager.ReturnBook(bookID);

                }
                else if (choice == 5) { return; }





            }
        }
    }
}
