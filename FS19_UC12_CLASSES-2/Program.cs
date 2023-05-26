using FS19_UC12_CLASSES.CLASSES;
using FS19_UC12_CLASSES_2.CLASSES;

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
      //PessoaJuridica novaPessoa = new PessoaJuridica(); //devido a classe pai Pessoa ser abstrata entao instacia a classe filha pessoaJuridica
      //novaPessoa.nome = "Pedro Celestino";
      
      //Console.WriteLine(novaPessoa.nome);
      /// <summary>
      
     
      /// </summary>
      /// <returns></returns>
      
       //=======================PARA PESSO FISICA================================================================
     
      Endereco end = new Endereco();//instancia a classe endereco 
      end.Complemento = "Proximo ao Senai"; //chama os atributos que estao na classe endereço
      end.enderecoComercial = false;
      end.lagradouro = "Rua X";
      end.numero = 100;

      PessoaFisica novaPessoa = new PessoaFisica();  //instancia a classe PessoaFisica
      novaPessoa.nome = "Pedro"; //chama os atributos da classe pessoafisica
      novaPessoa.cpf = "12345678";
      novaPessoa.dataNascimento = new DateTime(1994, 05, 19); //quando usa datas coloca do DateTime como se estivesse instaciando
      novaPessoa.endereco = end;  //chama os atributos da classe endereço na instancia da classe PessoaFisica
      
      PessoaFisica Natalia = new PessoaFisica();
      Natalia.nome = "Natalia Adena";

      Endereco endepedro = new Endereco(); 
      endepedro.lagradouro = "Rua Eulalia";
      endepedro.enderecoComercial = true;

      PessoaFisica Pedro = new PessoaFisica();
      Pedro.nome="Pedro Celestino";
      Pedro.endereco = endepedro; //chama os atributos da classe endereço na instancia da classe PessoaFisica

      Console.WriteLine(novaPessoa.nome);  
      Console.WriteLine(novaPessoa.cpf);
      Console.WriteLine(novaPessoa.dataNascimento);
      Console.WriteLine(novaPessoa.endereco.lagradouro); //pessoa fisica pega o endereço herdado da classe pessoa
      Console.WriteLine(end.Complemento);
      Console.WriteLine(novaPessoa.endereco.numero);
      Console.WriteLine(novaPessoa.endereco.Complemento);

      Console.WriteLine(Pedro.nome);
      Console.WriteLine(Natalia.nome);
      Console.WriteLine(Pedro.endereco.lagradouro);
      Console.WriteLine(Pedro.endereco.enderecoComercial);


      //CONCATENAÇÃO
      Console.WriteLine("A pessoa :" + novaPessoa.nome  + " Número :" + novaPessoa.endereco.numero + " Mora no endereço :" + novaPessoa.endereco.lagradouro + " Com CPF :" + novaPessoa.cpf + "com data de nacimento :" +  novaPessoa.dataNascimento);

      //INTERPOLAÇÃO
      Console.WriteLine($"{novaPessoa.nome} Mora na {novaPessoa.endereco.lagradouro} numero {novaPessoa.endereco.numero} com cpf {novaPessoa.cpf} Data de Nacimento {novaPessoa.dataNascimento}");
     
     //----------------------------PARA VALIDAR A DATA DE NACIMENTO-----------------------------------------------------
     Console.WriteLine(novaPessoa.validarDataNacimento(novaPessoa.dataNascimento));

     bool idadevalida = (novaPessoa.validarDataNacimento(novaPessoa.dataNascimento));

      if (idadevalida == true)
      
      {

       Console.WriteLine("Cadastro Aprovado");
        
      }

       else

      {
        Console.WriteLine("Cadastro Reprovada por motivo de idade");
      }

     //=============================PARA PESSOA JURIDICA E VALIDAR CNPJ=============================================
        
      Endereco endpj = new Endereco();//instancia a classe endereco 
      endpj.Complemento = "Proximo ao Senai"; //chama os atributos que estao na classe endereço
      endpj.enderecoComercial = false;
      endpj.lagradouro = "Rua X";
      endpj.numero = 100;
      endpj.referencia = "batalhao da policia";

      PessoaJuridica PJ = new PessoaJuridica(); //Instancia a pessoa Juridica
      PJ.endereco = endpj; //chama os atributos da classe endereço na instancia da classe PessoaJuridica
      PJ.cnpj= "12345678000001";
      PJ.razaoSocial = "Bar do Pedro";
      PJ.inscricaoEstadual = "1111111111111111";
      
         Console.WriteLine(PJ.razaoSocial);
         Console.WriteLine(PJ.endereco.numero);
         Console.WriteLine(PJ.endereco.referencia);
         Console.WriteLine(PJ.inscricaoEstadual);


        //----------------------------------VALIDA CNPJ------------------------------------------------
        if (PJ.ValidaCNPJ(PJ.cnpj) == true) 

        {
            Console.WriteLine("CNPJ Valido");
        }
           else
        {
             Console.WriteLine("CNPJ Invalido");
        }

    }

}
