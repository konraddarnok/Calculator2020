using System;
using System.Reflection;

namespace Calculator2020
{
    public class Calculator
    {
        private double vala;

        private double valb;


        public double add (double vala, double valb)
        {
            return vala + valb;
        }

        public double subtrackt(double vala, double valb)
        {
            return vala - valb;
        }

        public double devide(double vala, double valb)
        {
            return vala / valb;
        }
        public double multipli(double vala, double valb)
        {
            return vala * valb;
        }

        public override string ToString()
        {
            Console.WriteLine($"{vala} + {valb}");
        }
    }
}
