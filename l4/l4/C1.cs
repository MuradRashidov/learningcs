using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4
{
    internal class C1
    {
        internal static void Main()
        {

            Employee employee = new SuperWicer(1,"Admin");
            Employee employee1 = new Manager(1, "User");
            Employee employee2 = new SuperWicer(3, "SuperAdmin");
            Employee[] employees = {employee,employee1,employee2 };
            foreach(Employee emp in  employees)
            {
                if (emp is Manager)
                {
                    
                    var e = emp as Manager;
                    
                    //((Manager)emp).Planning();
                }
            }
            employee.Work();
          

        }
    }

    public class Employee
    {
        public int Id;
        public string Name;
        public int Age;
        public int Salary;
        public Employee(int id)
        {
            Id=id;
        }

        public virtual void Work()
        {
            Console.WriteLine("Employee working");
        }
    }

    public class Manager:Employee
    {
        public string Role;
        public Manager(int id,string role):base(id) 
        {
            Role=role;
        }
        public override  void Work()
        {
            Console.WriteLine("Manager Working");
        }
        public void Planning()
        {
            Console.WriteLine("Manager Planning");
        }
    }
    public class SuperWicer:Manager
    {
        public SuperWicer(int id,string role):base(id,role)
        {
            
        }
        public override void Work()
        {
            Console.WriteLine("Superwicer working");
        }
        public void Direct()
        {
            Console.WriteLine("Supervicer directed");
        }
    }
}
    