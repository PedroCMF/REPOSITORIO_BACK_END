namespace FS19_UC12_CLASSES.CLASSES
{
    public class PessoaFisica : Pessoa //PessoaFisica herda os atributos de pessoa
    {
        public string? cpf {get; set;}
        public DateTime dataNascimento { get; set; }
    }
}