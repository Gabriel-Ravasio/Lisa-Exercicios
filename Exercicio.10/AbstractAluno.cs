using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._10
{
    public abstract class AbstractAluno
    {
        public abstract string ObterNome();

        public abstract string ObterRa();

        public abstract int ObterNota();

        public abstract int ObterFalta();

        public string Frequencia()
        {
            int freq = ObterFalta();
            if (freq <= 10)
            {
                return $"Você teve {ObterFalta()} de faltas, logo foi APROVADO.";
            }
            else
            {
                return $"Você teve {ObterFalta()} de faltas, logo foi REPROVADO.";
            }
        }
        public string NotasMedia()
        {
            int nota = ObterNota();
            if (nota >= 70)
            {
                return $"Media: {ObterNota()}, Resultado: APROVADO.";
            }
            else
            {
                return $"Média: {ObterNota()}, Resultado: REPROVADO.";
            }
        }

        public virtual string ImprimirDados()
        {
            return $"Nome: {ObterNome()} RA: {ObterRa()} \n" +
                $"{Frequencia()} \n" +
                $"{NotasMedia()} \n";
        }
    }
}