using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna {
	internal class Author {
		private List<Book> books;
		private string firstName;
		private string lastName;
		private DateTime dateOfBirth;
		public List<Book> Books { get { return books; } set { this.books = value;} }
		public string FirstName {
			get { return firstName; }
			set { firstName = value; }
		}
		public string LastName {
			get { return lastName; }
			set { lastName = value; }
		}
		public Author(string firstName, string lastName, DateTime dateOfBirth) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.dateOfBirth = dateOfBirth;
			books =	new List<Book>();
		}
		public void listBooks() {
			foreach (Book book in books) {
				Console.WriteLine(book);
			}
		}
		public override string ToString() {
			return $"Jméno autora: {firstName} {lastName}, rok narození: {dateOfBirth.Year}";
		}
	}
}
