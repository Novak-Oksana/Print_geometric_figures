using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_geometric_figures
{
    class Program
    {
      
        static void funct_rect_fill()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = 1; x <= k; x++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }
        }
        static void funct_rect_empty()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = 1; x <= k; x++)
                {
                    if (x == 1 || y == 1 || x == k || y == k)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_triangle1()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = 1; x <= k; x++)
                {
                    if (x == 1 || y == k || x == y)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_triangle2()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = 1; x <= k; x++)
                {
                    if (x == k || y == k || x + y == k+1 )
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_triangle3()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = 1; x <= k; x++)
                {
                    if (x == 1 || y == 1 || x + y == k +1)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_triangle4()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = 1; x <= k; x++)
                {
                    if (x == k || y == 1 || x == y)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_cross()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = 1; x <= k; x++)
                {
                    if (x == y || x + y == k + 1)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_triangle5()
        {
            int k = 7;
            for (int y = 1; y <= k / 2 + 1; y++)
            {
                for (int x = 1; x <= k ; x++)
                {
                    if (y==1|| x + y== k + 1 || x == y)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_triangle6()
        {
            int k = 7;
            for (int y = k/2+1; y <= k ; y++)
            {
                for (int x = 1; x <= k; x++)
                {
                    if (y == k  || x +y== k + 1 || x == y)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_triangle7()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = k/2+1; x <= k; x++)
                {
                    if (x == k|| x+ y == k + 1 || x == y)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_triangle8()
        {
            int k = 7;
            for (int y = 1; y <= k; y++)
            {
                for (int x = 1; x <= k/2+1; x++)
                {
                    if (x ==1 || x + y== k + 1 || x == y)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        static void funct_rect_num1()
        {
            int k = 7;
            for (int i = 1; i <= k; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    System.Console.Write(j  + " ");
                }
                System.Console.WriteLine();
            }
        }

        static void funct_rect_num2()
        {
            int k = 7;
            for (int i = 1; i <= k; i++)
            {
                for (int j = k; j >= 1; j--)
                {
                    System.Console.Write(j + " ");
                }
                System.Console.WriteLine();
            }
        }

        static void funct_rect_num3()
        {
            int k = 7;
            for (int i = 1; i <= k; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    System.Console.Write(i  + " ");
                }
                System.Console.WriteLine();
            }
        }

        static void funct_rect_num4()
        {
            int k = 7;
            for (int i = k; i >= 1; i--)
            {
                for (int j = 1; j <= k; j++)
                {
                    System.Console.Write(i + " ");
                }
                System.Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            funct_rect_fill();
            System.Console.WriteLine();
            funct_rect_empty();
            System.Console.WriteLine();
            funct_triangle1();
            System.Console.WriteLine();
            funct_triangle2();
            System.Console.WriteLine();
            funct_triangle3();
            System.Console.WriteLine();
            funct_triangle4();
            System.Console.WriteLine();
            funct_cross();
            System.Console.WriteLine();
            funct_triangle5();
            System.Console.WriteLine();
             funct_triangle6();
            System.Console.WriteLine();
            funct_triangle7();
            System.Console.WriteLine();
            funct_triangle8();
            System.Console.WriteLine();
            funct_rect_num1();
            System.Console.WriteLine();
            funct_rect_num2();
            System.Console.WriteLine();
            funct_rect_num3();
            System.Console.WriteLine();
            funct_rect_num4();
            System.Console.WriteLine();
            System.Console.ReadKey();

        }
    }
}
