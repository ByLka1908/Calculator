﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface InterfaceClac
    {
        void Put_A(double a);

        void Clear_A();

        double Multiplication(double b);
        double Division(double b);
        double Sum(double b);
        double Subtraction(double b);
        double SqrtX(double b);
        double Degree(double b);
        double Sqrt();
        double Square();
        double Factorial();
        double MemoryShow();
        void Memory_Clear();

        void M_Multiplication(double b);
        void M_Division(double b);
        void M_Sum(double b);
        void M_Subtraction(double b);
    }
}
