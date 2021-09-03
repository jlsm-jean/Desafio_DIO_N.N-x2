using System;

namespace Desafio_DIO_N.N_x2
{
    class Program
    {
        static void Main(string[] args)
        {
        

            int n = Convert.ToInt32(Console.ReadLine()); 

            for (int linha = 1; linha <= n; linha++)
            {
              Console.WriteLine(linha + " " + (linha * linha) + " " + (linha * linha * linha));

              Console.WriteLine(linha + " " + (linha * linha + 1) + " " + (linha * linha * linha + 1));
            }
           
           

        }

  
    }
}