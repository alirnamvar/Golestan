using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    [Serializable]
    public class Student : Person, IRegisterable
    {
        public Student(string name, string identicalNum, string password, int intField)
            : base(name, identicalNum, password)
        {
            IntField = intField;
            Field = ((FieldEnum)intField).ToString();
            RegisteredClasses = new List<Class> { };
            Grades = new Dictionary<Class, decimal>();
            GPA = new Dictionary<Class, decimal>();
            GotCredits = new Dictionary<Term, int>();
            MaxCredit = 17;
        }

        public bool RegisterToGolestan(Registor registor)
        {
            return registor.RegisterStudent(this);
        }

        public void UpdateField(int intField)
        {
            IntField = intField;
            Field = ((FieldEnum)intField).ToString();
        }

        public int GetTermRegisteredCredits(Term term)
        {
            int total = 0;
            foreach (var cls in RegisteredClasses)
            {
                if (cls.Term.ID == term.ID)
                {
                    total += cls.Credit;
                }
            }
            return total;
        }

        public void AddClass(Class cls)
        {
            RegisteredClasses.Add(cls);
        }
        public void RemoveClass(Class cls)
        {
            RegisteredClasses.Remove(cls);
        }

        public int MaxCredit { get; private set; }
        public int IntField { get; private set; }
        public string Field { get; private set; }
        public Dictionary<Term, int> GotCredits { get; private set; }
        public Dictionary<Class, decimal> Grades { get; set; }
        public Dictionary<Class, decimal> GPA { get; set; }
        public List<Class> RegisteredClasses { get; private set; }
    }
}
