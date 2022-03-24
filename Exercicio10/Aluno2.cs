using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Aluno2 : AbstractAluno
    {
        public override int ObterFalta()
        {
            return 5;
        }

        public override string ObterNome()
        {
            return "Josiscleiton";
        }

        public override int ObterNota()
        {
            return 12;
        }

        public override string ObterRa()
        {
            return "110";
        }
    }
}