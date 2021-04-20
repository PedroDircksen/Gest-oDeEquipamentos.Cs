using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomesDosEquipamentos = new string[100];
            string[] precosDosEquipamentos = new string[100];
            string[] numerosDeSeries = new string[100];
            DateTime[] datasDeFabricacoes = new DateTime[100];
            string[] fabricantes = new string[100];
            string[] nomesDosChamados = new string[100];
            string[] descricoesDosChamados = new string[100];
            string[] equipamentosDosChamados = new string[100];
            DateTime[] datasAbChamados = new DateTime[100];            
            DateTime[] datasAtChamados = new DateTime[100];
            int countChamados = 0, countEquipamentos = 0;
            string Opcao, Opcao2 = "", Opcao3 = "", Opcao4 = "";
            string nomeDoEquipamento;
            DateTime dataEquipamentos = DateTime.MinValue, dataChamados = DateTime.MinValue;
            
            do
            {
                nomeDoEquipamento = null;
                Console.Clear();
                Console.WriteLine("\n                        Menu Principal");
                Console.WriteLine("______________________________________________________________________\n\n");
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("\n1.Registrar \n2.Mostrar Inventário \n3.Editar Inventário \n4.Excluir item  \n5.Chamada de Manutenção \n6.Sair\n");
                Console.WriteLine("______________________________________________________________________\n\n");
                Opcao = Console.ReadLine();

                switch (Opcao)
                {
                    case "1":

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Nome do Equipamento: ");
                            nomeDoEquipamento = Console.ReadLine();
                            if (nomeDoEquipamento.Length < 6)
                            {
                                Console.WriteLine("\nO nome deve ter pelo menos 6 caracteres. Tente novamente");
                                Console.ReadLine();
                            }
                        }
                        while (nomeDoEquipamento.Length < 6);

                        Console.WriteLine("Preço do Equipamento: ");
                        precosDosEquipamentos[countEquipamentos] = Console.ReadLine();

                        Console.WriteLine("Número de série: ");
                        numerosDeSeries[countEquipamentos] = Console.ReadLine();

                        Console.WriteLine("Data de fábricação: ");
                        datasDeFabricacoes[countEquipamentos] = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Fabricante: ");
                        fabricantes[countEquipamentos] = Console.ReadLine();

                        nomesDosEquipamentos[countEquipamentos] = nomeDoEquipamento;
                        countEquipamentos++;
                        break;
                    case "2":
                        Console.Clear();
                        if (countEquipamentos != 0)
                        {
                            for (int i = 0; i < countEquipamentos; i++)
                            {
                                if (numerosDeSeries[i] == null)
                                {
                                    Console.WriteLine("Item " + i + " Excluído");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n" + (i + 1) + "° Equipamento registrado: ");
                                    Console.WriteLine("\nNome do equipamento: " + nomesDosEquipamentos[i]);
                                    Console.WriteLine("\nNumero de serie: " + numerosDeSeries[i]);
                                    Console.WriteLine("\nFabricante: " + fabricantes[i]);
                                }
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNenhum item no inventário\n\n");
                            Console.ReadLine();
                        }
                        break;

                    case "3":
                        Console.Clear();
                        do
                        {

                            if (countEquipamentos != 0)
                            {
                                Console.WriteLine("Equipamentos resgistrados: \n");
                                for (int i = 0; i < countEquipamentos; i++)
                                {
                                    if (nomesDosEquipamentos[i] == null)
                                    {
                                        Console.WriteLine("Item " + i + " Excluído");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Item " + i + ": " + nomesDosEquipamentos[i]);
                                    }
                                }
                                Console.ReadLine();
                                Console.WriteLine("\n\nDigite o número do item no inventário que deseja editar: ");
                                int i2 = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                if (nomesDosEquipamentos[i2] == null)
                                {
                                    Console.WriteLine("Este item foi excluído, não é possível editá-lo");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Menu de Edição\n");
                                    Console.WriteLine("Digite o número do que deseja editar: \n");
                                    Console.WriteLine("\n1. Nome do equipamento \n2. Preço do equipamento \n3. Número de série");
                                    Console.WriteLine("4. Data da fabricação \n5. Fabricante \n6. voltar para o menu principal\n");
                                    Opcao2 = Console.ReadLine();


                                    switch (Opcao2)
                                    {
                                        case "1":
                                            string nomes;
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Digite o novo nome: ");
                                                nomes = Console.ReadLine();
                                                if (nomes.Length < 6)
                                                {
                                                    Console.WriteLine("\nO nome deve ter pelo menos 6 caracteres. Tente novamente");
                                                    Console.ReadLine();
                                                }
                                            } while (nomes.Length < 6);
                                            Opcao2 = "6";
                                            Console.Clear();
                                            break;
                                        case "2":
                                            Console.Clear();
                                            Console.WriteLine("Digite o novo preço: ");
                                            precosDosEquipamentos[i2] = Console.ReadLine();
                                            Opcao2 = "6";
                                            Console.Clear();
                                            break;
                                        case "3":
                                            Console.Clear();
                                            Console.WriteLine("Digite o novo Número de série: ");
                                            numerosDeSeries[i2] = Console.ReadLine();
                                            Opcao2 = "6";
                                            Console.Clear();
                                            break;

                                        case "4":
                                            Console.Clear();
                                            Console.WriteLine("Digite a nova data de fabricação: ");
                                            datasDeFabricacoes[i2] = Convert.ToDateTime(Console.ReadLine());
                                            Opcao2 = "6";
                                            Console.Clear();
                                            break;
                                        case "5":
                                            Console.Clear();
                                            Console.WriteLine("Digite o novo fabricante: ");
                                            fabricantes[i2] = Console.ReadLine();
                                            Opcao2 = "6";
                                            Console.Clear();
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNão há nenhum item para editar\n\n\n");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                        } while (Opcao2 != "6");
                        break;

                    case "4":
                        if (countEquipamentos != 0)
                        {
                            Console.Clear();
                            for (int i = 0; i < countEquipamentos; i++)
                            {
                                Console.WriteLine(i + ": " + nomesDosEquipamentos[i]);

                            }
                            Console.WriteLine("Digite o número do item no inventário que deseja excluir: ");
                            int i2 = Convert.ToInt32(Console.ReadLine());


                            nomesDosEquipamentos[i2] = null;

                            Console.Clear();
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\nNão há nenhum item para excluir\n\n\n");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;

                    case "5":

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("\n			  Menu de Chamados\n\n");
                            Console.WriteLine("______________________________________________________________________\n\n");
                            Console.WriteLine("1.  Registrar Chamado\n2.  Vizualizar Chamados\n3.  Editar Chamado\n4.  Excluir Chamado\n5.  Voltar");
                            Console.WriteLine("\n____________________________________________________________________\n\n");
                            Opcao3 = Console.ReadLine();
                            if (Opcao3 == "5")
                            {
                                Console.Clear();
                                Console.WriteLine("Voltando para o menu principal...\n\nPressione qualquer tecla para continuar");
                                Console.ReadLine();
                                break;
                            }
                            Console.Clear();
                            switch (Opcao3)
                            {

                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Título do Chamado: ");
                                    nomesDosChamados[countChamados] = Console.ReadLine();

                                    Console.Clear();
                                    Console.WriteLine("Descrição do Chamado: ");
                                    descricoesDosChamados[countChamados] = Console.ReadLine();

                                    Console.Clear();
                                    Console.WriteLine("Escolha um dos equipamento: ");
                                    for (int i = 0; i < countEquipamentos; i++)
                                    {
                                        if (nomesDosEquipamentos[i] == null)
                                        {
                                            Console.WriteLine("Item " + i + " Excluído");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Item " + i + ": " + nomesDosEquipamentos[i]);
                                        }
                                    }

                                    int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                                    equipamentosDosChamados[countChamados] = nomesDosEquipamentos[numeroEscolhido];

                                    Console.Clear();
                                    Console.WriteLine("Data de Abertura: ");
                                    dataChamados = Convert.ToDateTime(Console.ReadLine());


                                    Console.WriteLine("Seu Chamado foi registrado com sucesso!\n\n");

                                    Console.ReadLine();
                                    Console.Clear();
                                    datasAbChamados[countChamados] = dataChamados;
                                    countChamados++;

                                    continue;



                                case "2":

                                    if (countChamados != 0)
                                    {
                                        for (int i = 0; i < countChamados; i++)
                                        {
                                            if (nomesDosChamados[i] == null)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Chamada " + i + " excluída.");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                TimeSpan diasEmAberto = (DateTime.Now) - (datasAbChamados[i]);
                                                Console.Clear();
                                                Console.WriteLine("\n\n" + (i + 1) + "° Chamado resgistrado:");
                                                Console.WriteLine("\nTítulo do Chamado: " + nomesDosChamados[i]);
                                                Console.WriteLine("\nEquipamento: " + equipamentosDosChamados[i]);
                                                Console.WriteLine("\nData de Abertura: " + datasAbChamados[i].ToString("dd/MM/yyyy"));
                                                Console.WriteLine("\nDias decorridos: " + diasEmAberto.ToString("dd"));
                                                Console.ReadLine();
                                                Console.Clear();
                                                Opcao3 = "5";
                                            }

                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nNenhum chamado registrado\n\n");
                                        Console.ReadLine();
                                    }
                                    Console.Clear();
                                    continue;

                                case "3":
                                    if (countChamados != 0)
                                    {
                                        Console.WriteLine("Chamados resgistrados: ");
                                        for (int i = 0; i < countChamados; i++)
                                        {
                                            if (nomesDosChamados[i] == null)
                                            {
                                                Console.WriteLine("Chamado " + i + " Excluído");
                                            }
                                            else
                                            {
                                                Console.WriteLine(i + ": " + nomesDosChamados[i]);
                                            }
                                        }
                                        Console.WriteLine("\n\nDigite o número do chamado que deseja editar: ");
                                        int i3 = Convert.ToInt32(Console.ReadLine());
                                        if (nomesDosChamados[i3] == null)
                                        {
                                            Console.WriteLine("Este chamado foi excluído, não é possível editá-lo");
                                            Console.ReadLine();
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Menu de Edição\n");
                                            Console.WriteLine("\n1. Editar Título do Chamado\n2. Editar Descrição do Chamado\n3. Editar Equipamento");
                                            Console.WriteLine("4. Editar Data de Abertura\n5. voltar para o menu de chamados\n");
                                            Opcao4 = Console.ReadLine();
                                            switch (Opcao4)
                                            {
                                                case "1":
                                                    Console.Clear();
                                                    Console.WriteLine("Digite o novo Título: ");
                                                    nomesDosChamados[i3] = Console.ReadLine();
                                                    Console.ReadLine();
                                                    Opcao4 = "5";
                                                    Console.Clear();
                                                    continue;
                                                case "2":
                                                    Console.Clear();
                                                    Console.WriteLine("Digite a nova Descrição: ");
                                                    descricoesDosChamados[i3] = Console.ReadLine();
                                                    Console.ReadLine();
                                                    Opcao4 = "5";
                                                    Console.Clear();
                                                    continue;
                                                case "3":
                                                    Console.Clear();
                                                    Console.WriteLine("Digite o novo Equipamento: ");
                                                    equipamentosDosChamados[i3] = Console.ReadLine();
                                                    Console.ReadLine();
                                                    Opcao4 = "5";
                                                    Console.Clear();
                                                    continue;
                                                case "4":

                                                    Console.Clear();
                                                    Console.WriteLine("Digite a nova Data de Abertura: ");
                                                    dataChamados = Convert.ToDateTime(Console.ReadLine());
                                                    datasAbChamados[i3] = dataChamados;
                                                    Opcao4 = "5";
                                                    Console.Clear();
                                                    continue;
                                                case "5":
                                                    Console.Clear();
                                                    Console.WriteLine("Voltando ao Menu Principal...\n\n\n");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nNão há nenhum chamado para editar\n\n\n");
                                        Console.ReadLine();
                                        Console.Clear();
                                        continue;
                                    }
                                    continue;

                                case "4":

                                    if (countChamados != 0)
                                    {
                                        for (int i = 0; i < countChamados; i++)
                                        {
                                            Console.WriteLine(i + ": " + nomesDosChamados[i]);
                                        }
                                        Console.WriteLine("Digite o número do chamado que deseja excluir: ");
                                        int i4 = Convert.ToInt32(Console.ReadLine());


                                        nomesDosChamados[i4] = null;


                                        Console.ReadLine();
                                        Console.Clear();
                                        continue;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nNão há nenhum chamado para excluir\n\n\n");
                                        Console.ReadLine();
                                        Console.Clear();
                                        continue;

                                    }
                                    continue;

                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("voltando para o menu principal...\n\nPressione qualquer tecla para continuar");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                }





            } while (Opcao != "6");
        }
    }
}
