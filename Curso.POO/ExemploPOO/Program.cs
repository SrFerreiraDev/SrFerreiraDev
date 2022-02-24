using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Meu Código\\.NET\\Curso.POO\\ManipulandoArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo teste stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo teste bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo teste stream.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerAquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));
            // System.Console.WriteLine(calc.Subtrair(20, 10));
            // System.Console.WriteLine(calc.Multiplicar(10, 20));
            // System.Console.WriteLine(calc.Dividir(10, 2));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100000);

            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

            // Aluno p1 = new Aluno();
            // p1.Nome = "Edinaldo";
            // p1.Idade = 26;
            // p1.Documento = "123456789";
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Ferreira";
            // p2.Idade = 26;
            // p2.Documento = "123456789";
            // p2.Salario = 10000;
            // p2.Apresentar();

            // // Valores Válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 20);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // // Valores Inálidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Ferreira";
            // p1.Idade = 26;
            // p1.Apresentar();
        }
    }
}