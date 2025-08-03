using System.ComponentModel.DataAnnotations;

namespace MVC5.APP.APPLICATION.Clientes.DTO
{
    public class ClienteCadastrarRequest
    {

        // ID Sera gerado no BD

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(11)]
        public string Cpf { get; set; }
        
        [Required]
        public string Endereco { get; set; }

    }
}
