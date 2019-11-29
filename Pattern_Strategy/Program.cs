using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pattern_Strategy
{



    class Program
    {
        public static Random r = new Random();
        public static List<Line> Paint2()
        {
            List<Line> A = new List<Line>();
            LineEnd[] ends = new LineEnd[2];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < ends.Length; j++)
                {
                    switch (r.Next(0, 3))
                    {
                        case 0:
                            ends[j] = new VoidLine();
                            break;
                        case 1:
                            ends[j] = new LineArrow();
                            break;
                        case 2:
                            ends[j] = new LineRomb();
                            break;
                        default: ends[j] = new VoidLine(); break;
                    }
                }

                Line B = new Line(ends[0], ends[1]);
                A.Add(B);
            }
            return A;
        }
        public static void Paint()
        {
            List<Line> A = new List<Line>();
            LineEnd[] ends = new LineEnd[2];
            
            for (int i = 0; i < 8; i++)
            {

                LineEnd start, end;
                switch (r.Next(0, 3))
                {
                    case 0:
                        start = new VoidLine();
                        break;
                    case 1:
                        start = new LineArrow();
                        break;
                    case 2:
                        start = new LineRomb();
                        break;
                    default: start = new VoidLine(); break;
                }
                switch (r.Next(0, 3))
                {
                    case 0:
                        end = new VoidLine();
                        break;
                    case 1:
                        end = new LineArrow();
                        break;
                    case 2:
                        end = new LineRomb();
                        break;
                    default: end = new VoidLine(); break;
                }
                Line B = new Line(start, end);
                A.Add(B);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < A.Count; i++)
            {
                Console.Write("Линия №{0}\n", i + 1);
                Console.Write(A[i].PrintLine());
            }
            Console.WriteLine("OK");
        }

        static void Main(string[] args)
        {
            List<Line> A = Paint2();
            Console.WriteLine("\n");
            for (int i = 0; i < A.Count; i++)
            {
                Console.Write("Линия №{0}\n", i + 1);
                Console.Write(A[i].PrintLine());
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}

