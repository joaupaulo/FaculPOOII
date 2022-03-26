using System;
using POOOFacul.Entidades;

namespace POOOFacul
{
    class Program
    {



        static void Main(string[] args)
        {


            string mensagem = " Olá usuário, bem vindo ao programa\n" + "\n Utilizando o console" + "\n\n" +
                "\n Digite uma das opções abaixo:" +
                "\n  0 - Verificar estoques de Desktops:" +
                "\n  1 - Verificar estoques de Notebooks:" +
                "\n  2 - Verificar estoques de Servidores";

            Console.WriteLine(mensagem);

            int valor = int.Parse(Console.ReadLine());

            if (valor == 0)
            {

                string messagemDesktop = " 0 - Adicionar Desktops " +
                                        "\n 1 - Verificar Quantidade De Desktop " +
                                        "\n 2 - Excluir quantidades de desktops" +
                                        "\n 3 - Modificar Preço" + 
                                        "\n 4 - Adicionar Itens";
                Console.WriteLine(messagemDesktop);
                int valorDesktop = int.Parse(Console.ReadLine());
                Desktop novoDesktop = new Desktop();

                if (valorDesktop == 0)
                {
                    
                  

                    Console.WriteLine("Digite a quantidade");
                    int valorQuant = int.Parse(Console.ReadLine());
                    novoDesktop.Quantidade = valorQuant;

                    Console.WriteLine("Digite o Preço");
                    int Preco = int.Parse(Console.ReadLine());
                    novoDesktop.Preco = Preco;

                    Console.WriteLine("Digite o número de slots");
                    int nSlots = int.Parse(Console.ReadLine());
                    novoDesktop.NumeroSlotsMemoria = nSlots;

                    Console.WriteLine("Escreva o nome da marca");
                    string marca = Console.ReadLine();
                    novoDesktop.Marca = marca;

                    Console.WriteLine("Escreva o tipo do monitor");
                    string tipoMonitor = Console.ReadLine();
                    novoDesktop.DesktopTipoMonitor = marca;

                    Console.WriteLine("Escreva o tipo da memoria");
                    string tipoMemoria = Console.ReadLine();
                    novoDesktop.DesktopTipoMemoria = tipoMemoria;

                    Console.WriteLine("Escreva o tipo do HD");
                    string tipoHD = Console.ReadLine();
                    novoDesktop.DesktopTipoHD = tipoHD;

                    Console.WriteLine("Escreva o tipo da fonte");
                    string tipofONTE = Console.ReadLine();
                    novoDesktop.DesktopTipoFonte = tipofONTE;

                    Console.WriteLine("Escreva a resolução do monitor");
                    int ResolucaoMonitor = int.Parse(Console.ReadLine());
                    novoDesktop.DesktopResolucaoMonitor = ResolucaoMonitor;

                    Console.WriteLine("Escreva a marca do HD");
                    string DesktoppMarca = Console.ReadLine();
                    novoDesktop.DesktoppMarcaHD = DesktoppMarca;

                    Console.WriteLine("Escreva a marca da Memoria");
                    string MarcaMemoria = Console.ReadLine();
                    novoDesktop.DesktopMarcaMemoria = MarcaMemoria;

                    Console.WriteLine("Escreva a capacidade do HD ");
                    int capacidadeHD = int.Parse(Console.ReadLine());
                    novoDesktop.DesktopCapacidadeHD = capacidadeHD;

                    


                  


                    if (valorDesktop == 1 )
                    {
                        
                        Console.WriteLine( "Quantidade de Desktops :" , novoDesktop.VerQuantidade());

                    }

                    if (valorDesktop == 2)
                    {
                        int RemoverItens = int.Parse(Console.ReadLine());
                        Console.WriteLine(novoDesktop.RemoverItem(RemoverItens));


                      
                    }

                    if (valorDesktop == 3)
                    {
                        int ModificarPreco = int.Parse(Console.ReadLine());
                        novoDesktop.Preco = ModificarPreco;
                    }

                    if (valorDesktop == 4)
                    {
                        int AdicionarItens = int.Parse(Console.ReadLine());
                        Console.WriteLine(novoDesktop.AdicionarItem(AdicionarItens));

                    }


                }



                if (valor == 1)
                {

                    string messagemNotebook = " 0 - Adicionar Notebooks" +
                                            "\n 1 - Verificar Quantidade De Notebooks " +
                                            "\n 2 - Excluir Notebooks" +
                                            "\n 3 - Modificar Notebooks " +
                                            "\n 4 - Adicionar Itens";

                    Console.WriteLine(messagemNotebook);
                    int valorNotebook = int.Parse(Console.ReadLine());
                    Notebook novoNotebook = new Notebook();

                    if (valorNotebook == 0 ) { 
                    
                    Console.WriteLine("Digite a quantidade");
                    int valorQuant = int.Parse(Console.ReadLine());
                    novoNotebook.Quantidade = valorQuant;

                    Console.WriteLine("Digite o Preço");
                    int Preco = int.Parse(Console.ReadLine());
                    novoNotebook.Preco = Preco;

                    Console.WriteLine("Digite a capacidade da memoria");
                    int CapMemoria = int.Parse(Console.ReadLine());
                    novoNotebook.CapacidadeMemoria = CapMemoria;

                    Console.WriteLine("Escreva o nome da marca");
                    string marca = Console.ReadLine();
                    novoNotebook.Marca = marca;

                    Console.WriteLine("Escreva o tipo de Fonte");
                    string tipoFonte = Console.ReadLine();
                    novoNotebook.TipoFonte = tipoFonte;

                    Console.WriteLine("Escreva a quantidade de memoria");
                    int QuantMemoria = int.Parse(Console.ReadLine());
                    novoNotebook.SlotsMemoria = QuantMemoria;

                    Console.WriteLine("Escreva a capacidade do HD");
                    int tipoHD = int.Parse(Console.ReadLine());
                    novoNotebook.NotebookCapacidadeHD = tipoHD;

                    Console.WriteLine("Escreva a marca da fonte");
                    string tipofONTE = Console.ReadLine();
                    novoNotebook.MarcaFonte = tipofONTE;

                    Console.WriteLine("Escreva a potencia da fonte");
                    int PotenciaFonte = int.Parse(Console.ReadLine());
                    novoNotebook.PotenciaFonte = PotenciaFonte;

                    Console.WriteLine("Escreva o tipo do Gabinete");
                    string TipoDoGabinete = Console.ReadLine();
                    novoNotebook.TipoGabinete = TipoDoGabinete;

                    Console.WriteLine("Escreva o tipo do HD ");
                    string tipoDoHd = Console.ReadLine();
                    novoNotebook.TipoHD = tipoDoHd;

                    }



                    if (valorNotebook == 0)
                    {
                        int AdicionarItens = int.Parse(Console.ReadLine());
                        Console.WriteLine(novoNotebook.AdicionarItem(AdicionarItens));

                    }


                    if (valorNotebook == 1)
                    {

                        Console.WriteLine("Quantidade de Desktops :", novoNotebook.VerQuantidade());

                    }

                    if (valorNotebook == 2)
                    {
                        int RemoverItens = int.Parse(Console.ReadLine());
                        Console.WriteLine(novoNotebook.RemoverItem(RemoverItens));



                    }

                    if (valorNotebook == 3)
                    {
                        int ModificarPreco = int.Parse(Console.ReadLine());
                        novoNotebook.Preco = ModificarPreco;
                    }



                }


                if (valor == 2)
                {

                    string messagemServidor = " 0 - Adicionar Servidores" +
                                            "\n 1 - Verificar Quantidade De Servidores " +
                                            "\n 2 - Excluir Servidores" +
                                            "\n 3 - Modificar Servidores ";

                    Console.WriteLine(messagemServidor);
                    int valorServidor = int.Parse(Console.ReadLine());
                    Servidor novoServidor = new Servidor();

                    if (valorServidor == 0 ) {  

                    Console.WriteLine("Digite a quantidade");
                    int valorQuant = int.Parse(Console.ReadLine());
                    novoServidor.Quantidade = valorQuant;

                    Console.WriteLine("Digite o Preço");
                    int Preco = int.Parse(Console.ReadLine());
                    novoServidor.Preco = Preco;

                    Console.WriteLine("Digite a capacidade da memoria");
                    int CapMemoria = int.Parse(Console.ReadLine());
                    novoServidor.ServidorCapacidadeMemoria = CapMemoria;

                    Console.WriteLine("Escreva o nome da marca");
                    string marca = Console.ReadLine();
                    novoServidor.ServidorMarcaMemoria = marca;

                    Console.WriteLine("Escreva a marca da Fonte");
                    string MarcatipoFonte = Console.ReadLine();
                    novoServidor.ServidorMarcaFonte = MarcatipoFonte;

                    Console.WriteLine("Escreva a quantidade de memoria");
                    int QuantSlots = int.Parse(Console.ReadLine());
                    novoServidor.SlotsMemoria = QuantSlots;

                    Console.WriteLine("Escreva a capacidade do HD");
                    string CapacidadeHD = Console.ReadLine();
                    novoServidor.ServidorCapacidadeHD = CapacidadeHD;

                    Console.WriteLine("Escreva a marca da Memória");
                    string MarcaMemoria = Console.ReadLine();
                    novoServidor.ServidorMarcaMemoria = MarcaMemoria;

                    Console.WriteLine("Escreva a marca da fonte");
                    string MarcaDaFonte = Console.ReadLine();
                    novoServidor.ServidorMarcaGabinete = MarcaDaFonte;

                    Console.WriteLine("Escreva a capacidade da memória");
                    int CapacidadeMemoria = int.Parse(Console.ReadLine());
                    novoServidor.ServidorCapacidadeMemoria = CapacidadeMemoria;

                    Console.WriteLine("Escreva a capacidadeDoHd ");
                    string CapacidadeHd = Console.ReadLine();
                    novoServidor.ServidorCapacidadeHD = CapacidadeHd;

                    }







                    if (valorServidor == 0)
                    {
                        int AdicionarItens = int.Parse(Console.ReadLine());
                        Console.WriteLine(novoServidor.AdicionarItem(AdicionarItens));

                    }


                    if (valorServidor == 1)
                    {

                        Console.WriteLine("Quantidade de Desktops :", novoServidor.VerQuantidade());

                    }

                    if (valorServidor == 2)
                    {
                        int RemoverItens = int.Parse(Console.ReadLine());
                        Console.WriteLine(novoServidor.RemoverItem(RemoverItens));



                    }

                    if (valorServidor == 3)
                    {
                        int ModificarPreco = int.Parse(Console.ReadLine());
                        novoServidor.Preco = ModificarPreco;
                    }







                }







            }
        }
    }
}
