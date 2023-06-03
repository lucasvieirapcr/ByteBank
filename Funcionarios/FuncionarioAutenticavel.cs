using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    //HERDANDO DE FUNCIONARIO E IMPLEMENTANDO A INTERFACE DE AUTENTICAVEL
    //A INTERFACE PODE FUNCIONAR COMO HERANÇA MULTIPLA
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        //ADICIONANDO A CONSTRUTOR
        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
