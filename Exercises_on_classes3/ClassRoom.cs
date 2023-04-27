using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_on_classes3 {
	internal class ClassRoom {
		private Teacher ucitel;
		private Student[] studenti;
		private int currentNumberOfStudents;
		public Teacher Ucitel {
			get { return ucitel; }
			set { ucitel = value; }
		}
		public Student[] Studenti {
			get { return studenti; }
			set { studenti = value; }
		}
		public int CurrentNumberOfStudents {
			get { return currentNumberOfStudents; }
			set {
				currentNumberOfStudents = value;
			}
		}
		public ClassRoom(int maxPocet) {
			studenti = new Student[maxPocet];
			currentNumberOfStudents= 0;
		}
		public bool addStudent(Student student) {
			if (currentNumberOfStudents < studenti.Length) {
				studenti[currentNumberOfStudents] = student;
				currentNumberOfStudents++;
				return true;
			} else {
				return false;
			}
		}
		//public bool removeStudent(int poradi) {
		//	studenti[poradi - 1] = null;
		//}
		public override string ToString() {
			string pomocny = "";
			pomocny += ucitel.ToString() + "\n";
			for (int i = 0; i < currentNumberOfStudents; i++) {
				pomocny += (i+1).ToString()+"." + studenti[i].ToString() + "\n";
			}
			return pomocny;
		}
	}
}
