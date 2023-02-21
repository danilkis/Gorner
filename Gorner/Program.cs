using System;
 
namespace ConsoleApplication64
{
    class Program
    {
        public static int Hm(int []a ,int n ,int x)
        {int h=0; 
            for (int i=n-1;i>=0; i--)
            { h= h*x;
                h=h+a[i];

            } return (h);
        }
   
        static void Main(string[] args)
        {
            int  result;
            string s;
            Console.WriteLine("Введите самую большую степень");
            s=Console.ReadLine();
            int k = int.Parse(s);
            int [] ko;
            ko = new int[k+1];
          
            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine("Введите коэффициент при x^ {0}",i);
                s=Console.ReadLine();
                ko[i] = int.Parse(s);
            }
            Console.WriteLine("Введите x");
            s = Console.ReadLine();
            int x=int.Parse(s);

            s="";

            for (int i = k; i >= 0; i = i - 1)
            {
                s = s + ko[i].ToString() + "*x^" + i.ToString() + "+";
              
            }
            s = s + "0=";
            result = Hm(ko,k+1,x);

            Console.WriteLine(s+result.ToString());
            Console.ReadKey();
        }
    }
}