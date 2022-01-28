using static System.Console;

using System.Collections.Generic;

class Program
{   
    //Método para achar o numero dentro do array
    static int EncontraNumero(int[] numeros, int numero){
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
            return i;
        }
        return -1;
    }
    static void Demo5(){
        //Crio o array que guarda os valores
        int[] numeros = new int[]{0,2,4,6,8,10};

        WriteLine("Digite o numero a ser encontrado.");
        //Solicito e leio o valor do usuário. Ainda converto de string para int usando "int.Parse"
        var numero = int.Parse((ReadLine()));
        var idxNumeroEncontrado = EncontraNumero(numeros, numero);

        //Condição para o retorno da solicitação do Usuário
        if( idxNumeroEncontrado >= 0)
        {
            WriteLine($"O número encontrado está na posição: {idxNumeroEncontrado}");
        }
        else
        { 
            WriteLine("O número não faz parte da array.");
        }
    }
    
    //Método para adicionar +1 em cada valor dentro do array, transfomando-os assim pares em ímpares
    static void MudarParaImpar(int[] pares){
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }
    static void Demo4(){
        //Criando um array
        int[] pares = new int[]{0,2,4,6,8};

        MudarParaImpar(pares);

        //{string.join(",", array)} <<<< Comando para mostrar os valores do array no Write.
        WriteLine($"Os ímpares {string.Join(",", pares)}");
    }

     //Criar variável tipo string, e criar um método que altere o valor no terminal
    static void Demo3(){
        //Criei a variável com um valor
        string nome = "João";
        
        WriteLine($@"O nome registrado atual é: {nome}
        Qual nome você deseja registrar?");
        //indico que a variável vai herdar o valor digitado pelo usuário
        nome = ReadLine();

        WriteLine($"O nome registrado agora é: {nome}");
    }

    /*Criando o novo metodo de Trocar Nome usando as struck
    O método TrocarNomeStruckt não pode ser void, pois ele está mudando o nome de uma cópia
    Sua funcionalidade fica nula sendo void. Ele tem que retornar uma Struct para conseguir com 
    que a Struct entenda como novo parâmetro, e não uma cópia.  
    */
    static StructPessoa TrocarNomeStruck(StructPessoa pessoa1, string nomeNovo)
    {
        pessoa1.nomePessoa = nomeNovo;
        return pessoa1;
    }
    static void Demo2()
    {
    //Usando Struct 

        StructPessoa pessoa1 = new StructPessoa
        {
            documentoPessoa = 1234,
            nomePessoa = "João",
            idadePessoa = 24
        };

        var pessoa2 = pessoa1;

        //Para haver a alteração, tenho que informar qual variável deve receber a mudança
        pessoa1 = TrocarNomeStruck(pessoa1, "Pedro");

        WriteLine($@"
        O nome da pessoa 1 é : {pessoa1.nomePessoa}
        O nome da pessoa 2 é : {pessoa2.nomePessoa}
        ");
    }
    
    /* ##################################################################################### */

    //criasse um novo método
    //recebe uma variável de nome Pessoa pessoa1 (pode ser qualquer um, pois ele vai copiar os dados do Main)
    //cria uma varíavel para o novo nome, criando string nomeNovo
    static void TrocarNome(Pessoa pessoa1, string nomeNovo)
    {
        //ao receber o pessoa1, avisa que o atributo nome será o mesmo que nomeNovo
        pessoa1.nomePessoa = nomeNovo;
    }
    static void Demo1()
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
    
    static bool LocalizaPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if (item.nomePessoa == pessoa.nomePessoa)
            {
                return true;
            }
            
        }
        return false;
    }
    
    public static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){nomePessoa = "Pedro"},
            new Pessoa(){nomePessoa = "João"},
            new Pessoa(){nomePessoa = "Maria"},
            new Pessoa(){nomePessoa = "Fátima"},
            new Pessoa(){nomePessoa = "Cícero"}
        };

        WriteLine("Digite o nome da pessoa a ser localizada: ");
        var nome = ReadLine();   
        var pessoa = new Pessoa{nomePessoa = nome};
        var encontrado = LocalizaPessoa(pessoas,pessoa);

        if(encontrado)
        {
            WriteLine("Pessoa localizada!");
        }
        else 
        {
            WriteLine("Pessoa não localizada!");
        }
    }
}


    
    
    
    

