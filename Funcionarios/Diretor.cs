using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    //DIRETOR:fUNCIONARIO = FUNCIONARIO É SUPERCLASSE E O DIRETOR VAI HERDAR DE FUNCIONARIO
    
    //ELE VAI HERDAR DE FUNCIONARIO E IMPLEMENTAR AUTENTICAVEL
    public class Diretor : FuncionarioAutenticavel
    {
        //IMPLEMENTANDO A INTERFACE (SOU OBRIGADO)

        /*public string Nome { get; set; }
public string Cpf { get; set; }
public double Salario { get; set; }*/

        //ESSE METODO É UMA REESCRITA DO QUE ESTÁ ESCRITO EM FUNCIONARIO
        public override double GetBonificacao()
        {
            //BASE = VAI DAR ACESSO AO METODO DA CLASSE QUE ESTOU HERDANDO
            return this.Salario * 2.10;
        }

        //O BASE VAI PEGAR DA CLASSE FUNCIONÁRIO O CPF É COLOCAR COMO OBRIGATORIO
        public Diretor(string cpf):base(cpf, 5000)    
        {
            //Console.WriteLine("Criando um Diretor");
        }

        //SOBRESCREVENDO O SALARIO DE FUNCIONARIO
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
