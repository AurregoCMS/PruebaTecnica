
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace InfoSystem
{
    public class AgentA
    {
        public double GetMedia(List<double> numbers)
        {
            return numbers.Average();
        }
    }

    public class AgentB
    {
        public double GetMedia(List<double> numbers)
        {
            return numbers.Count / numbers.Sum(x => 1 / Math.Pow(x, 2));
        }
    }

    public class AgentC
    {
        public double GetMedia(List<double> numbers)
        {
            numbers.Sort();
            int n = numbers.Count;

            if (n % 2 == 0)
            {
                return (numbers[n / 2 - 1] + numbers[n / 2]) / 2;
            }
            else
            {
                return numbers[n / 2];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AgentA agentA = new AgentA();
            AgentB agentB = new AgentB();
            AgentC agentC = new AgentC();

            List<double> numbers = new List<double>();

            Console.WriteLine("Introduzca el número de elementos a considerar (entre 1 y 100): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduzca el elemento {i + 1}: ");
                numbers.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Media aritmética (AgenA): " + agentA.GetMedia(numbers));
            Console.WriteLine("Media armónica (AgentB): " + agentB.GetMedia(numbers));
            Console.WriteLine("Mediana (AgentC): " + agentC.GetMedia(numbers));

            int staircaseN;
       do
       {
           Console.WriteLine("Introduce el tamaño de la escalera (entre 1 y 100):");
    staircaseN = Convert.ToInt32(Console.ReadLine());

    if (staircaseN > 100 || staircaseN < 1 )
    {
        Console.WriteLine("El tamaño de la escalera debe estar entre 1 y 100.");
    }
}     while (staircaseN > 100 || staircaseN < 1);

            string staircaseA = GetStaircaseA(staircaseN);
            string staircaseB = GetStaircaseB(staircaseN);
            string staircaseC = GetStaircaseC(staircaseN);

            Console.WriteLine("Escalera A:");
            Console.WriteLine(staircaseA);

            Console.WriteLine("Escalera B:");
            Console.WriteLine(staircaseB);

            Console.WriteLine("Escalera C:");
            Console.WriteLine(staircaseC);
        }

        static string GetStaircaseA(int n)
        {

            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += new string(' ', n - i - 1);
                result += new string('#', i + 1);
                result += "\n";
            }
            return result;
        }

        static string GetStaircaseB(int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += new string(' ', i);
                result += new string('#', n - i);
                result += "\n";
            }
            return result;
        }

     public static string GetStaircaseC(int n)
{
      string result = "";
    
     for (int i = 1; i <= n; i++)
    {
        result += new string(' ', n - i);
        result += new string('#', i * 2 - 1);
        result += "\n";
    }

    for (int i = n - 1; i >= 1; i--)
    {
        result += new string(' ', n - i);
        result += new string('#', i * 2 - 1);
        result += "\n";
    }


    return result;
    }
    }
    }

