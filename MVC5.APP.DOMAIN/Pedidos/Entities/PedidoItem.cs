namespace MAIA.OOP
{
    public class PedidoItem : Entidade
    {
        public string SKU { get; set; }
        public string Fabricante { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        // Ser Chave Estrangeira
        public int IdPedido { get; set; }

        // Receber o Lazy Load (Carregamento Atrasado)
        public virtual Pedido Pedido { get; set; }

        public PedidoItem() : base("")
        {
            
        }

        public PedidoItem(string categoria) : base(categoria)
        {

        }
    }
}
