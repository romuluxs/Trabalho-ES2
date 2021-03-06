﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginBancoTeste.Models
{
    public class Funcionario
    {
        [Key]
        [Display(Name = "Login")]
        public string Username { get; set; }
        
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}