using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIfs.Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite o numero para obter seu fatorial ");
            numero = int.Parse(Console.ReadLine());


            //usei para testar o gitHub5
            Console.Write("Testando o GITHUB5");

            Program p = new Program();
            Console.WriteLine("O fatorial é : {0}", p.fatorial(numero));

            Console.ReadKey();

            //usei para testar o gitHub
            Console.Write("Testando o GITHUB");

            //usei para testar o gitHub2
            Console.Write("Testando o GITHUB2");
            //usei para testar o gitHub3
            Console.Write("Testando o GITHUB4");

        }
        public int fatorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * fatorial(num - 1);
            }
        }
    }
}
