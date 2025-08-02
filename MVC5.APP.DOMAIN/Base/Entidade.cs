using System;

namespace MAIA.OOP
{
    // Classe abstrata não pode ser instâciada somente herdada
    public abstract class Entidade
    {
        public int Id { get; set; }
        public DateTime Criacao { get; set; }

        public string Categoria { get; set; }

        public Entidade(string categoria) 
        {
            SetDateTimeCriacao();
            SetCategoria(categoria);
        }


        private DateTime SetDateTimeCriacao()
        {
            return DateTime.Now;
        }

        private void SetCategoria(string categoria)
        {
            this.Categoria = categoria;
        }
    }
}
