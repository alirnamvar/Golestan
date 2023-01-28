using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    public interface IRegisterable
    {
        bool RegisterToGolestan(Registor registor);
    }
    public interface IAddTerm
    {
        void AddTerm(string path, Term term);
    }
}
