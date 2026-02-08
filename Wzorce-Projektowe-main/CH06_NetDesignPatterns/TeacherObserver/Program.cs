

Console.WriteLine("Observer - Teacher/Student");

var teacher = new Teacher();
var student1 = new Student("Marek");
var student2 = new Student("Mirek");
var student3 = new Student("Miroslawa");


teacher.Subscribe(student1);
teacher.Subscribe(student2);
teacher.PublishResult("Programowanie", "Zadanie domowe nr 1");
teacher.Subscribe(student3);
teacher.PublishResult("Programowanie", "Zadanie domowe nr 2");

teacher.Unsubscribe(student2);

teacher.PublishResult("Programowanie", "Termin oddania: piatek");

Console.WriteLine("\nKoniec programu.");