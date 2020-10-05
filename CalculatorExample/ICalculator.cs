using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorExample
{
    public interface ICalculator
    {   // property keeping the current result of the calculator
        int Result { get; }     

        // resets the current result of the calculator 
        void Reset();    
        
        // adds x to the current result 
        void Add(int x); 

        // subtracts x from the current result 
        void Subtract(int x); 

        // multiplies the current result with x 
        void Multiply(int x);
        
        // divides the currents result with x (integer division) 
        void Divide(int x); 

        // divides the current result with x and stores the remainder as // the current result }
        void Modulus(int x);
    }
}