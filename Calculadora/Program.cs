using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 128;
            double n2 = 9;
            Calc calc = new Calc("casio", "fx-20");
            double total = calc.Sumar(n1, n2);
            Console.WriteLine(total);
            double Diferencia = calc.Restar(n1, n2);
            Console.WriteLine(calc);

            Console.ReadLine();
            CalculadoraCientifica cientifica = new CalculadoraCientifica("Samsumg", "CalcR");

            double Raiz = cientifica.Raiz(n1);
            Console.WriteLine(Raiz);
            Console.ReadLine();
        }
        public class Calc

        {
            public Calc()
            {
            }

            public string Marca { get; set; }

            public string Tipo { get; set; }

            public Calc(string marca, string tipo)
            {
                Marca = marca;
                Tipo = tipo;
            }

            public double Sumar(double n1, double n2)
            {
                return n1 + n2;
            }

            public double Restar(double n1, double n2)
            {
                return n1 - n2;
            }

            public double Multiplicar(double n1, double n2)
            {
                return n1 * n2;
            }

            public double Dividir(double n1, double n2)
            {
                if (n2 != 0)
                {
                    return n1 / n2;
                }
                else
                {
                    throw new ArithmeticException("No se puede dividir por cero");
                }
            }

        }
        public class CalculadoraCientifica : Calc
        {
            public CalculadoraCientifica(string v)
            {
            }
            public double Potencia(double n1, double n2)
            {
                return Math.Pow(n1, n2);
            }
            public double Raiz(double n1)
            {
                return Math.Sqrt(n1);
            }
        }
    }
}

