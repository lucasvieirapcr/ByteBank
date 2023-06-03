﻿using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Parceria
{
    //ELE ESTÁ ASSINANDO CONTRATO COM O AUTENTICAVEL
    public class ParceiroComercial:IAutenticavel
    {

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
