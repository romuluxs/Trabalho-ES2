using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaixaATM.Models
{
    public class Conta
    {
        
        public int ContaID { get; set; }
        public double Saldo { get; set; }
        public double SaldoProv { get; set; } //Saldo provisório

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}