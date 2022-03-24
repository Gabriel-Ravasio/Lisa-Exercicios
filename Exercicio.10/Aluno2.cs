using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._10
{
    class Aluno2 : AbstractAluno
    {
        public override int ObterFalta()
        {
            return 1;
        }

        public override string ObterNome()
        {
            return "Rogerinho";
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