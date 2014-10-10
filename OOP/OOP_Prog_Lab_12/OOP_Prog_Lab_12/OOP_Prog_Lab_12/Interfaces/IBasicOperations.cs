using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Prog_Lab_12.Code.Interfaces
{
    interface IBasicOperations
    {

        object this[int index] { get; }
        void Add(object obj);
        void AddRange(params object[] args);
        void Delete(int index);
        void DeleteRange(int startIndex, int endIndex);
        object GetLast();
        void Clear();
    }
}
