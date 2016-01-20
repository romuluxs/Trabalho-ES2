using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaixaATM.Models
{
    // flag para ajudar a decidir que tipo de conta estamos lidando
    public enum TipoDeCliente
    {
        PESSOA_FISCA, PESSOA_JURIDICA
    }

    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }

        public TipoDeCliente TipoDeCliente { get; set; }

        //lista de contas que o cliente tem
        public virtual List<Conta> Contas { get; set; }
    }
}