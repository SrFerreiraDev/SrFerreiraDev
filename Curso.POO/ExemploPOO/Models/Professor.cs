namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou um professor, tenho {Idade} anos, meu CPF é: {Documento} e meu salário é: {Salario}.");
        }
    }
}