namespace MVC5.APP.INFRA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relacionamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SKU = c.String(),
                        Fabricante = c.String(),
                        Valor = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        IdPedido = c.Int(nullable: false),
                        Criacao = c.DateTime(nullable: false),
                        Categoria = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.IdPedido, cascadeDelete: true)
                .Index(t => t.IdPedido);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdVendedor = c.Int(nullable: false),
                        NomeVendedor = c.String(),
                        IdCliente = c.Int(nullable: false),
                        NomeCliente = c.String(),
                        ValorPedido = c.Double(nullable: false),
                        Criacao = c.DateTime(nullable: false),
                        Categoria = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItens", "IdPedido", "dbo.Orders");
            DropIndex("dbo.OrderItens", new[] { "IdPedido" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderItens");
        }
    }
}
