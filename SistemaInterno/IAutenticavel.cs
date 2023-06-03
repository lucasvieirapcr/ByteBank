using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.SistemaInterno
{

    //TENHO QUE IMPLEMENTAR O MÉTODO CONSTRUTOR E A CLASSE ABSTRATA
    //A utilização de interfaces permite a implementação de comportamentos distintos para nossas classes de forma mais flexível. Com uma interface definimos um contrato, uma regra que qualquer classe que a implemente seguirá no momento de estabelecer nossos métodos.
    public interface IAutenticavel //O "I"  SIGNIFICA INTERFACE 
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha);

    }
}
