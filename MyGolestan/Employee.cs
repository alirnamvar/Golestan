using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    [Serializable]
    public class Employee : Person, IRegisterable
    {
        public Employee(string name, string identicalNum, string password)
            : base(name, identicalNum, password)
        {
            Grades = new Dictionary<Class, decimal>();
        }

        public Dictionary<Class, decimal> Grades { get; set; }

        public bool RegisterToGolestan(Registor registor)
        {
            return registor.RegisterEmployee(this);
        }
    }
}
