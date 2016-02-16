namespace LoginBancoTeste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNumeroType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contas");
            AlterColumn("dbo.Contas", "Numero", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Contas", "Numero");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Contas");
            AlterColumn("dbo.Contas", "Numero", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Contas", "Numero");
        }
    }
}
