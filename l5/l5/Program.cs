// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
namespace l5
{
    public class l5
    {
        public static void Main(string[] args)
        {
            Del2.Start();
            //Class2.Err();
            //Console.WriteLine("What do you wont to do?. \n 1-Register new student \n,2-See All registered student");
            //int option =  int.Parse(Console.ReadLine());
            //switch (option)
            //{
            //    case 1:
            //        var student = Class1.Main2();
            //        Class1.createStudentinDB(student);
            //        break;
            //    case 2:
            //      var students =   Class1.GetStudents();
            //       Class1.PrintStudents(students);
            //        break;
            //    default:
            //        break;
            //}
           
        } }
        
        //        public static async Task Main3()
        //        {

        //            const string url = "https://catfact.ninja/fact";

        //            bool isCantinue;
        //            do
        //            {
        //                HttpClient httpClient = new HttpClient();
        //                var result = await httpClient.GetStringAsync(url);
        //                var catfact = JsonConvert.DeserializeObject<CatFact>(result);

        //                Console.WriteLine(catfact.Fact);
        //                isCantinue = bool.Parse(Console.ReadLine());
        //            } while (isCantinue);


        //            var user = new User
        //            {
        //                Name = "Test",
        //                Age = 25,
        //                isStudent = false,
        //                SuccessYears = new int[] { 2005, 2006 },
        //                Parent = new Person
        //                {
        //                    Name = "Test2",
        //                    DateOfBirth = DateTime.Parse("1998-02-05") 
        //                },

        //                Children = new Person[]
        //                {
        //    new Person
        //    {
        //            Name = "Test3",
        //        DateOfBirth =  DateTime.Parse("1998-02-05")
        //        },
        //new Person {
        //Name = "Test4",
        //        DateOfBirth =  DateTime.Parse("1998-02-05")

        //    }


        //            }
        //            };
        //        var jsonString = JsonConvert.SerializeObject(user, Formatting.Indented);
        //            Console.WriteLine(jsonString);

        //    } }
        //public class CatFact
        //{
        //    public string Fact { get; set; }
        //    public int Length { get; set; }
        //}


        //public class User
        //{
        //    public string Name { get; set; }
        //    public bool isStudent { get; set; }
        //    public int Age { get; set; }
        //    public int[] SuccessYears { get; set; }
        //    public Person Parent { get; set; }
        //    public Person[] Children { get; set; }


        //}

        //public class Person
        //{
        //    public string Name { get; set; }
        //    public DateTime DateOfBirth { get; set; }
        //}

    
    }

