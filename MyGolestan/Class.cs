using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    //public enum FieldEnum { Computer = 1, Mechanic = 2, ElectricalEngineering = 3, Robotics = 4 }
    [Serializable]
    public class Class
    {
        public Class(string name, string classID, int intField, int credit, Term term)
        {
            Name = name;
            ID = classID;
            IntField = intField;
            Field = ((FieldEnum)intField).ToString();
            ClassProfessor = null;
            Students = new List<Student>();
            Credit = credit;
            Term = term;
        }

        public override string ToString()
        {
            return $"{Name} ({ID})";
        }

        public void UpdateField(int intField)
        {
            IntField = intField;
            Field = ((FieldEnum)intField).ToString();
        }

        public void UpdateTerm(Term term)
        {
            Term = term;
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public string Field { get; set; }
        public int IntField { get; set; }
        public int Credit { get; set; }
        public Term Term { get; set; }
        public Professor ClassProfessor { get; set; }
        public List<Student> Students { get; private set; }
    }
}
