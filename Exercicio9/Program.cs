using System;

namespace Exercicio9
{


    class Program
    {
        static void Main(string[] args)
        {

            var livro = new Livro("as Aventuras de Josiscleiton", "Cleiton", 10.59f);
         

            Console.WriteLine(livro.ToString());

            Console.ReadLine();
        }

      


    }
}
