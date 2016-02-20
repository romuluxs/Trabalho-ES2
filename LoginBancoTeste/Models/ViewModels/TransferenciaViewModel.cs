using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginBancoTeste.Models.ViewModels
{
    public class TransferenciaViewModel
    {
        // numero da conta 
        public int? NumeroConta { get; set; }

        // numero da conta do destinatário
        [Required]
        [Display(Name = "conta destino")]
        public int? NumeroContaDestino { get; set; }

        // valor a ser transferio de uma conta para outra
        [Required]
        public double? Valor { get; set; }
    }
}