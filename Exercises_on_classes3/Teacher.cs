using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_on_classes3 {
	internal class Teacher {
		private string firstName;
		private string lastName;
		private int age;

		public Teacher(string firstName, string lastName, int age, ClassRoom trida) {
			trida.Ucitel = this;
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
		}

		public override string ToString() {
			return $"Učitel: {firstName} {lastName}, věk: {age} ";
		}
	}
}
