using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_on_classes3 {
	internal class Student {
		private string firstName;
		private string lastName;
		private double age;
		private double average;
		public string FirstName {
			get { return firstName; }
			set { this.firstName = value;}
		}
		public string LastName {
			get { return lastName; }
			set { this.lastName = value;}
		}
		public double Age {
			get { return age; }
			set { this.age = value;}
		}


		public Student(string firstName, string lastName, double age, double average) {
			this.lastName = lastName;
			this.firstName = firstName;
			this.age = age;
			this.average = average;
		}
		public override string ToString() {
			return $" student: {firstName} {lastName}, věk: {age}, průměr {average}";
		}
	}
}
