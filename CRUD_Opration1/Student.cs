using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Opration1
{
    public class Student
    {

        public int rollNo { get; set; }
        public string name { get; set; }

        public string school { get; set; }
    }

    public class StudentCrud
    {
        private List<Student> students;

        public StudentCrud()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student stud)
        {
            students.Add(stud);
        }
        public List<Student> GetStudents()
        {
            return students;
        }

        public void UpdateStudent(Student stud)
        {
            foreach (Student s1 in students)
            {
                if (s1.rollNo == stud.rollNo)
                {
                    s1.name = stud.name;
                    s1.school = stud.school;
                }
            }
        }

        public void DeleteStudent(int rollNo)
        {
            foreach (Student s1 in students)
            {
                if (s1.rollNo == rollNo)
                {
                    students.Remove(s1);
                }
            }
        }
        static void Main(string[] args)
        {
            StudentCrud studentCrud = new StudentCrud();
            int option = 0;
            do
            {


                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Display student details");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Student student = new Student();
                        Console.WriteLine("Enter Roll Number");
                        student.rollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student name");
                        student.name = Console.ReadLine();
                        Console.WriteLine("Enter school name");
                        student.school = Console.ReadLine();

                        studentCrud.AddStudent(student);

                        break;
                    case 2:
                        Student student1 = new Student();
                        Console.WriteLine("Enter new Roll No ");
                        student1.rollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name to update");
                        student1.name = Console.ReadLine();
                        Console.WriteLine("Enter school name to update ");
                        student1.school = Console.ReadLine();
                        studentCrud.UpdateStudent(student1);
                        break;
                    case 3:
                        Console.WriteLine("Enter roll number to delete record");
                        int rollNo = Convert.ToInt32(Console.ReadLine());
                        studentCrud.DeleteStudent(rollNo);
                        break;
                        
                    case 4:
                        List<Student> students = studentCrud.GetStudents();
                        foreach (Student s in students)
                        {
                            Console.WriteLine($"{s.rollNo}-{s.name}-{s.school}");
                        }
                        break;
                }
                Console.WriteLine("Press 1 to Continue");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }
    }
}

