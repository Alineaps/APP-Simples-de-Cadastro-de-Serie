using System;

namespace DIO.Series2

{
    public class Series : EntidadeBase
    {
       // Atributos
        private Genero Genero {get; set; }
        private string Titulo {get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido{get; set;}

        // Metodos
        public Series(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            // Enviromment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.enviromment.new
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            return retorno;
        }

     public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir() {
            this.Excluido = true;
        }
         public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public bool AtualizarExclusao()
        {
            return this.Excluido = false;
        }
        
    }
}