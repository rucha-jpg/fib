using System;
using System.Xml.Serialization;


class Yay
{
  static void Main(string[] args)
  {
        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int ans = Foo2(a, a - 1);

        Console.WriteLine($"Answer is: {ans}");

        static int Foo(int a)
        {
            int ans = 0;

            for (int i = a; i>= 0; i--)
            {
                 ans = ans + i;
                
            }
            return ans;
        }

        static int Foo2(int n, int i)
        {
            // if(Some condition)
            if (i == 0) return n;
            return Foo2(n + i, --i);
        }

        static int Foo3(int n, int i) { return 0; }

        /*
         [
            [1, 3, 4],
            [4, 5,8],
            [9, 4, 7]
         ]

            

         */
  }


}
