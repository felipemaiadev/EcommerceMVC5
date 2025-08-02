using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MAIA.OOP
{
    public class Pedido : Entidade
    {
        public int IdVendedor { get; private set; }
        public string NomeVendedor { get; private set; }
        public int IdCliente { get; private set; }
        public string NomeCliente { get; private set; }
        public double ValorPedido { get; private set; }

        // Receber o Lazy Load (Carregamento Atrasado)
        public virtual ICollection<PedidoItem> Items { get; set; }


        public Pedido() : base("")
        {

        }
        public Pedido(int idVendedor,
                      string nomeVendedor,
                      int idCliente,
                      string nomeCliente,
                      double valorPedido,
                      ICollection<PedidoItem> itens,
                      string categoria) : base(categoria)
        {
            SetIdVendedor(idVendedor);
            SetNomeVendedor(nomeVendedor);
            SetIdCliente(idCliente);
            SetNomeCliente(nomeCliente);
            SetItensPedido(itens);
        }

        private void SetIdVendedor(int idVendedor)
        {
            // Regras de Negocio | Validações | Teste Unitários
            if (idVendedor == 0) throw new ArgumentException("O Id do vendedor deve ser maior que zero");
            IdVendedor = idVendedor;
        }

        private void SetNomeVendedor(string nomeVendedor)
        {
            if (!string.IsNullOrEmpty(nomeVendedor)) throw new ArgumentException("Deve ser Informado um ome para o Vendedor");
            NomeCliente = nomeVendedor;
        }

        private void SetIdCliente(int idCliente)
        {
            if (idCliente == 0) throw new ArgumentException("O Id do vendedor deve ser maior que zero");
            IdCliente = idCliente;
        }

        private void SetNomeCliente(string nomeCliente)
        {
            if (!string.IsNullOrEmpty(nomeCliente)) throw new ArgumentException("Deve ser Informado um ome para o Vendedor");
            NomeCliente = nomeCliente;
        }

        private void SetItensPedido(ICollection<PedidoItem> itens)
        {

            if (itens == null || itens.Count() == 0) throw new ArgumentNullException("Devem haver itens no Pedido");
            this.Items = itens;

        }




    }
}
