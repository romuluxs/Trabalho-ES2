namespace LoginBancoTeste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        Numero = c.String(nullable: false, maxLength: 128),
                        Saldo = c.Double(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Numero)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contas", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Contas", new[] { "Cliente_Id" });
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Contas");
            DropTable("dbo.Clientes");
        }
    }
}
