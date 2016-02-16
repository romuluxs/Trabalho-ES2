using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginBancoTeste.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Logadouro")]
        public string Rua { get; set; }

        [Required]
        public string Cidade { get; set; }

        public string Numero { get; set; }

        [Required]
        [Display(Name = "CEP")]
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }

        //public virtual Cliente Cliente { get; set; }
    }
}