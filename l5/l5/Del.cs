using l5.extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5
{
   
    internal class Del
    {
        delegate bool FilterMyListDelegate(int element,int c);
        public static void Dele()
        {
            //FilterMyListDelegate filterMyListDelegate = new FilterMyListDelegate(FilterMyList);
            //Console.WriteLine(filterMyListDelegate(23,10));
           // var user1 = new User1 { Name = "asd", Email = "asd@gmail.com" };
           // Console.WriteLine(user1);
            var list = new List<int>() {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25
            };
            //var list1 = GetElementsFiltered(list,10,CheckANumberDividibleByX);
            var list2 = GetElementsFiltered(list, 14, delegate (int a, int x)
            {
                return a == x;
            });
            var list3 = GetElementsFiltered(list,16,(x,y) => y == 2*x);
            //var newList = GetElementsMoreThanTen(list,15);
            Console.WriteLine(GetListAsString(list3));
            //Console.WriteLine(GetListAsString(newList));
            //Console.WriteLine(GetListAsString(GetElementsDividedByANumber(list,3)));

        }
        public static bool FilterMyList(int number,int c)
        {
            return number > c;
        }
        public static bool FilterMyList2(int number,int comparingNumber)
        {
            return number > comparingNumber;
        }
        public static bool CheckANumberDividibleByX(int a,int c)
        {
            return a % c == 0;
        }
        public static bool  CheckANumberGreaterThanX(int a,int x)
        {
            return a > x;
        }
        //static List<int> GetElementsMoreThanTen(List<int> list,int comparingNumber)
        //{
        //    var subList = new List<int>();
        //    foreach (var item in list)
        //    {
        //        if (item > comparingNumber)
        //        {
        //            subList.Add(item);
        //        }
        //    }
        //    return subList;
        //}
        static string GetListAsString(List<int> list)
        {
            var str = "";
            foreach (var item in list)
            {
                str += item + ",";
            }
            str =  str.TrimEnd(',');
            return str;
        }
        //static List<int> GetElementsDividedByANumber(List<int> list, int comparingNumber)
        //{
        //    var subList = new List<int>();
        //    foreach (var item in list)
        //    {
        //        if (item % comparingNumber == 0)
        //        {
        //            subList.Add(item);
        //        }
        //    }
        //    return subList;
        //}
        static List<int> GetElementsFiltered(List<int> list,int comparingNumber,FilterMyListDelegate filterMyListDelegate)
        {
            var subList = new List<int>();
            foreach (var item in list)
            {
                if (filterMyListDelegate(item,comparingNumber))
                {
                    subList.Add(item);
                }
                else
                {

                }
            }
            return subList;
        }


    }

    public class Del2
    {
        public static void Start()
        {
            var users = InitializeUserList();
            var subList = new List<User1>();
            Func<User1, bool> myFunkDelegate = (u) => u.DateOfBirth > new DateTime(2001, 01, 01);
            
            Console.WriteLine(subList);
            var isTrue = myFunkDelegate(new User1("Asdfg",DateTime.Parse("1990-07-09")));
            // Console.WriteLine(isTrue);
            Console.WriteLine(users.Where(Get2));
            var user2 = new User1("Asdfg", DateTime.Parse("1990-07-09"));
            user2.Greeting();
            UserManager userManager = new();
            userManager[1]=null;

        }
        public static List<User1>InitializeUserList()
        {
            return new List<User1> {
            new User1("xxxxx",DateTime.Parse("1998-05-25")),
            new User1("yyyyy",DateTime.Parse("1990-05-25")),
            new User1("*****",DateTime.Parse("2000-05-25")),
            new User1("aaaaa",DateTime.Parse("2001-05-25")),
            new User1("bbbbb",DateTime.Parse("2002-05-25")),
            new User1("kkkkk",DateTime.Parse("2003-05-25")),

            };
        }
        public static bool Get2(User1 user1)
        {
            return user1.DateOfBirth > DateTime.Parse("2000-01-01");
        }
    }
    public class User1
    {
        public User1(string name,DateTime dateOfBirth)
        {
            Name = name;    
            DateOfBirth = dateOfBirth;
            
            
        }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        // public string Email { get; set; }
        // public override string ToString()
        // {
        // return Name + "" + Email;
        // }

        public override string ToString()
        {
            return Name;
        }
    }
    public class UserManager
    {
        List<User1> _users = new List<User1>();
        public User1 this[int Index]
        {
            get => _users[Index];
            set => _users[Index] = value;
        }

    }
}
