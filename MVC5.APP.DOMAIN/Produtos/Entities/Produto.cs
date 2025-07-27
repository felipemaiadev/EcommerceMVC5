namespace MVC5.APP.DOMAIN.Produtos.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; } 
        public double Preco { get; set; }
        public bool Ativo { get; set; }
    }
}
