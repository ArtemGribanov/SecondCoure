﻿
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"D:\GIT-Repository\SecondCoure\ACTOS\OS\source.txt";

            double A, B, S = 0;

            //string[] cou = args[0].Split('.');
            A = double.Parse("1");
            B = double.Parse("3");

            //File.Delete(path);

            for (int i = 1; i <= B; i++)
            {
                S += Math.Sqrt(A)*i;
            }

            string res = Convert.ToString(S);
            Console.WriteLine(res);
            Process.Start(@"D:\GIT-Repository\SecondCoure\ACTOS\OS\lab1.2\lab1.2\bin\Debug\net6.0\lab1.2.exe", res);

        }
    }
}