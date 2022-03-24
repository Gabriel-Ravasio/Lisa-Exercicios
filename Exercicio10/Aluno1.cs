using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Aluno1 : AbstractAluno
    {
        public override int ObterFalta()
        {
            return 2;
        }

        public override string ObterNome()
        {
            return "Cleiton";
        }

        public override int ObterNota()
        {
            return 89;
        }

        public override string ObterRa()
        {
            return "440";
        }
    }
}