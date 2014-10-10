using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_OOP_Lab12
{
    interface IQueueOperations
    {

        string Name { get; }
        object GetFirst();
        object GetLast();
        int Lenght { get; set; }
    }
}
