using System.ComponentModel.DataAnnotations;

namespace MVC5.APP.APPLICATION.Produtos.DTO
{
    public class ProdutoCadastrarRequest
    {
        [Required]
        public string SKU { get; set; }

        [Required]
        [MaxLength(150)]
        public string Descricao { get; set; }
        
        public string Fabricante { get; set; }
        
        public double Preco { get; set; }
    }
}
