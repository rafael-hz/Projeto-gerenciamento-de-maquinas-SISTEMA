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
                Console.WriteLine("------------------ Adicionar Máquina ------------------");

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
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine($"\nDeseja adicionar:\n\nPA: {pa}\nNome Lógico: {nomeLogico}\nNúmero de Série: {numeroSerie}\n");
                    Console.WriteLine("Na sua lista de máquinas?\n");
                    Console.Write("(S/N) >> ");
                    string opcao = Console.ReadLine();

                    switch (opcao.ToLower())
                    {
                        case "s":
                            if (VerificarMaquina(maquinas, pa))
                            {
                                Console.WriteLine("\n\n!!! Máquina já consta no cadastro. !!!");
                                Console.WriteLine("\n----------------------------------------------------");
                            }
                            else
                            {
                                maquinas.Add(new Maquina(pa, nomeLogico, numeroSerie));
                                Console.WriteLine("\n\n*** Máquina cadastrada com sucesso. ***");
                                Console.WriteLine("\n----------------------------------------------------");
                            }
                            break;
                        case "n":
                            Console.WriteLine("\n\n*** Máquina não foi adicionada. ***");
                            Console.WriteLine("\n----------------------------------------------------");
                            break;
                        default:
                            Console.WriteLine("\n\n!!! Favor, digite uma opção válida. !!!");
                            Console.ReadKey();
                            break;
                    }

                    if (opcao.ToLower() == "s" || opcao.ToLower() == "n")
                    {
                        break;
                    }
                }

                Console.WriteLine("\nDeseja adicionar outra máquina?");
                Console.Write("(S/N) >> ");
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
            Console.WriteLine("------------------ Alterar Máquina ------------------");

            Console.WriteLine("\n\nInforme a Estação de Trabalho(PA) que deseja alterar.");
            Console.Write(">> ");
            int pa = int.Parse(Console.ReadLine());

            if (VerificarMaquina(maquinas, pa))
            {
                Console.WriteLine("\n----------------------------------------------------");
                Maquina estacaoTrabalhoEncontrado = maquinas.Find(x => x.EstacaoDeTrabalho == pa);

                Console.WriteLine($"\n\nInformações sobre a Estação de Trabalho(PA):\n");
                Console.WriteLine($"PA: {estacaoTrabalhoEncontrado.EstacaoDeTrabalho}\n" +
                                  $"Nome Lógico: {estacaoTrabalhoEncontrado.NomeLogico}\n" +
                                  $"Número de Série: {estacaoTrabalhoEncontrado.NumeroSerie}");
                while (true)
                {
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine("\n\n\nInforme qual opção desejaria trocar.\n\n" +
                                      "1 - Nome Lógico\n" +
                                      "2 - Número de Série\n");
                    Console.Write(">> ");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":

                            Console.WriteLine($"\nDigite o novo Nome Lógico.");
                            Console.Write(">> ");
                            string novoNomeLogico = Console.ReadLine();
                            estacaoTrabalhoEncontrado.NomeLogico = novoNomeLogico;

                            Console.WriteLine($"\nNome Lógico alterado com suceso.");
                            break;

                        case "2":

                            Console.WriteLine($"\nDigite o novo Número de Série.");
                            Console.Write(">> ");
                            string novoNumeroSerie = Console.ReadLine();
                            estacaoTrabalhoEncontrado.NumeroSerie = novoNumeroSerie;

                            Console.WriteLine($"\nNúmero de Série alterado com suceso.");
                            break;

                        default:
                            Console.WriteLine("\nFavor, digite uma opção válida.");
                            Console.ReadKey();
                            break;
                    }

                    Console.WriteLine("\nDeseja ir para o Menu?");
                    Console.Write("(S/N) >>");
                    string resposta = Console.ReadLine().ToLower();

                    if (resposta.ToLower() == "s") break;
                }
            }
            else
            {
                Console.WriteLine("\n\n!!! Máquina não consta no cadastro. !!!");
                Console.WriteLine("\n----------------------------------------------------");
                Console.ReadKey();
            }

        }

        public void RemoverMaquina()
        {
            
            Console.Clear();
            Console.WriteLine("------------------ Remover Máquina ------------------");
            Console.WriteLine("\n\nInforme a Estação de Trabalho(PA) da máquina que deseja remover");
            Console.Write(">> ");
            int pa = int.Parse(Console.ReadLine());

            if (VerificarMaquina(maquinas, pa))
            {
                Maquina estacaoTrabalhoEncontrado = maquinas.Find(x => x.EstacaoDeTrabalho == pa);

                while (true)
                {
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine($"\n\nInformações sobre a Estação de Trabalho(PA):\n");
                    Console.WriteLine($"PA: {estacaoTrabalhoEncontrado.EstacaoDeTrabalho}\n" +
                                        $"Nome Lógico: {estacaoTrabalhoEncontrado.NomeLogico}\n" +
                                        $"Número de Série: {estacaoTrabalhoEncontrado.NumeroSerie}");
                    Console.WriteLine("\nDeseja remover da lista de máquinas?");
                    Console.Write("(S/N)>> ");
                    string opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "s":
                            maquinas.Remove(estacaoTrabalhoEncontrado);
                            Console.WriteLine("\n\n*** Máquina removida com sucesso. ***");
                            Console.WriteLine("\n----------------------------------------------------");
                            Console.ReadKey();
                            break;
                        case "n":
                            Console.WriteLine("\n\n!!! Máquina não removida. !!!");
                            Console.WriteLine("\n----------------------------------------------------");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("\nFavor, digite uma opção válida.");
                            Console.ReadKey();
                            break;
                    }
                    if (opcao == "s" || opcao == "n") break;
                }
            }
            else
            {
                Console.WriteLine("\n\n!!! Máquina não consta no cadastro. !!!");
                Console.WriteLine("\n----------------------------------------------------");
                Console.ReadKey();
            }
        }

        public void BuscarMaquina()
        {
            Console.Clear();
            Console.WriteLine("------------------ Buscar Máquina ------------------");

            Console.WriteLine("\n\nQual a forma que deseja buscar a máquina\n");
            Console.WriteLine("1 - Estação de Trabalho (PA)\n2 - Nome Lógico\n3 - Número de Série\n");
            Console.Write(">> ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine("\nInforme o número da Estação de Trabalho(PA) da máquina para consulta");
                    Console.Write(">> ");
                    int estacaoTrabalhoProcurando = int.Parse(Console.ReadLine());
                    Maquina estacaoTrabalhoEncontrado = maquinas.Find(x => x.EstacaoDeTrabalho == estacaoTrabalhoProcurando);
                    if (estacaoTrabalhoEncontrado != null)
                    {
                        Console.WriteLine($"\n\nInformações sobre a Estação de Trabalho(PA): {estacaoTrabalhoProcurando}\n");
                        Console.WriteLine($"PA: {estacaoTrabalhoEncontrado.EstacaoDeTrabalho}\n" +
                                          $"Nome Lógico: {estacaoTrabalhoEncontrado.NomeLogico}\n" +
                                          $"Número de Série: {estacaoTrabalhoEncontrado.NumeroSerie}");
                    }
                    else
                    {
                        Console.WriteLine($"\nEstação de Trabalho(PA): {estacaoTrabalhoProcurando} está incorreto!");
                    }
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine("\nInforme o Nome Lógico da máquina para consulta");
                    Console.Write(">> ");
                    string nomeLogicoProcurando = Console.ReadLine();
                    Maquina nomeLogicoEncontrado = maquinas.Find(x => x.NomeLogico == nomeLogicoProcurando);
                    if (nomeLogicoEncontrado != null )
                    {
                        Console.WriteLine($"\n\nInformações sobre o Nome Lógico: {nomeLogicoProcurando}\n");
                        Console.WriteLine($"PA: {nomeLogicoEncontrado.EstacaoDeTrabalho}\n" +
                                          $"Nome Lógico: {nomeLogicoEncontrado.NomeLogico}\n" +
                                          $"Número de Série: {nomeLogicoEncontrado.NumeroSerie}");
                    }
                    else
                    {
                        Console.WriteLine($"\nNome Lógico: {nomeLogicoProcurando} está incorreto!");
                    }
                        Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine("\nInforme o Número de Série da máquina para consulta");
                    Console.Write(">> ");
                    string numeroSerieProcurando = Console.ReadLine();
                    Maquina numeroSerieEncontrado = maquinas.Find(x => x.NumeroSerie == numeroSerieProcurando);
                    if (numeroSerieEncontrado != null)
                    {
                        Console.WriteLine($"\n\nInformações sobre o Número de Série: {numeroSerieProcurando}\n");
                        Console.WriteLine($"PA: {numeroSerieEncontrado.EstacaoDeTrabalho}\n" +
                                          $"Nome Lógico: {numeroSerieEncontrado.NomeLogico}\n" +
                                          $"Número de Série: {numeroSerieEncontrado.NumeroSerie}");
                    }
                    else
                    {
                        Console.WriteLine($"\nNúmero de Série: {numeroSerieProcurando} está incorreto!");
                    }
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Favor, digite uma opção válida.");
                    break;

            }
        }

        public void ListarTodasMaquinas()
        {
            Console.Clear();
            Console.WriteLine("------------------ Listar Todas Máquina ------------------");
            Console.WriteLine("\n");

            foreach (Maquina maquina in maquinas)
            {
                Console.WriteLine($"PA: {maquina.EstacaoDeTrabalho} | Nome Lógico: {maquina.NomeLogico} | Número de Série: {maquina.NumeroSerie}");
            }
            Console.ReadKey();
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
    }
}
