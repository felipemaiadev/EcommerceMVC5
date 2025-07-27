namespace MVC5.APP.DOMAIN.Clientes.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public bool Ativo { get; set; }

    }
}
