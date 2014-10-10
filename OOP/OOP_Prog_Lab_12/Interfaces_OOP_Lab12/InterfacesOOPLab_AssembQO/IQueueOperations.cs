using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOOPLab_AssembQO
{
    interface IQueueOperations
    {

        object GetFirst();
        object GetLast();
        int Lenght { get; set; }
    }
}
