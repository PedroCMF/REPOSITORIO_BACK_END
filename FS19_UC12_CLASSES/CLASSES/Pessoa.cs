namespace FS19_UC12_CLASSES.CLASSES
{
    public abstract class Pessoa  //classe abstrata=> a classe abstrata cria um modelo, porem nao instancia. A intancia é feita pelas classe filhas da classe abstrata
    {
        public string? nome { get; set; } //? é para o campo nao ter valor nulo
        public string? endereco { get; set; } //Atributo da classe pessoa
        public bool enderecoComercial { get; init; }
        public void PagarImposto() //metodo da classe pessoa

        { 

        }
    
    }
}