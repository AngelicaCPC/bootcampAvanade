using DIO.Series.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Servico
{
    public class FilmeServico
    {
        FilmesRepositorio repositorio = new FilmesRepositorio();
        public void AtualizarFilme()
        {
            Console.Write("Digite o id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genero)))

            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título do filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição ddo Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes atualizaFilme = new Filmes(id: indiceFilme,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);
            repositorio.Atualiza(indiceFilme, atualizaFilme);

        }


        public void ListarFilmes()
        {
            Console.WriteLine("Listar Filmes.");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado");
                return;

            }
            {
                foreach (var filme in lista)
                {
                    var excluido = filme.retornaExcluido();

                    Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "Excluído" : ""));
                }
            }

        }
        public void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do Início do filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes novoFilme = new Filmes(id: repositorio.ProximoId(),
                                           genero: (Genero)entradaGenero,
                                           titulo: entradaTitulo,
                                           ano: entradaAno,
                                           descricao: entradaDescricao);
            repositorio.Insere(novoFilme);
        }

        public void ExcluirFilme()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceFilme);

        }

        public void VisualizarFilme()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorio.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);

        }

        public string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Filmes a seu dispos!");
            Console.WriteLine("Informe a opção desjada.");
            Console.WriteLine("1- Listar filmes");
            Console.WriteLine("2- Inserir novo filme");
            Console.WriteLine("3- Atualizar filme");
            Console.WriteLine("4- Excluir filme");
            Console.WriteLine("5- Visualizar filme");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
