using System;

namespace CalculatorExample
{
    public class Calculator : ICalculator
    {
        public int Result { get; private set; }

        public void Add(int x)
        {
            if (x > 0 && x + Result < Result)
            { 
                throw new OverflowException("Overflow");
            }
            Result += x;
        }

        public void Divide(int x)
        {
            throw new NotImplementedException();
        }

        public void Modulus(int x)
        {
            throw new NotImplementedException();
        }

        public void Multiply(int x)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Subtract(int x)
        {
            throw new NotImplementedException();
        }
    }
}
