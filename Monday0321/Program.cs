using System;

namespace Monday0321
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnum = new Random();
            int ans = rnum.Next(1, 100);
            Console.Write("猜數字範圍1~100\n");
            for (int i=5; i>0; i--)
            {
                Console.Write("輸入數字(剩下"+i+"次)\n");
                int g = int.Parse(Console.ReadLine());
                int r = 1;
                if (g == ans)
                {
                    Console.Write("答對\n");
                    Console.Write("猜了"+ r + "次\n");
                    break;
                }
                else
                {
                    if ((g > ans)&(g<100)) 
                    {
                        Console.Write("1~"+g+ "之間\n");
                    }
                    else if((g < ans) & (g >0))
                    {
                        Console.Write( g + "~100之間\n");
                    }
                    else if (g<0)
                    {
                        Console.Write("超出範圍1~100之間\n");
                    }
                    else if (g > 100)
                    {
                        Console.Write("超出範圍1~100之間\n");
                    }
                }
                r++;
            }
            Console.Write("遊戲結束答案是"+ans);
        }
    }
}
