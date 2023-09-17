using System;

//Classe base criada
class Pessoa
{
    protected string nome;
    protected string ra;

    public Pessoa(string nome, string ra)
    {
        this.nome = nome;
        this.ra = ra;
    }
    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {nome} e meu RA é {ra}.");
    }
    //Método criado para verificar se o RA digitado está correto e pertence ao aluno predefinido
    public bool VerificarRA(string raDigitado)
    {
        return ra == raDigitado;
    }
}
//Exemplo de herança
class Estudante : Pessoa
{
    protected string curso;

    public Estudante(string nome, string ra, string curso) : base(nome, ra)
    {
        this.curso = curso;
    }
    //Método criado para apresentar o nome e RA do aluno
    public override void Apresentar()
    {
        Console.WriteLine($"Oi, sou o estudante {nome}, do curso de {curso}, com RA {ra}. Meu RA está correto? ");
    }
}
//Método para executar o programa e mostrar a verificação do RA e resposta ao usuário
class Program
{
    static void Main(string[] args)
    {
        Estudante estudante = new Estudante("Matheus", "N009EE7", "ADS");

        estudante.Apresentar();

        Console.Write("Digite o RA para novamente para verificar a identidade do estudante: ");
        string raDigitado = Console.ReadLine();

        if (estudante.VerificarRA(raDigitado))
        {
            Console.WriteLine("O RA digitado realmente pertence a esse estudante.");
        }
        else
        {
            Console.WriteLine("O RA digitado não pertence a esse estudante.");
        }
    }
}
