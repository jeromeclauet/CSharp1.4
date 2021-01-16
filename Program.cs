using System;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dites moi votre nom et votre prénom");

            string v1;
            v1 = Console.ReadLine();
            string v2;
            v2 = Console.ReadLine();

            Console.WriteLine("Bonjour, " + v1 + " " + v2 + ", nous sommes le Vendredi 15 Janvier, comment allez-vous? ");
        }
    }
}
