using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBank_ADM.Funcionarios;

namespace byteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }  //EU RPIVEI ELE PARA QUE NÃO PUDESSE SER ALTERADO


        //CRIANDO A SOBRECARGA DE MÉTODO
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

        /*REMOVI POR CONTA DA HERANÇA
         * public void Registrar(Diretor diretor)
        {
            this.TotalDeBonificacao += diretor.GetBonificacao();
        }*/
    }
}
