using StatePattern.Modelos;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Documento documento = CriarDocumento();
        ObterStatusAtualDocumento(documento);

        int? opcao;
        do
        {
            opcao = ObterMenu();
            RealizarMudancaEstado(opcao, documento);
            ObterStatusAtualDocumento(documento);
        }
        while(opcao != 0);
        
        static Documento CriarDocumento()
        {
            Console.WriteLine("Insira a descrição do documento: ");
            string descricao = Console.ReadLine();

            Documento documento = new Documento(descricao);

            return documento;
        }

        static int? ObterMenu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("1 - Avançar o Estado");
            Console.WriteLine("2 - Retornar o Estado");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("===================================");

            string opcaoSelecionada = Console.ReadLine();

            if (int.TryParse(opcaoSelecionada, out int opcao))
                return opcao;

            Console.WriteLine("Opção inválida! Tente novamente!");

            return null;
        }

        static void RealizarMudancaEstado(int? opcao, Documento documento)
        {
            if (opcao == 1)
                documento.ProximoStatus();
            else if (opcao == 2)
                documento.StatusAnterior();
        }

        static void ObterStatusAtualDocumento(Documento documento)
        {
            Console.WriteLine($"*** O estado atual é {documento.ToString()} ***");
        }
    }
}