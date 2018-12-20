using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correctionCondition6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choisissez un mois ");
            string months = Console.ReadLine();
            switch (months)
            {
                case "Mars":
                case "Avril":
                case "Mai":
                    Console.WriteLine("C'est le printemps");
                    break;
                case "Juin":
                case "Juillet":
                case "Aout":
                    Console.WriteLine("C'est l'été");
                    break;
                case "Septembre":
                case "Octobre":
                case "Novembre":
                    Console.WriteLine("C'est l'automne");
                    break;
                case "Décembre":
                case "Janvier":
                case "Février":
                    Console.WriteLine("C'est l'hiver");
                    break;
                default:
                    Console.WriteLine("Ceci n'est pas un mois");
                    break;
            }
            Console.WriteLine("test");
        }
    }
}
