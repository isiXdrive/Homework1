using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mothods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Try catch finnaly - run time error
            //Console.WriteLine("Yashinizi daxil edin:");
            //try
            //{
            //    int age = int.Parse(Console.ReadLine()); // "30" "Salam"
            //    if (age > 18)
            //    {
            //        Console.WriteLine("Welcome");
            //    }
            //    else
            //    {
            //        Console.WriteLine("See you leter");
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Eded olaraq daxil etmediniz!");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally ishledi");
            //}
            #endregion

            #region Method
            //Console.WriteLine(Sum(10, 20));

            //Console.WriteLine(Fullname("Famil", "Musayev"));
            //Print("Hello");
            //Console.WriteLine(Fullname(surname: "Ismayilzade", name: "Kenan"));
            //Console.WriteLine(Calculate());
            //Console.WriteLine(Calculate(10));
            //Console.WriteLine(Calculate(10, 15));
            //Fullname("Ayten", "Ayvazova");
            //int[] arr = { 10, 20, 30 };
            //Console.WriteLine(GetAvg(arr));
            //Console.WriteLine(GetAvg(new int[] { 100,234,134}));
            //Console.WriteLine(GetAvg(100, 234, 134,124,45));
            //JoinString("Kenan","Famil","Ayten","Orxan"); // Kenan,Famil,Ayten,Orxan
            //PrintData("Kenan",6);
            //Write(10,2);
            #endregion

            #region References,value
            #region Value
            //int a = 5;
            //int b = a;
            //a = 6;
            //Console.WriteLine("a="+a);
            //Console.WriteLine("b="+b);
            #endregion
            #region Reference
            //int[] arr = {10,20,30};
            //int[] arr1 = arr;
            //arr[0] = 100;
            //Console.WriteLine("arr[0]="+arr[0]);
            //Console.WriteLine("arr1[0]="+arr1[0]);
            #endregion
            #endregion
        }


        #region Method
        //method signature - method name,parametrs count,parametrs type
        //method overloading
        //static void Write(params int[] arr)
        //{
        //    Console.WriteLine("params work");
        //}
        //static void Write(int n, int n1 = 1)
        //{
        //    Console.WriteLine(n + n1);
        //}
        //static void Write(int n)
        //{
        //    Console.WriteLine(n);
        //}

        static void PrintData(string name,int n)
        {
            Console.WriteLine($"{name} {n}");
        }
        static void PrintData(string s)
        {
            Console.WriteLine(s);
        }

        static void PrintData(int n)
        {
            Console.WriteLine(n);
        }

        //method - reusable code block
        static void JoinString(params string[] arr)
        {

        }
        static double GetAvg(params int[] arr) //10,20,30 - (10+20+30)/3
        {
            double sum = 0;
            double count = arr.Length;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum / count;
        }

        static int Calculate(int x=0,int y=1)
        {
            return x + y;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Returns Fullname
        /// </summary>
        /// <param name="name">Person's name</param>
        /// <param name="surname">Person's surname</param>
        /// <returns></returns>
        static string Fullname(string name,string surname)
        {
            return $"{name} {surname} {Sum(20,25)}";
        }

        static void Print(string str)
        {
            if (str == "Hello")
            {
                Console.WriteLine(str);
                return;
            }
            Console.WriteLine("Hi");
        }
        #endregion

    }
}
