namespace FS19_UC12_CLASSES.CLASSES
{
    public class PessoaJuridica : Pessoa //PessoaJuridica herda os atributos de pessoa
    {
       public string? cnpj { get; set; }
       public string? razaoSocial { get; set; }

       public string? inscricaoEstadual { get; set; }
       
       public override void PagarImposto(float rendimento) //Devido o metodo pagarimposto ser abstract na classe pessoa usa se o override(sobrescrever) da classe Pessoa. Devido o metodo esta em uma classe filha e override ela tem corpo
        //Override sobrescreve os parametro do metodo atual quando ele passa nele pegando as informações do momento
        {
            
        }

    //Somente mermitir cadastro com 14 numeros
    //sendo os 4 antepenutimos 0001
    //configurar uma mensagem de erro 

    public bool ValidaCNPJ(string cnpj)
    {
    
        if((cnpj.Length >= 14) && (cnpj.Substring(cnpj.Length - 4)) == "0001") //Onde o cnpj for maior ou igual a 14. A substring pega os 4 antepenultimos numeros 0001 

        {
            return true;
        }

            return false;

    }
    

    }

}