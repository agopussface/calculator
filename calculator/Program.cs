using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cyril Narducci
             * Stage 2 - Papp
             * Calculette console +, -, *, /
             * 10/2023
             */

            // Déclaration des variables
            int n1;         // Numéro 1 de l'user
            int n2;         // Numéro 2 de l'user
            string op;      // Opérateur
            int error = 0;  // Gestion des erreurs

            while (true)
            {
                Console.Clear();

                // Titre
                Console.WriteLine("Calculator 3000");
                Console.WriteLine("---------------");
                Console.WriteLine();

                // Numéro 1
                Console.Write("Premier chiffre: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                // Numéro 2
                Console.Write("Second chiffre: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                // Opérateur
                Console.WriteLine("Que voulez vous faire ?");
                Console.WriteLine("Add(+) Sous(-) Mult(*) Div(/)");

                do
                {
                    op = Console.ReadLine();        // Stockage de la réponse de l'user dans la variable op

                    switch (op)
                    {
                        case "+":
                            Console.WriteLine(Add(n1, n2));
                            error = 0;
                            break;

                        case "-":
                            Console.WriteLine(Sous(n1, n2));
                            error = 0;
                            break;

                        case "*":
                            Console.WriteLine(Mult(n1, n2));
                            error = 0;
                            break;

                        case "/":
                            Console.WriteLine(Div(n1, n2));
                            error = 0;
                            break;

                        default:
                            Console.WriteLine("Mauvaise entrée");
                            error++;
                            break;
                    }
                }
                while (error > 0);

                Console.ReadLine();
            }
        }

        // Déclaration des méthodes 
        public static int Add(int n1, int n2)       // Addition
        {
            int result = n1 + n2;
            return result;
        }

        public static int Sous(int n1, int n2)      // Soustration
        {
            int result = n1 - n2;
            return result;
        }

        public static int Mult(int n1, int n2)      // Multiplication
        {
            int result = n1 * n2;
            return result;
        }

        public static int Div(int n1, int n2)       // Division
        {
            int result = n1 / n2;
            return result;
        }
    }
}
