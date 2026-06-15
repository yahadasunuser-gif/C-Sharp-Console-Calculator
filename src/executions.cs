using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class executions
    {
        public double num_1;
        public double num_2;
        public double Add()
            {
                double sum = num_1 + num_2;
                return sum;
            }
        public double substraction()
        {
            if (num_1 > num_2)
            {
                double substraction = num_1 - num_2;
                return substraction;
            }

            else
            {
                double substraction = num_2 - num_1;
                return substraction;
            }         
            
        }
        public double multiplication()
        {
            double mul = num_1 * num_2;
            return mul;
        }
        public double division() 
        {
            if (num_2 != 0)
            {
                double div = num_1 / num_2;
                return div;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                return 0; 
            }
        }


    }
    
}

