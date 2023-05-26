namespace FS19_UC12_CLASSES.CLASSES
{
    public class PessoaFisica : Pessoa //PessoaFisica herda os atributos de pessoa
    {
        public string? cpf {get; set;}
        public DateTime dataNascimento { get; set; }

        public override void PagarImposto(float rendimento) //Devido o metodo pagarimposto ser abstract na classe pessoa usa se o override(sobrescrever) da classe Pessoa
        //Override sobrescreve os parametro do metodo quando ele passa nele pegando as informações do momento
        {
            
        }

        public bool validarDataNacimento(DateTime dataNascimento) //metodo para retorna datA ATUAL
        {
         
         DateTime dataatual = DateTime.Today; //pega a data atual do sistema
         double anos = (dataatual - dataNascimento).TotalDays / 365;  //calculo da data de nacimento da pessoa
         
         if (anos >= 18) //validação de datas

         {
            return true;
         }

         else

         {
            return false;
         }

        }
    }


}