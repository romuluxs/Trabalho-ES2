using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaixaATM.Models
{
    public class Endereco
    {
        public int EnderecoID { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public string Cidade { get; set; }

        public string Numero { get; set; }

        [Required]
        public string Cep { get; set; }

        public string Referencia { get; set; }

        //public virtual Cliente Cliente { get; set; }

    }
}