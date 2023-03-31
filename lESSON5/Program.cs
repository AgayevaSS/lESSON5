using System;

namespace Lesson5
{
    internal class Program
    {
        static int balans = 0;

        static void Main(string[] args)

        {
            #region Task1
            //   string text = Console.ReadLine(); // 2 + 1
            //   char operation = text[2];
            //    int num1 = Convert.ToInt32(text[0].ToString());
            //    int num2 = Convert.ToInt32(text[4].ToString());
            //    if(operation == '+')
            //    {
            //        Console.WriteLine(Topla(num1, num2));
            //    }else if(operation == '-')
            //    {
            //        Console.WriteLine(Chixma(num1, num2));
            //    }else if(operation == '*')
            //    {
            //        Console.WriteLine(Vurma(num1, num2));
            //    }
            //    else
            //    {
            //        return;
            //    }

            //}
            //static int Topla(int a, int b)
            //{
            //    return a + b;
            //}
            //static int Chixma(int c, int f)
            //{
            //    return c - f;
            //}
            //static int Vurma(int r, int s)
            //{
            //    return r - s;


            #endregion


        }
        static void InsertMoney(int amount)
        {
           
            balans += amount;
            Console.WriteLine(balans);
        }
        static void TakeMoney(int amount)
        {
            balans += amount;
            Console.WriteLine(balans);
        }
    }

}