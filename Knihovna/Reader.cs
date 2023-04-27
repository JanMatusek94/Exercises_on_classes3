using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna {
	internal class Reader {
		public string firstName;
		public string lastName;
		public DateTime dateOfBirth;
		public List<Book> myBooks;

		public Reader(string firstName, string lastName, DateTime dateOfBirth) {
			this.lastName = lastName;
			this.firstName = firstName;
			this.dateOfBirth = dateOfBirth;
			myBooks = new List<Book>();
		}
		public void borrowBook(Book book) {
			if (book.IsAvailable) {
				myBooks.Add(book);
				book.IsAvailable = false;
			}
		}
		public void returnBook(Book book) {
			if (!book.IsAvailable) {
				foreach (Book book2 in myBooks) {
					if (book2 == book) {
						book.IsAvailable = true;
						myBooks.Remove(book);
						break;
					}
				}
				if (!book.IsAvailable) {
					Console.WriteLine("Knihu má vypůjčenou někdo jiný."); ;
				}
			}
		}
		public void listBorrowed() {
			foreach (Book book in myBooks) {
				Console.WriteLine(book);
			}
		}
	}
}
