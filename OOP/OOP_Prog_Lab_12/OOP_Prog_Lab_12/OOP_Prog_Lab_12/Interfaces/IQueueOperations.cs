using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Prog_Lab_12.Code.Interfaces
{
    interface IQueueOperations
    {

        object GetFirst();
        object GetLast();
        int Lenght { get; set; }
    }
}
