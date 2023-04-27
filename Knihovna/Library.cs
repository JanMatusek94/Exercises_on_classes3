using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna {
	internal class Library {
		private List<Book> books;
		public List<Book> Books { get { return books; } set { this.books = value; } }

		public Library() {
			this.books = new List<Book>();
		}

		public void addBook(Book book) {
			books.Add(book);
		}
		public void listAvailable() {
			foreach (Book book in books) {
				if(book.IsAvailable) {
					Console.WriteLine(book);
				}
			}
		}
		public void listUnavailable() {
			foreach (Book book in books) {
				if(!book.IsAvailable) {
					Console.WriteLine(book);
				}
			}
		}
		public void listAll() {
			foreach (Book book in books) {
				Console.WriteLine(book);
			}
		}
	}
}
