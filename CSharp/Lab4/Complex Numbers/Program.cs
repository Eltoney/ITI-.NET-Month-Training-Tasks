using System;
using complex;

namespace Complex_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            complexNumber x = new complexNumber();
            x.Real = 5; x.Img = 2;
            complexNumber y = new complexNumber();
            y.Real = 3; y.Img = 5;
            complexNumber ans = x.Add(y);
            ans.printNumber();
        }
    }
}
