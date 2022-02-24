namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

         public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou um aluno, tenho {Idade} anos, meu CPF é: {Documento} e minha nota é: {Nota}.");
        }
    }
}