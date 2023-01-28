using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    [Serializable]
    public class Professor : Person, IRegisterable
    {
        public Professor(string name, string identicalNum, string password, int intField)
            : base(name, identicalNum, password)
        {
            IntField = intField;
            Field = ((FieldEnum)intField).ToString();
            RegisteredClasses = new List<Class>();
        }

        public bool RegisterToGolestan(Registor registor)
        {
            return registor.RegisterProfessor(this);
        }

        public void UpdateField(int intField)
        {
            IntField = intField;
            Field = ((FieldEnum)intField).ToString();
        }

        public override string ToString()
        {
            return Name + " (" + Field + ")";
        }

        public int IntField { get; set; }
        public string Field { get; set; }
        public List<Class> RegisteredClasses { get; }
    }
}
