using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcenalAnuidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anuidade: ");
            double anu = double.Parse(Console.ReadLine());
            double mens = anu / 12;
            Console.WriteLine("Matricula: ");
            double matri = double.Parse(Console.ReadLine());
            Console.WriteLine("Material: ");
            double mat = double.Parse(Console.ReadLine());
            int cont = 1;
            while (cont <= 12)
            {
                if (cont == 1)
                    Console.WriteLine("Mensalidade" + cont + "valor: " + (mens + matri + mat).ToString("C"));
                else 
                    Console.WriteLine("Mensalidade: " + cont + "Valor: " + (mens).ToString("C"));
                cont++;
            }
            Console.ReadKey();
        }
    }
}
