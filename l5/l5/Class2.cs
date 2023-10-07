using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5
{
    internal class Class2
    {

        public static void Err()
        {
            //         string filePath = "C:\\Users\\Asus\\Desktop\\New folder\\Mydb\\logs.txt";

            //         try
            //         {
            //             int num = int.Parse(Console.ReadLine());
            //             int num2 = int.Parse(Console.ReadLine());

            //             Console.WriteLine(num/num2);

            //         }
            //         catch (Exception exc)
            //{
            //             File.AppendAllText(filePath,DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss:fff")+"\n"+ exc.Message.ToString() +"\n");
            //	throw;
            //}
            //Dictionary<int, User> userDictionary = new Dictionary<int, User>();
            //var user1 = new User { Id = 1, Name = "Murad", dateOfBirth = DateTime.Parse("1998-05-27") };
            //var user2 = new User { Id = 2, Name = "_____", dateOfBirth = DateTime.Parse("1990-09-25") };
            //userDictionary.Add(user1.Id, user1);
            //userDictionary.Add(user2.Id, user2);
            //int userId = int.Parse(Console.ReadLine());

            //if (userDictionary.ContainsKey(userId)) {
            //    var foundUser = userDictionary[userId];
            //    Console.WriteLine(foundUser);
            //}
            //else
            //{
            //    Console.WriteLine("User not found");
            //}
        


            DataCollections<int> dataCollections = new DataCollections<int>();
            dataCollections.Add(5);
            dataCollections.Add(4);
            //Console.WriteLine(dataCollections.GetElementByIndex(0));
            //Console.WriteLine(dataCollections.GetElementByIndex(1));
            int sum = 0;
            foreach (var item in dataCollections)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < dataCollections.count;i++) 
            //{
            //    sum += dataCollections.GetElementByIndex(i);
            //}
            Console.WriteLine(sum);
        }
    }
    public class DataCollections<T>: IEnumerable <T>
    {
        private List <T> _items;
        public DataCollections()
        {
            _items = new List <T>();
        }
        public void Add (T item)
        {
            _items.Add (item);
        }
        public T GetElementByIndex (int index) {
            return _items[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public int count { get {
                return _items.Count;
            } }
    }

    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime dateOfBirth { get; set; }
        public override string ToString()
        {
            return $"Id is {Id}, Name is {Name}, Dateofbirth is {dateOfBirth}";
        }
    }
}
