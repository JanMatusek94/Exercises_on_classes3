namespace Knihovna
	;
class TestLibrary {
	public static void Main(string[] args) {
		Author aut1 = new Author("Karel", "Capek", new DateTime(1999, 6, 2));
		Author aut2 = new Author("JK", "Rowling", new DateTime(2000, 3, 6));
		Book kniha1 = new Book(aut2, "Harry Potter a kámen mudrů", 300, 550);
		Book kniha2 = new Book(aut2, "Harry Potter a tajemná komnata", 320, 550);
		Book kniha3 = new Book(aut2, "Harry Potter a vězeň z Azkabanu", 350, 550);
		Book kniha4 = new Book(aut2, "Harry Potter a ohnivý pohár", 400, 550);
		Book kniha5 = new Book(aut1, "RUR", 230, 400);
		Book kniha6 = new Book(aut1, "Válka s mloky", 186, 350);
		Book kniha7 = new Book(aut1, "Bílá nemoc", 310, 450);
		Book kniha8 = new Book(aut1, "Matka", 200, 210);
		Book kniha9 = new Book(new Author("Josef", "Kanec", new DateTime(2004,11, 2)),"Nevim", 1000, 10000);
		Reader cten1 = new Reader("Jan", "Matušek", new DateTime(1994,3,6));
		Reader cten2 = new Reader("Petr", "Novák", new DateTime(1995, 11, 13));
		Library knihovna = new Library();
		knihovna.addBook(kniha1);
		knihovna.addBook(kniha2);
		knihovna.addBook(kniha3);
		knihovna.addBook(kniha4);
		knihovna.addBook(kniha5);
		knihovna.addBook(kniha6);
		knihovna.addBook(kniha7);
		knihovna.addBook(kniha8);
		knihovna.addBook(kniha9);
		knihovna.listAvailable();
		Console.WriteLine();
		aut1.listBooks();
		cten1.borrowBook(kniha8);
		cten2.borrowBook(kniha3);
		cten2.borrowBook(kniha4);
		Console.WriteLine();
		cten2.listBorrowed();
		Console.WriteLine();
		knihovna.listUnavailable();
		Console.WriteLine();
		cten1.returnBook(kniha3);
		Console.WriteLine();
		cten2.listBorrowed();
		Console.WriteLine();
		cten2.returnBook(kniha3);
		cten2.listBorrowed();
		knihovna.listAvailable();
	}
}