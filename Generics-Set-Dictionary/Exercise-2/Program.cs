﻿using System;
using System.Collections.Generic;


namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Aluno> hash = new HashSet<Aluno>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            GetStudentData(n, 'A', ref hash);

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            GetStudentData(n, 'B', ref hash);

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            GetStudentData(n, 'C', ref hash);

            Console.WriteLine("Total students: " + hash.Count);
        }

        static void GetStudentData(int n, char curso, ref HashSet<Aluno> hash)
        {
            int ra;
            for (int i = 0; i < n; i++)
            {
                ra = int.Parse(Console.ReadLine());
                hash.Add(new Aluno { RA = ra, Curso = curso });
            }
        }
    }
}
