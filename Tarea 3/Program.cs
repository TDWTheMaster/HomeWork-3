using System;
using System.Collections.Generic;

namespace Community
{
    // Class 1
    public class CommunityMember
    {
        public string Name { get; set; }
        public string Identification { get; set; }

        public CommunityMember(string name, string identification)
        {
            Name = name;
            Identification = identification;
        }

        public virtual string GetTypeDescription()
        {
            return "Community Member";
        }

        public virtual void ShowInformation()
        {
            Console.WriteLine($"{GetTypeDescription()}");
            Console.WriteLine($"Name: {Name}, ID: {Identification}");
        }
    }

    // Class 2
    public class Employee : CommunityMember
    {
        public string Position { get; set; }

        public Employee(string name, string identification, string position)
            : base(name, identification)
        {
            Position = position;
        }

        public override string GetTypeDescription()
        {
            return "Employee";
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Position: {Position}");
        }
    }

    // Class 3
    public class Student : CommunityMember
    {
        public string Major { get; set; }

        public Student(string name, string identification, string major)
            : base(name, identification)
        {
            Major = major;
        }

        public override string GetTypeDescription()
        {
            return "Student";
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Major: {Major}");
        }
    }

    // Class 4
    public class Alumni : CommunityMember
    {
        public int GraduationYear { get; set; }

        public Alumni(string name, string identification, int graduationYear)
            : base(name, identification)
        {
            GraduationYear = graduationYear;
        }

        public override string GetTypeDescription()
        {
            return "Alumni";
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Graduation Year: {GraduationYear}");
        }
    }

    // Class 5
    public class Faculty : Employee
    {
        public string Department { get; set; }

        public Faculty(string name, string identification, string position, string department)
            : base(name, identification, position)
        {
            Department = department;
        }

        public override string GetTypeDescription()
        {
            return "Faculty";
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Department: {Department}");
        }
    }

    // Class 6
    public class Administrative : Employee
    {
        public string Area { get; set; }

        public Administrative(string name, string identification, string position, string area)
            : base(name, identification, position)
        {
            Area = area;
        }

        public override string GetTypeDescription()
        {
            return "Administrative";
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Area: {Area}");
        }
    }

    // Class 7
    public class Administrator : Faculty
    {
        public string Level { get; set; }

        public Administrator(string name, string identification, string position, string department, string level)
            : base(name, identification, position, department)
        {
            Level = level;
        }

        public override string GetTypeDescription()
        {
            return "Administrator";
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Level: {Level}");
        }
    }

    // Class 8
    public class Teacher : Faculty
    {
        public string Subject { get; set; }

        public Teacher(string name, string identification, string position, string department, string subject)
            : base(name, identification, position, department)
        {
            Subject = subject;
        }

        public override string GetTypeDescription()
        {
            return "Teacher";
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    class Program
    {
        static List<CommunityMember> members = new List<CommunityMember>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("<====VR Menu====>");
                Console.WriteLine("1. Add Administrator");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. Add Faculty");
                Console.WriteLine("4. Add Administrative");
                Console.WriteLine("5. Add Student");
                Console.WriteLine("6. Add Alumni");
                Console.WriteLine("7. Add Employee");
                Console.WriteLine("8. View All Members");
                Console.WriteLine("9. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddAdministrator();
                        break;
                    case "2":
                        AddTeacher();
                        break;
                    case "3":
                        AddFaculty();
                        break;
                    case "4":
                        AddAdministrative();
                        break;
                    case "5":
                        AddStudent();
                        break;
                    case "6":
                        AddAlumni();
                        break;
                    case "7":
                        AddEmployee();
                        break;
                    case "8":
                        ViewAllMembers();
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddAdministrator()
        {
            Console.Clear();
            Console.WriteLine("Add Administrator:");

            string name = RequestString("Name");
            string identification = RequestNumber("Identification");
            string position = RequestString("Position");
            string department = RequestString("Department");
            string level = RequestString("Level");

            Administrator admin = new Administrator(name, identification, position, department, level);
            members.Insert(0, admin);  // Insert at the beginning

            Console.WriteLine("Administrator added successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddTeacher()
        {
            Console.Clear();
            Console.WriteLine("Add Teacher:");

            string name = RequestString("Name");
            string identification = RequestNumber("Identification");
            string position = RequestString("Position");
            string department = RequestString("Department");
            string subject = RequestString("Subject");

            Teacher teacher = new Teacher(name, identification, position, department, subject);
            members.Insert(0, teacher);  // Insert at the beginning

            Console.WriteLine("Teacher added successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddFaculty()
        {
            Console.Clear();
            Console.WriteLine("Add Faculty:");

            string name = RequestString("Name");
            string identification = RequestNumber("Identification");
            string position = RequestString("Position");
            string department = RequestString("Department");

            Faculty faculty = new Faculty(name, identification, position, department);
            members.Insert(0, faculty);  // Insert at the beginning

            Console.WriteLine("Faculty added successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddAdministrative()
        {
            Console.Clear();
            Console.WriteLine("Add Administrative:");

            string name = RequestString("Name");
            string identification = RequestNumber("Identification");
            string position = RequestString("Position");
            string area = RequestString("Area");

            Administrative administrative = new Administrative(name, identification, position, area);
            members.Insert(0, administrative);  // Insert at the beginning

            Console.WriteLine("Administrative added successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("Add Student:");

            string name = RequestString("Name");
            string identification = RequestNumber("Identification");
            string major = RequestString("Major");

            Student student = new Student(name, identification, major);
            members.Insert(0, student);  // Insert at the beginning

            Console.WriteLine("Student added successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddAlumni()
        {
            Console.Clear();
            Console.WriteLine("Add Alumni:");

            string name = RequestString("Name");
            string identification = RequestNumber("Identification");
            int graduationYear = RequestInteger("Graduation Year");

            Alumni alumni = new Alumni(name, identification, graduationYear);
            members.Insert(0, alumni);  // Insert at the beginning

            Console.WriteLine("Alumni added successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddEmployee()
        {
            Console.Clear();
            Console.WriteLine("Add Employee:");

            string name = RequestString("Name");
            string identification = RequestNumber("Identification");
            string position = RequestString("Position");

            Employee employee = new Employee(name, identification, position);
            members.Insert(0, employee);  // Insert at the beginning

            Console.WriteLine("Employee added successfully.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void ViewAllMembers()
        {
            Console.Clear();
            Console.WriteLine("All Community Members:");

            foreach (var member in members)
            {
                member.ShowInformation();
                Console.WriteLine("<==============================>");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static string RequestString(string field)
        {
            Console.Write($"Enter {field}: ");
            return Console.ReadLine();
        }

        static string RequestNumber(string field)
        {
            while (true)
            {
                Console.Write($"Enter {field} (numbers only): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out _))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Only numbers are allowed.");
                }
            }
        }

        static int RequestInteger(string field)
        {
            while (true)
            {
                Console.Write($"Enter {field} (numbers only): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Only numbers are allowed.");
                }
            }
        }
    }
}







