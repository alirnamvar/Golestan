using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    public class DataHandler : IAddTerm
    {
        private string TermPath { get; }
        private string StudentPath { get; }
        private string ProfessorPath { get; }
        private string EmployeePath { get; }
        private string ClassPath { get; }

        public DataHandler()
        {
            TermPath = Environment.CurrentDirectory + @"TermsBinary.txt";
            StudentPath = Environment.CurrentDirectory + @"StudentsBinary.txt";
            ProfessorPath = Environment.CurrentDirectory + @"ProfessorsBinary.txt";
            EmployeePath = Environment.CurrentDirectory + @"EmployeesBinary.txt";
            ClassPath = Environment.CurrentDirectory + @"ClassesBinary.txt";
        }

        public void AppendIRegisterableObjectsToBinaryFile(string path, IRegisterable obj)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream1 = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream1, obj);
            stream1.Close();
        }

        public static List<Student> GetListOfStudents()
        {
            var tmpList = new List<Student>();
            string path = Environment.CurrentDirectory + @"StudentsBinary.txt";
            using (Stream stream1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter deserializer = new BinaryFormatter();

                while (stream1.Position < stream1.Length)
                {
                    Student temp = (Student)deserializer.Deserialize(stream1);
                    tmpList.Add(temp);
                }
            }
            return tmpList;
        }
        public static List<Professor> GetListOfProfessors()
        {
            var tmpList = new List<Professor>();
            //string path1 = @"E:\Golestan project\golestan\golestan\Files\LessonsInTermBinary.txt";
            string path = Environment.CurrentDirectory + @"ProfessorsBinary.txt";
            using (Stream stream1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter deserializer = new BinaryFormatter();

                while (stream1.Position < stream1.Length)
                {
                    Professor temp = (Professor)deserializer.Deserialize(stream1);
                    tmpList.Add(temp);
                }
            }
            return tmpList;
        }
        public static List<Employee> GetListOfEmployees()
        {
            var tmpList = new List<Employee>();
            string path = Environment.CurrentDirectory + @"EmployeesBinary.txt";
            using (Stream stream1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter deserializer = new BinaryFormatter();

                while (stream1.Position < stream1.Length)
                {
                    Employee temp = (Employee)deserializer.Deserialize(stream1);
                    tmpList.Add(temp);
                }
            }
            return tmpList;
        }
        public static List<Term> GetListOfTerms()
        {
            var tmpList = new List<Term>();
            string path = Environment.CurrentDirectory + @"TermsBinary.txt";
            using (Stream stream1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter deserializer = new BinaryFormatter();

                while (stream1.Position < stream1.Length)
                {
                    Term temp = (Term)deserializer.Deserialize(stream1);
                    tmpList.Add(temp);
                }
            }
            return tmpList;
        }
        public static List<Class> GetListOfClasses()
        {
            var tmpList = new List<Class>();
            string path = Environment.CurrentDirectory + @"ClassesBinary.txt";
            using (Stream stream1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter deserializer = new BinaryFormatter();

                while (stream1.Position < stream1.Length)
                {
                    Class temp = (Class)deserializer.Deserialize(stream1);
                    tmpList.Add(temp);
                }
            }
            return tmpList;
        }

        public void AddClass(string path, Class cls)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream1 = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream1, cls);
            stream1.Close();
        }
        public void AddTerm(string path, Term term)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream1 = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream1, term);
            stream1.Close();
        }
        public void UpdateTerm(List<Term> terms, Term term)
        {
            File.Delete(TermPath);
            foreach (var tempTerm in terms)
            {
                if (tempTerm.Name != term.Name)
                {
                    AddTerm(TermPath, tempTerm);
                }
                else
                {
                    AddTerm(TermPath, term);
                }
            }
        }
        public void UpdateClass(List<Class> classes, Class cls)
        {
            File.Delete(ClassPath);
            foreach (var tempClass in classes)
            {
                if (tempClass.ID != cls.ID)
                {
                    AddClass(ClassPath, tempClass);
                }
                else
                {
                    AddClass(ClassPath, cls);
                }
            }
        }
        public void UpdateStudent(List<Student> students, Student student)
        {
            File.Delete(StudentPath);
            foreach (var tempStudent in students)
            {
                if (tempStudent.IdenticalNum != student.IdenticalNum)
                {
                    AppendIRegisterableObjectsToBinaryFile(StudentPath, tempStudent);
                }
                else
                {
                    AppendIRegisterableObjectsToBinaryFile(StudentPath, student);
                }
            }
        }
        public void UpdateProfessor(List<Professor> professors, Professor professor)
        {
            File.Delete(ProfessorPath);
            foreach (var tempProfessor in professors)
            {
                if (tempProfessor.IdenticalNum != professor.IdenticalNum)
                {
                    AppendIRegisterableObjectsToBinaryFile(ProfessorPath, tempProfessor);
                }
                else
                {
                    AppendIRegisterableObjectsToBinaryFile(ProfessorPath, professor);
                }
            }
        }
    }
}
