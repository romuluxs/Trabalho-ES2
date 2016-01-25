using CaixaATM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CaixaATM.DAL
{
    public class CaixaATMDBContext : DbContext
    {
        public CaixaATMDBContext() : base("CaixaATMDBContext") 
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}