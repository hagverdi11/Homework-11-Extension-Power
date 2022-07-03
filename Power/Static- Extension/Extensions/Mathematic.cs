using System;
using System.Collections.Generic;
using System.Text;

namespace Static__Extension.Extensions
{
    public static class Mathematic
    {
       public static double Power(this double number1, double number2)
       {
            return Math.Pow(number1, number2);


       }
    }
}
