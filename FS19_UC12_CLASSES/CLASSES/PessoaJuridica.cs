namespace FS19_UC12_CLASSES.CLASSES
{
    public class PessoaJuridica : Pessoa //PessoaJuridica herda os atributos de pessoa
    {
       public string? cnpj { get; set; }
       public string? razaoSocial { get; set; }
    }
}