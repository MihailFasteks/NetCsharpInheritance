// See https://aka.ms/new-console-template for more information

using NetCsharpInheritance;

Student stud1 = new Student("Alex", "Kanelli", 19, "+3837363636", 72, 3);
Student stud2 = new Student("Oleg", "Jopric", 19, "+3837363636", 64, 4);
Student stud3 = new Student("Moisha", "Kacman", 19, "+3837363636", 100, 5);

Academy_group ac1 = new Academy_group(5);
ac1.Add(stud1);
ac1.Add(stud2);
ac1.Add(stud3);
ac1.Print();
Console.WriteLine();

ac1.Remove("Kanelli");
ac1.Print();
Console.WriteLine();

ac1.Edit("Jopric", stud1);
ac1.Print();
Console.WriteLine();