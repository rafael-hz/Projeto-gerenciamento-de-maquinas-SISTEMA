using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoDeMaquinas.Models;

namespace GerenciamentoDeMaquinas.Models
{
    public class Gerenciamento
    {
        public string NomeProjeto { get; set; }
        List<Maquina> maquinas = new List<Maquina>();

        public void AdicionarMaquina()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ------------------ Adicionar Máquina ------------------ ");

                Console.WriteLine("\n\nInforme o número da Estação e Trabalho (PA)");
                Console.Write(">> ");
                int pa = int.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme o Nome Lógico da máquina");
                Console.Write(">> ");
                string nomeLogico = Console.ReadLine();

                Console.WriteLine("\nInforme o Número de Série");
                Console.Write(">> ");
                string numeroSerie = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine($"\nDeseja adicionar:\n\nPA: {pa}\nNome Lógico: {nomeLogico}\nNúmero de Série: {numeroSerie}\n");
                    Console.Write("(S/N) >>");
                    string opcao = Console.ReadLine();

                    switch (opcao.ToLower())
                    {
                        case "s":
                            if (VerificarMaquina(maquinas, pa))
                            {
                                Console.WriteLine("Máquina já cadastrada.");
                            }
                            else
                            {
                                maquinas.Add(new Maquina(pa, nomeLogico, numeroSerie));
                                Console.WriteLine("Máquina cadastrada com sucesso!");
                            }
                            break;
                        case "n":
                            Console.WriteLine("Máquina não foi adicionada!");
                            break;
                        default:
                            Console.WriteLine("Favor, digite uma opção válida.");
                            break;
                    }

                    if (opcao.ToLower() == "s" || opcao.ToLower() == "n")
                    {
                        break;
                    }
                }

                Console.WriteLine("\nDeseja adicionar outra máquina?");
                Console.Write("(S/N) >>");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() != "s")
                {
                    break;
                }
            }
        }

        public void AlterarMaquina()
        {
            Console.Clear();
            Console.WriteLine(" ------------------ Alterar Máquina ------------------ ");
        }

        public void RemoverMaquina()
        {
            Console.Clear();
            Console.WriteLine(" ------------------ Remover Máquina ------------------ ");
        }

        public void BuscarMaquina()
        {
            Console.Clear();
            Console.WriteLine(" ------------------ Buscar Máquina ------------------ ");

            Console.WriteLine("\n\nInforme a forma que deseja buscar a máquina");
            Console.WriteLine("1 - Estação de Trabalho (PA)\n2 - Nome Lógico\n3 - Número de Série");
            Console.Write(">> ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    break;

                case "2":
                    Console.WriteLine("Informe o Nome Lógico");
                    string nomeLogicoProcurando = Console.ReadLine();

                    break;

                case "3":
                    break;

                default:
                    break;

            }
        }

        public void ListarTodasMaquinas()
        {
            Console.Clear();
            Console.WriteLine(" ------------------ Listar Todas Máquina ------------------ \n\n");

            foreach (Maquina maquina in maquinas)
            {
                Console.Write($"PA: {maquina.EstacaoDeTrabalho} | Nome Lógico: {maquina.NomeLogico} | Número de Série: {maquina.NumeroSerie}");
            }
        }

        static bool VerificarMaquina(List<Maquina> maquinas, int pa)
        {
            foreach (Maquina maquina in maquinas)
            {
                if (maquina.EstacaoDeTrabalho == pa)
                {
                    return true;
                }
            }

            return false;
        }
        static bool VerificarMaquina(List<Maquina> maquinas, string procura)
        {
            foreach (Maquina maquina in maquinas)
            {
                if (maquina.NomeLogico == procura)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
