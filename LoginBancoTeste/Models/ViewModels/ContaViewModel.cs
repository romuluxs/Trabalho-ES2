using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginBancoTeste.Models.ViewModels
{
    public class ContaViewModel
    {
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public TipoDeConta TipoDeConta { get; set; }
        public int? ClienteId { get; set; }
    }
}