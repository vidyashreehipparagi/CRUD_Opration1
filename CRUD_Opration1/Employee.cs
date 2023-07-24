using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Opration1
{
    public class Employee
    {
        public int eid { get; set; }      
        public string ename { get; set; }

        public double sal {  get; set; }
       }

    public class EmplyoeeCRUD
    {
        private List<Employee> employees;

        public EmplyoeeCRUD()
        {
            employees = new List<Employee>();
        }
        public void AddEmplyoee(Employee emp)
        {
            employees.Add(emp);
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public void UpdateEmplyoee(Employee emp)
        {
            foreach (Employee e in employees)
            {
                if (e.eid == emp.eid)
                {
                    e.ename=emp.ename;
                    emp.sal=emp.sal;
                    break;
                }
            }

        }
        public void DeleteEmplyoee(Employee emp)
        {
            foreach (Employee e in employees)
            {
                if(e.eid == emp.eid) 
                {
                    employees.Remove(e);
                    break;
                }
            }
        }
        
        static void Main(string[] args)
        {
            EmplyoeeCRUD crud=new EmplyoeeCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1. Add Emplyoee details");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4.Display Employee Details");
                int option1=Convert.ToInt32(Console.ReadLine());
                switch (option1)
                {
                    case 1:
                        Employee e1=new Employee();
                        Console.WriteLine("Enter id");
                        e1.eid=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        e1.ename = Console.ReadLine();
                        Console.WriteLine("Enter sal");
                        e1.sal=Convert.ToInt32(Console.ReadLine());
                        crud.AddEmplyoee(e1);

                       break;
                    case 2:
                        Employee e2=new Employee();
                        Console.WriteLine("Enter id");
                        e2.eid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        e2.ename = Console.ReadLine();
                        Console.WriteLine("Enter sal");
                        e2.sal = Convert.ToInt32(Console.ReadLine());
                        crud.UpdateEmplyoee(e2);
                        break;
                    case 3:
                        Employee eid=new Employee();
                        Console.WriteLine("Enter id to delete");
                        eid.eid= Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmplyoee(eid);
                        break;
                    case 4:
                        //Employee e4=new Employee();
                        List<Employee>list= crud.GetEmployees();
                        foreach(Employee empl in list)
                        {
                            Console.WriteLine($"{empl.eid} {empl.ename} {empl.sal}");
                           
                        }

                        break;
                    

                }
                Console.WriteLine("Press 1 for Continue");
                option=Convert.ToInt32(Console.ReadLine());
            }while(option==1);
            

        }

    }
    

}

