static void Main(string[] args)
{
    SchoolPerson student = new SchoolPerson(" New York Film School", "Ayxan", "Quluzade", 15, 2000, "Art");


    Console.WriteLine($"Name: {student.Name}");
    Console.WriteLine($"Surname: {student.Surname}");
    Console.WriteLine($"Age: {student.Age}");
    Console.WriteLine($"Date of Birth: {student.DateOfBirth}");
    Console.WriteLine($"CurrentClass: {student.CurrentClass}");

    student.Greet();
}