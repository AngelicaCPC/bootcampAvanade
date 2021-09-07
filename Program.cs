using DIO.Series.Classes;
using DIO.Series.Servico;
using System;

namespace DIO.Series
{
    class Program
    {
        static SerieServico serieServico = new SerieServico();
        static FilmeServico filmeServico = new FilmeServico();
        
        static void Main(string[] args)
        {
            string opcao = ObterTipo();

            while(opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        string opcaoFilme = filmeServico.ObterOpcaoUsuario();

                        while (opcaoFilme.ToUpper() != "X")
                        {
                            switch (opcaoFilme)
                            {
                                case "1":
                                    filmeServico.ListarFilmes();
                                    break;
                                case "2":
                                    filmeServico.InserirFilme();
                                    break;
                                case "3":
                                    filmeServico.AtualizarFilme();
                                    break;
                                case "4":
                                    filmeServico.ExcluirFilme();
                                    break;
                                case "5":
                                    filmeServico.VisualizarFilme();
                                    break;
                                case "C":
                                    Console.Clear();
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();

                            }

                            opcaoFilme = filmeServico.ObterOpcaoUsuario();
                        }
                        break;
                    case "2":
                        string opcaoUsuario = serieServico.ObterOpcaoUsuario();

                        while (opcaoUsuario.ToUpper() != "X")
                        {
                            switch (opcaoUsuario)
                            {
                                case "1":
                                    serieServico.ListarSeries();
                                    break;
                                case "2":
                                    serieServico.InserirSerie();
                                    break;
                                case "3":
                                    serieServico.AtualizarSerie();
                                    break;
                                case "4":
                                    serieServico.ExcluirSerie();
                                    break;
                                case "5":
                                    serieServico.VisualizarSerie();
                                    break;
                                case "C":
                                    Console.Clear();
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();

                            }

                            opcaoUsuario = serieServico.ObterOpcaoUsuario();
                        }
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcao = ObterTipo();
            }

            
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        public static string ObterTipo()
        {
            Console.WriteLine("Dio Filmes/Séries a seu dispor!");
            Console.WriteLine("Informe a opção desejada.");
            Console.WriteLine("1- Acessar Filmes");
            Console.WriteLine("2- Acessar Séries");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }




    }
}
