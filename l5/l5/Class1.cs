using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5
{
    public class Class1
    {
        const string myDbDirectory = @"C:\myNewDb";
        public static Student Main2()
        {
            var student = new Student();

            Console.WriteLine("Name");
            student.Name = Console.ReadLine();

            Console.WriteLine("Surname");
            student.SurName = Console.ReadLine();
            Console.WriteLine("Date of birth (yyyy-MM-dd)");
            student.dateOfBirth = DateTime.Parse(Console.ReadLine());

            student.Id = Guid.NewGuid();
            return student;

        }
        public static void createStudentinDB(Student student)
        {
            var file = Path.Combine(myDbDirectory, student.Id + ".txt");
            if (File.Exists(file))
            {
                Console.WriteLine("This student has olready been registered ");
            }
            else
            {
                var fileText =
                    $"Name:{student.Name}\n"
                    + $"Surname:{student.SurName}\n"
                    + $"Date of Birth:{student.dateOfBirth.ToString("yyyy-MM-dd")}";
                File.WriteAllText(file, fileText);;
            }
        }
        public static Student[] GetStudents()
        {
            var directory = new DirectoryInfo(myDbDirectory);
            var files = directory.GetFiles();
            var i = 0;
            var students = new Student[100];

            foreach (var file in files)
            {
                var fileLines = File.ReadAllLines(file.FullName);
                var student = new Student();
                student.Name = fileLines[0].Split(":")[1].Trim();
                student.SurName = fileLines[1].Split(":")[1].Trim();
                student.dateOfBirth = DateTime.Parse(fileLines[2].Split(":")[1].Trim());
                students[i] = student;
                i++;

            }

            return students;

        }
        public static void PrintStudents(Student[] students){
            foreach (var student in students)
            {
                PrintStudent(student);
            }
        }
        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"{nameof(student.Name)}:{student.Name}\n" +
                $"{nameof(student.SurName)}:{student.SurName}\n" +
                $"{nameof(student.dateOfBirth)}:{student.dateOfBirth.ToString("yyyy-MM-dd")}\n");
        }

    }
   
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}
