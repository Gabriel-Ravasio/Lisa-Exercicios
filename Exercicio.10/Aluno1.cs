using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._10
{
    class Aluno1 : AbstractAluno
    {
        public override int ObterFalta()
        {
            return 13;
        }

        public override string ObterNome()
        {
            return "Josiscleiton";
        }

        public override int ObterNota()
        {
            return 19;
        }

        public override string ObterRa()
        {
            return "111";
        }
    }
}