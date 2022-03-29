using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf) :base(salario, cpf)
        {

        }
        public override void AumentarSalario()
        {
            //throw new NotImplementedException();
        }
        protected override double GetBonificacao() //aqui não usamos o internal, pq ele se tornaria visivel para o sistema e não queremos isso, GetBonificacao é visivel apenas para as classes devrivadas
        {
            throw new NotImplementedException();
        }
    }
}
