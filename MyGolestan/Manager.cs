using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGolestan
{
    public enum FieldEnum
    {
        Computer = 1, Mechanic = 2, ElectricalEngineering = 3, Robotics = 4,
    }

    public class Manager
    {
        private static Golestan _golestanManager;

        public static Golestan GolestanManager
        {
            get
            {
                if (_golestanManager == null)
                    _golestanManager = new Golestan();
                return _golestanManager;
            }
        }
    }

    public class Registor
    {
        public Registor(List<Student> students, List<Professor> professors, List<Employee> employees)
        {
            Students = students;
            Professors = professors;
            Employees = employees;
        }

        private List<Employee> Employees { get; set; }
        private List<Student> Students { get; set; }
        private List<Professor> Professors { get; set; }

        public bool RegisterProfessor(Professor prof)
        {
            if (IsIdenticalNumUnique(prof.IdenticalNum))
            {
                Professors.Add(prof);
                return true;
                //return "welcome to golestan";
            }
            else
            {
                return false;
                //return "this identical number previously registered";
            }
        }

        public bool RegisterStudent(Student student)
        {
            
            if (IsIdenticalNumUnique(student.IdenticalNum))
            {
                //var student = new Student(name, identicalNum, password, intField);
                Students.Add(student);
                return true;
                //return "welcome to golestan";
            }
            return false;
            //return "this identical number previously registered";
        }

        public bool RegisterEmployee(Employee employee)
        {
            if (IsIdenticalNumUnique(employee.IdenticalNum))
            {
                //var student = new Student(name, identicalNum, password, intField);
                Employees.Add(employee);
                return true;
                //return "welcome to golestan";
            }
            return false;
            //return "this identical number previously registered";
        }

        private bool IsIdenticalNumUnique(string idNum)
        {
            var isStudentExist = Students.Any(student => student.IdenticalNum == idNum);
            var isProfessorExist = Professors.Any(professor => professor.IdenticalNum == idNum);
            var isEmployeeExist = Employees.Any(employee => employee.IdenticalNum == idNum);
            return !isStudentExist && !isProfessorExist && !isEmployeeExist;
        }

    }

    public class Golestan
    {
        public List<Class> Classes { get; private set; }
        public List<Student> Students { get; private set; }
        public List<Professor> Professors { get; private set; }
        public List<Employee> Employees { get; private set; }
        public List<Term> Terms { get; private set; }
        //private Registor Registor { get; }
        private AddIndividual AddIndividual { get; }
        //private MarkHandler MarkHandler { get; }
        public Golestan()
        {
            Classes = new List<Class>();
            Students = new List<Student>();
            Professors = new List<Professor>();
            Employees = new List<Employee>();
            Terms = new List<Term>();

            //Registor = new Registor(Students, Professors, Employees);
            AddIndividual = new AddIndividual(Classes, Students, Professors);

            //MarkHandler = new MarkHandler(Classes, Students, Professors);
        }

        public void AddTerm(Term term)
        {
            Terms.Add(term);
        }
        public void LoadDataBase()
        {
            Students = DataHandler.GetListOfStudents();
            Professors = DataHandler.GetListOfProfessors();
            Employees = DataHandler.GetListOfEmployees();
            Terms = DataHandler.GetListOfTerms();
            Classes = DataHandler.GetListOfClasses();
        }
        public Registor GetRegistor()
        {
            return new Registor(Students, Professors, Employees);
        }
        public Student GetStudent(string identicalNum)
        {
            return Students.Find(s => s.IdenticalNum == identicalNum);
        }
        public Student GetStudent(string identicalNum, string password)
        {
            return Students.Find(s => s.IdenticalNum == identicalNum && s.Password == password);
        }
        public Professor GetProfessor(string identicalNum)
        {
            return Professors.Find(p => p.IdenticalNum == identicalNum);
        }
        public Professor GetProfessor(string identicalNum, string password)
        {
            return Professors.Find(p => p.IdenticalNum == identicalNum && p.Password == password);
        }
        public Employee GetEmployee(string identicalNum)
        {
            return Employees.Find(e => e.IdenticalNum == identicalNum);
        }
        public Employee GetEmployee(string identicalNum, string password)
        {
            return Employees.Find(e => e.IdenticalNum == identicalNum && e.Password == password);
        }
        public bool AddProfessor(string identicalNum, string classID)
        {
            return AddIndividual.AddProfessor(identicalNum, classID);
        }
        public bool AddStudent(string identicalNum, string classID)
        {
            return AddIndividual.AddStudent(identicalNum, classID);
        }
        public bool MakeClass(string name, string classID, int intField, int credit, Term term)
        {
            if (Classes.Any(c => c.ID == classID))
            {
                return false;
            }
            else
            {
                DataHandler dh = new DataHandler();
                var cls = new Class(name, classID, intField, credit, term);
                Classes.Add(cls);
                term.Classes.Add(cls);

                // update term in file
                dh.UpdateTerm(Terms, term);

                // save class to file
                string path2 = Environment.CurrentDirectory + @"ClassesBinary.txt";
                dh.AddClass(path2, cls);

                return true;
            }
        }
    }

    //static class IndividualAndClassStatus
    //{
    //    public static void ClassStatus(string classID, List<Class> classes)
    //    {
    //        var class_ = classes.Find(c => c.ID == classID);
    //        if (!IsClassExist(classID, classes))
    //        {
    //            Console.WriteLine("invalid class");
    //            return;
    //        }
    //        if (class_.ClassProfessor == null)
    //        {
    //            Console.Write("None");
    //        }
    //        else
    //        {
    //            Console.Write($"{class_.ClassProfessor.Name}");
    //        }
    //        foreach (var student in class_.Students)
    //        {
    //            Console.Write($" {student.Name}");
    //        }
    //        Console.WriteLine();
    //    }
    //    public static string ProfessorStatus(string identicalNum, List<Professor> professors)
    //    {
    //        string output = "";
    //        if (!IsProfessorExist(identicalNum, professors))
    //        {
    //            return "invalid professor";
    //        }
    //        var prof = professors.Find(x => x.IdenticalNum == identicalNum);
    //        output += $"{prof.Name} {prof.Field}";
    //        foreach (var classes in prof.RegisteredClasses)
    //        {
    //            output += $" {classes.Name}";
    //        }
    //        output += "\n";
    //        return output;
    //    }
    //    public static string StudentStatus(string identicalNum, List<Student> students)
    //    {
    //        string output = "";
    //        if (!IsStudentExist(identicalNum, students))
    //        {
    //            return "invalid student";
    //        }
    //        var student = students.Find(s => s.IdenticalNum == identicalNum);
    //        output += $"{student.Name} {student.Field}";
    //        foreach (var classes in student.RegisteredClasses)
    //        {
    //            output += $" {classes.Name}";
    //        }
    //        output += "\n";
    //        return output;
    //    }
    //    private static bool IsClassExist(string classID, List<Class> classes)
    //    {
    //        return classes.Any(c => c.ID == classID);
    //    }
    //    private static bool IsProfessorExist(string professorIdenticalNum, List<Professor> professors)
    //    {
    //        return professors.Any(professor => professor.IdenticalNum == professorIdenticalNum);
    //    }
    //    private static bool IsStudentExist(string studentIdenticalNum, List<Student> students)
    //    {
    //        return students.Any(student => student.IdenticalNum == studentIdenticalNum);
    //    }
    //}

    public class AddIndividual
    {
        public AddIndividual(List<Class> classes, List<Student> students, List<Professor> professors)
        {
            Classes = classes;
            Students = students;
            Professors = professors;
        }
        private void UpdateListes()
        {
            Classes = Manager.GolestanManager.Classes;
            Students = Manager.GolestanManager.Students;
            Professors = Manager.GolestanManager.Professors;
        }
        public bool AddStudent(string identicalNum, string classID)
        {
            UpdateListes();
            if (!IsStudentExist(identicalNum))
            {
                MessageBox.Show("invalid student");
                return false;
            }
            else if (!IsClassExist(classID))
            {
                MessageBox.Show("invalid class");
                return false;
            }
            else if (!IsStudentFieldMatch(identicalNum, classID))
            {
                MessageBox.Show("student field is not match");
                return false;
            }
            else if (IsStudentInClass(identicalNum, classID))
            {
                MessageBox.Show("student is already registered");
                return false;
            }
            else
            {
                var student = Students.Find(s => s.IdenticalNum == identicalNum);
                var cls = Classes.Find(c => c.ID == classID);              
                cls.AddStudent(student);
                student.AddClass(cls);
                return true;
            }
        }
        public bool AddProfessor(string identicalNum, string classID)
        {
            UpdateListes();
            if (!IsProfessorExist(identicalNum))
            {
                MessageBox.Show("invalid professor");
                return false;
            }
            else if (!IsClassExist(classID))
            {
                MessageBox.Show("invalid class");
                return false;
            }
            else if (!IsProfessorFieldMatch(identicalNum, classID))
            {
                MessageBox.Show("professor field is not match");
                return false;
            }
            else if (ClassHasProfessor(classID))
            {
                var prof = Professors.Find(x => x.IdenticalNum == identicalNum);
                var class_ = Classes.Find(c => c.ID == classID);
                if (ProfessorCanTakeClass(prof))
                {
                    class_.ClassProfessor.RegisteredClasses.RemoveAt(class_.ClassProfessor.RegisteredClasses.Count - 1);
                    class_.ClassProfessor = prof;
                    prof.RegisteredClasses.Add(class_);
                    MessageBox.Show("class professor changed");
                    return true;
                }
                else
                {
                    MessageBox.Show("Professor Reaches Maximum Registered Class Number");
                    return false;
                }
                    
            }
            else
            {
                var prof = Professors.Find(x => x.IdenticalNum == identicalNum);
                var class_ = Classes.Find(c => c.ID == classID);
                if (ProfessorCanTakeClass(prof))
                {
                    class_.ClassProfessor = prof;
                    prof.RegisteredClasses.Add(class_);
                    MessageBox.Show("professor added successfully to the class");
                    return true;
                }
                else
                {
                    MessageBox.Show("Professor Reaches Maximum Registered Class Number");
                    return false;
                }
                
            }

        }
        private bool ProfessorCanTakeClass(Professor prof)
        {
            //var prof = Professors.Find(x => x.IdenticalNum == identicalNum);
            if (prof.RegisteredClasses.Count <= 4)
            {
                return true;
            }
            return false;
        }
        private bool ClassHasProfessor(string classID)
        {
            return Classes.Find(c => c.ID == classID).ClassProfessor != null;
        }
        private bool IsProfessorFieldMatch(string professorIdenticalNum, string classID)
        {
            return (Classes.Find(c => c.ID == classID).IntField) == (Professors.Find(s => s.IdenticalNum == professorIdenticalNum).IntField);
        }
        private bool IsProfessorExist(string professorIdenticalNum)
        {
            return Professors.Any(professor => professor.IdenticalNum == professorIdenticalNum);
        }
        private bool IsStudentExist(string studentIdenticalNum)
        {
            return Students.Any(student => student.IdenticalNum == studentIdenticalNum);
        }
        private bool IsStudentInClass(string studentIdenticalNum, string classID)
        {
            return Classes.Find(c => c.ID == classID).Students.Any(s => s.IdenticalNum == studentIdenticalNum);
        }
        private bool IsClassExist(string classID)
        {
            return Classes.Any(c => c.ID == classID);
        }
        private bool IsStudentFieldMatch(string studentIdenticalNum, string classID)
        {
            return Classes.Find(c => c.ID == classID).IntField == Students.Find(s => s.IdenticalNum == studentIdenticalNum).IntField;
        }

        private List<Class> Classes { get; set; }
        private List<Student> Students { get; set; }
        private List<Professor> Professors { get; set; }
    }
}
