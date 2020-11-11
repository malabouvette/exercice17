using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice17
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            int number;
            double numberSqrt;

            // invitaion saisie nombre
            Console.Write("Saisir un nombre = ");
            number = int.Parse(Console.ReadLine());

            // invitatiaon saisie racine carrée
            Console.Write("Saisir la racine carrée du nombre saisi = ");
            numberSqrt = double.Parse(Console.ReadLine());

            if (numberSqrt == Math.Sqrt(number))
            {
                Console.WriteLine("Bravo !");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Erreur, la racine carrée de " + number + " est " + Math.Sqrt(number));
                Console.ReadLine();
            }
        }
    }
}
