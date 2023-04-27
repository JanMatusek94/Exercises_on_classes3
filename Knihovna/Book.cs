using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna {
	internal class Book {
		private string title;
		private Author author;
		private int pages;
		private double price;
		private bool available;
		public string Title { get { return title; } set { this.title= value; } }
		public Author Author { get { return author; } set { author = value; } }
		public int Pages { get { return pages; } set { pages = value; } }
		public double Price { get { return price;}
			set {
				price = value;
			} }
		public bool IsAvailable { get { return available;}
			set {
				available = value;
			} }
		public Book(Author author, string title, int pages, double price) {
			this.author = author;
			author.Books.Add(this);
			this.title = title;
			this.pages = pages;
			this.price = price;
			available = true;
		}
		public override string ToString() {
			return $"Kniha: {title}, \t{author}, \tpočet stran: {pages}, cena: {price}";
		}
	}
}
