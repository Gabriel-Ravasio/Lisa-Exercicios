using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    struct Livro
    {
        public string titulo { get; private set; }
        public string autor { get; private set; }
        public float valor { get; private set; }

        public Livro(string titulo, string autor, float valor) : this()
        {
            this.titulo = titulo;
            this.autor = autor;
            this.valor = valor;
        }
        public string ToString()
        {


            return $"Titulo: { titulo}\n" +
             $"Autor: { autor}\n" +
                $"Valor: { valor}\n";
        }

    }



}
