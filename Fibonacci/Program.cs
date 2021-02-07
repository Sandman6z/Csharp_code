using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //显示斐波那契数列的第20项
            Console.WriteLine(fibonacii(20));
            //显示斐波那契数列的第40项
            Console.WriteLine(fibonacii(40));
            //等待用户按键动作，防止程序快速结束
            Console.ReadKey();
        }
        public static int fibonacii(int i)
        {
            //边界判断
            if (i <= 0)
            {
                return 0;
            }
            //第1项和第2项都是1
            else if (i > 0 && i <= 2)
            {
                return 1;
            }
            else
            {
                return fibonacii(i - 1) + fibonacii(i - 2);
            }

        }
    }
}
