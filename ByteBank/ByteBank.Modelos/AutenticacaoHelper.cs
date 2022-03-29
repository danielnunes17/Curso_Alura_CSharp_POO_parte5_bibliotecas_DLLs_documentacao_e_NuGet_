using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class AutenticacaoHelper //Modificador de acesso Internal significa que essa classe possui um comportamento interno a nossa biblioteca, classes e membros intenos não são visiveis para quem está fora do escopo da biblioteca, isso vai dar uma segurança para que não haja quebra de projetos ao depdender dessa classe. Quando não há modificador de acesso explicito, o compilador entende que ela é internal por default
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
