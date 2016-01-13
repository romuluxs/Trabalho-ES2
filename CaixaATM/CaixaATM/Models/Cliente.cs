using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaixaATM.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }

        public int ContaId { get; set; }
        public virtual List<Conta> Contas { get; set; }
    }
}