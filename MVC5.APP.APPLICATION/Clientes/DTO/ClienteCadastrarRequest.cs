using System.ComponentModel.DataAnnotations;

namespace MVC5.APP.APPLICATION.Clientes.ViewModel
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

        public string Endereco { get; set; }

    }
}
