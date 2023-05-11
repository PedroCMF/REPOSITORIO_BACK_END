using FS19_UC12_CLASSES.CLASSES;

class Program  //classe Program principal onde começa a tudo, comesça a rodar o codigo e chamar os outros
{
    static void Main(string[] args) //Metodo principal. se digitar. svm cria o metodo automatico
    {
        //=================CODIGO DA CLASSE QUANDO NAO É ABSTRATA============================
        //da o ctrl para reconhecer a classe pessoa
      //Pessoa novaPessoa = new Pessoa(); //instancia a classe pessoa
       //novaPessoa.nome = "Pedro Celestino";
      // Console.WriteLine(novaPessoa.nome); //chama o atributo da classe pessoa
      //======================================================================================
      
      //==========Usando classe abstrata instacia somente as classes filhas
      PessoaJuridica novaPessoa = new PessoaJuridica(); //devido a classe pai Pessoa ser abstrata entao instacia a classe filha pessoaJuridica
      novaPessoa.nome = "Pedro Celestino";
      
      Console.WriteLine(novaPessoa.nome);
      
      
    }

}
