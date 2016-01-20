using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CaixaATM.Models
{
    public class CaixaATMDBContext : DbContext
    {
        public CaixaATMDBContext() : base("CaixaATMDBContext") 
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }

    }
}