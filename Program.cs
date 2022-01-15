using static System.Console;

class Program
{
    //criasse um novo método
    //recebe uma variável de nome Pessoa pessoa1 (pode ser qualquer um, pois ele vai copiar os dados do Main)
    //cria uma varíavel para o novo nome, criando string nomeNovo
    static void TrocarNome(Pessoa pessoa1, string nomeNovo)
    {
        //ao receber o pessoa1, avisa que o atributo nome será o mesmo que nomeNovo
        pessoa1.nomePessoa = nomeNovo;
    }
    public static void Main()
    { 
        //Declara a classe
        //pessoa1 é o objeto criado
        //atribui os valores nos atributos da classe
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nomePessoa = "Carlos";
        pessoa1.idadePessoa = 25;
        pessoa1.documentoPessoa = 5678912;

        //Expemplo1 para criar uma nova referência de pessoa1
        Pessoa pessoa3 = new Pessoa();
        pessoa3.nomePessoa = pessoa1.nomePessoa;
        pessoa3.idadePessoa = pessoa1.idadePessoa;
        pessoa3.documentoPessoa = pessoa1.documentoPessoa;

        //Exemplo2 para criar uma nova referência de pessoa1
        /*Dessa maneira criasse um clone da classe dentro do arquivo da classe, 
        deixando o código mais limpo e mais simples de se gerenciar*/
        Pessoa pessoa4 = pessoa1.Clone();

        //Exemplo de cópias de referências (reference type)
        Pessoa pessoa2 = pessoa1;

        // Chama o método, e dar o novo valor no atributo que será alterado, no caso o nome.
        TrocarNome(pessoa1, "José");

        WriteLine("O novo nome é: " + pessoa1.nomePessoa);
        //quando se coloca $ ocorre a concatenação 
        WriteLine($"O novo nome é: {pessoa1.nomePessoa}");
        //quando se coloca o @ é possível dar enters no texto
        WriteLine($@"
        O nome da pessoa1: {pessoa1.nomePessoa}
        O nome da pessoa2: {pessoa2.nomePessoa}
        O nome da pessoa3: {pessoa3.nomePessoa}
        O nome da pessoa4: {pessoa4.nomePessoa}
        ");
    }
}
