namespace MVC5.APP.INFRA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cpf = c.String(nullable: false),
                        Endereco = c.String(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Warehouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SKU = c.String(nullable: false),
                        Descricao = c.String(nullable: false),
                        Fabricante = c.String(),
                        Preco = c.Double(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Warehouse");
            DropTable("dbo.Customers");
        }
    }
}
