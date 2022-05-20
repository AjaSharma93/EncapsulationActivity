// See https://aka.ms/new-console-template for more information
Student student = new Student("aja",'A',2);
student.DowngradeGrade();
Console.WriteLine($"Grade is {student.GetGrade()}");
Console.WriteLine($"Group is {student.GetGroup()}");

Student student1 = new Student("aja",'C',2);
student.UpgradeGrade();
Console.WriteLine($"Grade is {student.GetGrade()}");
Console.WriteLine($"Group is {student.GetGroup()}");
