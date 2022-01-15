using System;

    public class Pessoa
    {
        public String nomePessoa {get; set;}
        public int idadePessoa {get; set;}
        public int documentoPessoa {get; set;}

        //Cria o método clonando a classe Pessoa
        public Pessoa Clone()
        {
            //Cria uma nova instância de Pessoa
            /*Copiando as propriedades da classe Pessoa para ser usado
            na instância que será chamado o método "Clone"
            */
            return new Pessoa()
            {
                documentoPessoa = this.documentoPessoa,
                idadePessoa = this.idadePessoa,
                nomePessoa = this.nomePessoa
            };     
        }
    }
