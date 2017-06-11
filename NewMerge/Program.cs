using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMerge
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] merge1 = new int[2];
            int[] merge2 = new int[2];
            int[] merge3 = new int[2];
            int[] merge4 = new int[2];


            for (int i = 0; i < merge1.Count(); i++)
            {
                merge1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < merge1.Count(); i++)
            {
                merge2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < merge3.Count(); i++)
            {
                merge3[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < merge4.Count(); i++)
            {
                merge4[i] = int.Parse(Console.ReadLine());
            }

            if (merge1[1] >= merge2[0] && merge3[1] >= merge4[0])
            {
                Console.WriteLine("---------------------------");
                int[] merge5 = new int[2];
                merge5[0] = merge1[0];
                merge5[1] = merge2[1];
                for (int i = 0; i < merge5.Count(); i++)
                {
                    Console.WriteLine(merge5[i]);
                }
                int[] merge6 = new int[2];
                merge6[0] = merge3[0];
                merge6[1] = merge4[1];
                for (int i = 0; i < merge6.Count(); i++)
                {
                    Console.WriteLine(merge6[i]);
                }
                if (merge5[1] >= merge6[0])
                {
                    Console.WriteLine("-------------------");
                    int[] merge7 = new int[2];
                    merge7[0] = merge5[0];
                    merge7[1] = merge6[1];
                    for (int i = 0; i < merge7.Count(); i++)
                    {
                        Console.WriteLine(merge7[i]);
                    }
                    if (merge6[1]>=merge7[0])
                    {
                        Console.WriteLine("-------------------");
                        int[] merge8 = new int[2];
                        merge8[0] = merge6[0];
                        merge8[1] = merge7[1];
                    }
                    else
                    {
                        Console.WriteLine("---------------------");
                        Console.WriteLine("-1");
                    }
                }
                else
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-1");
                }
            }
            else if (merge1[1] >= merge2[0])
            {
                Console.WriteLine("---------------------------");
                int[] merge5 = new int[2];
                merge5[0] = merge1[0];
                merge5[1] = merge2[1];
                for (int i = 0; i < merge5.Count(); i++)
                {
                    Console.WriteLine(merge5[i]);
                }
                for (int i = 0; i < merge3.Count(); i++)
                {
                    Console.WriteLine(merge3[i]);
                }
                for (int i = 0; i < merge4.Count(); i++)
                {
                    Console.WriteLine(merge4[i]);
                }
                Console.WriteLine("------------------------");
                Console.WriteLine("-1");
            }
            else if (merge2[1] >= merge3[0])
            {
                Console.WriteLine("---------------------------");
                int[] merge5 = new int[2];
                merge5[0] = merge2[0];
                merge5[1] = merge3[1];
                for (int i = 0; i < merge1.Count(); i++)
                {
                    Console.WriteLine(merge1[i]);
                }
                for (int i = 0; i < merge5.Count(); i++)
                {
                    Console.WriteLine(merge5[i]);
                }
                for (int i = 0; i < merge4.Count(); i++)
                {
                    Console.WriteLine(merge4[i]);
                }
                Console.WriteLine("------------------------");
                Console.WriteLine("-1");
            }
            else if (merge3[1] >= merge4[0])
            {
                Console.WriteLine("---------------------------");
                int[] merge5 = new int[2];
                merge5[0] = merge3[0];
                merge5[1] = merge4[1];
                for (int i = 0; i < merge1.Count(); i++)
                {
                    Console.WriteLine(merge1[i]);
                }
                for (int i = 0; i < merge2.Count(); i++)
                {
                    Console.WriteLine(merge2[i]);
                }
                for (int i = 0; i < merge5.Count(); i++)
                {
                    Console.WriteLine(merge5[i]);
                }
                Console.WriteLine("------------------------");
                Console.WriteLine("-1");
            }

            else
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("-1");
            }


        }
        
    }
}
