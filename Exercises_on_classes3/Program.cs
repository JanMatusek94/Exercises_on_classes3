namespace Exercises_on_classes3;
	class TestClass {
	public static void Main() {
		ClassRoom trida1 = new ClassRoom(10);
		Student stud1 = new Student("Petr", "Kovar", 10, 12.3);
		Student stud2 = new Student("Jan", "Novak", 12, 12.9);
		Student stud3 = new Student("Lukas", "Skywalker", 7, 12.3);
		Student stud4 = new Student("David", "Baseed", 10, 12.3);
		Student stud5 = new Student("Tomas", "Masinka", 10, 10.3);
		Console.WriteLine(trida1.Ucitel);
		Teacher ucitel1 = new Teacher("Jan", "Matušek", 29, trida1);
		Console.WriteLine(trida1.Ucitel);
		trida1.addStudent(stud1);
		trida1.addStudent(stud2);
		trida1.addStudent(stud3);
		trida1.addStudent(stud4);
		trida1.addStudent(stud5);
		Console.WriteLine(trida1);

	}
}
	