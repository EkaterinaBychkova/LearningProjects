﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_OOP_Lab12
{
    interface IOperationsMatrix
    {

        string Name { get; }
        void AdditionMatrix();
        void SubtractionMatrix();
        void MultiplicationMatrix();
    }
}
