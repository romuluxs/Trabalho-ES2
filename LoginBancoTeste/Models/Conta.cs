using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginBancoTeste.Models
{
    public enum TipoDeConta
    {
        CORRENTE, POUPANCA
    }

    public class Conta
    {   
        [Key]
        public int Numero { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Saldo { get; set; }

        [Required]
        [Display(Name = "Tipo de conta")]
        public TipoDeConta TipoDeConta { get; set; }

        public virtual Cliente Cliente { get; set; }

    }
}