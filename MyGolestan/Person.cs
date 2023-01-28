using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    [Serializable]
    public class Person
    {
        public Person(string name, string identicalNum, string password)
        {
            Name = name;
            IdenticalNum = identicalNum;    
            Password = password;
        }

        public string Password { get; set; }
        public string Name { get; set; }
        public string IdenticalNum { get; set; }
        
    }
}
