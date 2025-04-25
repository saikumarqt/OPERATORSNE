using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORSNE
{
    /*
     * Git Hub: repository where we have all our code.
     * Push the code to repository using visual studio
     * 
     * Operator: 
     * Operator is used to operate between two operands.
     * Ex: c=a+b;
     * here a and b are called operands where "+" is an operator.
     * Types of operator:
     * 1)Aritmetic Operator
     * 2)Assignment Operator
     * 3)Increment and Decrement Operator
     * 4)Relational Operator:
     * 5)Bit wise Operator:
     * 6)Conditional Operator:
     * 
     * 
     * Aritmetic Operator: it used to perform mathematical operations.
     * +,-,*,/,%
     */
    class calcu
    {
        public void add()
        {

        }
        public int sum()
        {
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
               Add();
            Sub();
            Mul();
            Div();
            Modulus();
        }

        private static void Add()
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("sum of {0} and {1} is  {2}",a,b,c);
        }
        private static void Sub()
        {
            Console.WriteLine("Enter a number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b=Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("diff of {0} and {1} is  {2}", a, b, c);
        }
        private static void Mul()
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("mul of {0} and {1} is  {2}", a, b, c);
        }
        private static void Div()
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a / b;
            Console.WriteLine("Div of {0} and {1} is  {2}", a, b, c);
        }
        private static void Modulus()
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a % b;
            Console.WriteLine("mul of {0} and {1} is  {2}", a, b, c);
        }



    }
}
