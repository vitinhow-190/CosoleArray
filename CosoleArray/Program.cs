using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] mes = { "sim", "Janeiro", "Fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };

            Console.WriteLine("Digite um numero de 1 a 12: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("O nome selecionado foi: " + mes[i]);

            Console.ReadKey();


        }
    }
}
