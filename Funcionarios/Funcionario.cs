using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    //ABSTRACT = É UMA CLASSE ABSTRATA, UMA IDEIA PARA CRIACAO DE OBJETO, PORTANTO ELA NÃO PODE SER CRIADA
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf  { get; private set; }    //PROTEGENDO O CPF
        public double Salario { get; protected set; }   //ELE FICA PROTEGIDO E SÓ FICA VISIVEL NA PROPRIA CLASSE E AS QUE HERDAM DELA

        //STATIC = Propriedade da classe e não do objeto
        public static int TotalDeFuncionarios { get; private set; }

        //COMO A CLASSE VIROU ABSTRATA, ENTAO TODA A CLASSE QUE HERDAR ESSES METODOS, TEM A OBRIGACAO DE IMPLEMENTAR
        public abstract double GetBonificacao();
        

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;  //SEMPRE QUE CRIAR UM FUNCIONARIO ELE VAI CONTAR
            //Console.WriteLine("Criando um funcionário");
        }

        //PARA PERMITIR QUE O METODO SEJA REESCRITO = VIRTUAL
        //POREM
        //COMO A CLASSE VIROU ABSTRATA, ENTAO TODA A CLASSE QUE HERDAR ESSES METODOS, TEM A OBRIGACAO DE IMPLEMENTAR
        public abstract void AumentarSalario();

        
    }
}
