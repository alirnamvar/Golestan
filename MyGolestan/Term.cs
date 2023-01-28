using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    [Serializable]
    public class Term
    {  
        private static int TermID = 0;
        public Term(string name, DateTime dateOfStartTerm, DateTime dateOfEndTerm,
            DateTime dateOfStartRegister, DateTime dateOfEndRegister)
        {
            ID = TermID;
            TermID++;
            Name = name;
            StartTerm = dateOfStartTerm.Date;
            EndTerm = dateOfEndTerm.Date;
            StartRegister = dateOfStartRegister;
            EndRegister = dateOfEndRegister;
            Classes = new List<Class>();
        }

        public override string ToString()
        {
            return Name;
        }
        public void AddClass(Class cls)
        {
            Classes.Add(cls);
        }

        public int ID { get; }
        public string Name { get; set; }
        public DateTime StartTerm { get; set; }
        public DateTime EndTerm { get;set; }
        public DateTime StartRegister { get; set; }
        public DateTime EndRegister { get; set; }
        public List<Class> Classes { get; set; }
    }
}
