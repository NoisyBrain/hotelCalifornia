using System;

namespace Trabalho2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control1 = true;
            while(control1)
            {
                Console.WriteLine("1 - Login/n0 - SAIR");
                int dec1 = int.Parse(Console.ReadLine());
                switch (dec1)
                {
                    case 0:
                        control1 = false;
                        break;
                    case 1:
                        Console.WriteLine("---------- LOGIN ------");
                        bool control2 = true;
                        while (control2)
                        {
                            Console.WriteLine("1 - Gerente\n2 - Atendente\n0 - SAIR");
                            int dec2 = int.Parse(Console.ReadLine());
                            switch(dec2)
                            {
                                case 0: 
                                    control2 = false;
                                    break;
                                case 1:
                                    bool control3 = true;
                                    while (control3)
                                    {
                                        Console.WriteLine("---------- LOGIN GERENTE ------");
                                        GerenteFacade hotelGerente = new GerenteFacade();
                                        Console.WriteLine("1 - Cadastrar Cliente\n2 - Lançar compra\n3 - Checking\n4 - Checkout\n5 - Cadastrar produto\n0 - SAIR");
                                        int dec3 = int.Parse(Console.ReadLine());
                                        switch(dec3)
                                        {
                                            case 0:
                                                control3 = false;
                                                break;
                                            case 1: //Cadastrar hospedes
                                                Console.WriteLine("---------- CADASTRAR HÓSPEDE ----------");
                                                Console.WriteLine("Nome do cliente: ");
                                                string user_name = Console.ReadLine();
                                                Console.WriteLine("CPF do cliente: ");
                                                string user_cpf = Console.ReadLine();
                                                hotelGerente.RegistrarCliente(user_name, user_cpf);
                                                break;
                                            case 2: //Lançar compra no relatório do cliente
                                                Console.WriteLine("---------- VENDA DE PRODUTO ----------");
                                                Console.WriteLine("Id do cliente: ");
                                                string user_id = Console.ReadLine();
                                                Console.WriteLine("Código do produto: ");
                                                string product_cod = Console.ReadLine();
                                                Console.WriteLine("Quantidade de produto: ");
                                                int qnt = int.Parse(Console.ReadLine());
                                                hotelGerente.LancarCompra(user_id, qnt, product_cod);
                                                break;
                                            case 3://Fazer checking
                                                Console.WriteLine("---------- CHECKING ----------");
                                                Console.WriteLine("CPF do cliente: ");
                                                user_id = Console.ReadLine();
                                                Console.WriteLine("Tipo de estadia: ");
                                                string type_room = Console.ReadLine();
                                                Console.WriteLine("Período de estadia: ");
                                                int reserva = int.Parse(Console.ReadLine());
                                                hotelGerente.Checking(user_id, reserva, type_room);
                                                break;
                                            case 4://Fazer checkout
                                                Console.WriteLine("---------- CHECKOUT ----------");
                                                Console.WriteLine("Id do cliente: ");
                                                user_id = Console.ReadLine();
                                                hotelGerente.Checkout(user_id);
                                                break;
                                            case 5://Cadastrar novo produto
                                                Console.WriteLine("---------- CADASTRO DE PRODUTO ----------");
                                                bool control5 = true;
                                                while (control5)
                                                {
                                                    Console.WriteLine("1 - Consumível\n2 - Quarto\n3 - Serviço: ");
                                                    int dec4 = int.Parse(Console.ReadLine());
                                                    switch (dec4)
                                                    {
                                                        case 0:
                                                            control5 = false;
                                                            break;
                                                        case 1:
                                                            Console.WriteLine("---------- CADASTRAR CONSUMÍVEL ----------");
                                                            //nome, cod, valor
                                                            Console.WriteLine("Nome: ");
                                                            string product_name = Console.ReadLine();
                                                            Console.WriteLine("Cod: ");
                                                            product_cod = Console.ReadLine();
                                                            Console.WriteLine("Valor: ");
                                                            float product_valor = float.Parse(Console.ReadLine());
                                                            hotelGerente.CadastrarConsumivel(product_name, product_cod, product_valor);
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("---------- CADASTRAR QUARTO ----------");
                                                            //cod, numQuarto, andar, tipo, valor, checking, checkout
                                                            Console.WriteLine("Cod: ");
                                                            product_cod = Console.ReadLine();
                                                            Console.WriteLine("Número do quarto: ");
                                                            string numQuarto = Console.ReadLine();
                                                            Console.WriteLine("Andar: ");
                                                            string andar = Console.ReadLine();
                                                            Console.WriteLine("Tipos: \n+ Simples  \n- +Duplo  \n+ Casal: ");
                                                            string product_tipo = Console.ReadLine();
                                                            Console.WriteLine("Valor: ");
                                                            product_valor = float.Parse(Console.ReadLine());
                                                            hotelGerente.CadastrarQuarto(product_cod, numQuarto, andar, product_tipo, product_valor);
                                                            break;
                                                        case 3:
                                                            //nome, cod, descricao, data
                                                            Console.WriteLine("---------- CADASTRAR SERVIÇO ----------");
                                                            //nome, cod, descricao, data
                                                            Console.WriteLine("Nome: ");
                                                            product_name = Console.ReadLine();
                                                            Console.WriteLine("Cod: ");
                                                            product_cod = Console.ReadLine();
                                                            Console.WriteLine("Descrição: ");
                                                            string product_desc = Console.ReadLine();
                                                            Console.WriteLine("Data: ");
                                                            string product_data = Console.ReadLine();
                                                            hotelGerente.CadastrarServico(product_name, product_cod, product_desc, product_data);
                                                            break;
                                                        default:
                                                            Console.WriteLine("OP5 : Opção inválida!");
                                                            break;
                                                    }
                                                }
                                                    
                                                break;
                                            default:
                                                Console.WriteLine("OP3 : Opção inválida!");
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    bool control4 = true;
                                    while (control4)
                                    {
                                        Console.WriteLine("---------- LOGIN ATENDENTE ------");
                                        AtendenteFacade hotelAtendente = new AtendenteFacade();
                                        Console.WriteLine("1 - Cadastrar Cliente\n2 - Lançar compra\n3 - Checking\n4 - Checkout\n0 - SAIR");
                                        int dec5 = int.Parse(Console.ReadLine());
                                        switch(dec5)
                                        {
                                            case 0:
                                                control4 = false;
                                                break;
                                            case 1: //Cadastrar hospedes
                                                Console.WriteLine("---------- CADASTRAR HÓSPEDE ----------");
                                                Console.WriteLine("Nome do cliente: ");
                                                string user_name = Console.ReadLine();
                                                Console.WriteLine("CPF do cliente: ");
                                                string user_cpf = Console.ReadLine();
                                                hotelAtendente.RegistrarCliente(user_name, user_cpf);
                                                break;
                                            case 2: //Lançar compra no relatório do cliente
                                                Console.WriteLine("---------- VENDA DE PRODUTO ----------");
                                                Console.WriteLine("Id do cliente: ");
                                                string user_id = Console.ReadLine();
                                                Console.WriteLine("Código do produto: ");
                                                string product_cod = Console.ReadLine();
                                                Console.WriteLine("Quantidade de produto: ");
                                                int qnt = int.Parse(Console.ReadLine());
                                                hotelAtendente.LancarCompra(user_id, qnt, product_cod);
                                                break;
                                            case 3://Fazer checking
                                                Console.WriteLine("---------- CHECKING ----------");
                                                Console.WriteLine("CPF do cliente: ");
                                                user_id = Console.ReadLine();
                                                Console.WriteLine("Tipo de estadia: ");
                                                string type_room = Console.ReadLine();
                                                Console.WriteLine("Período de estadia: ");
                                                int reserva = int.Parse(Console.ReadLine());
                                                hotelAtendente.Checking(user_id, reserva, type_room);
                                                break;
                                            case 4://Fazer checkout
                                                Console.WriteLine("---------- CHECKOUT ----------");
                                                Console.WriteLine("CPF do cliente: ");
                                                user_id = Console.ReadLine();
                                                hotelAtendente.Checkout(user_id);
                                                break;
                                            default:
                                                Console.WriteLine("OP4 : Opção inválida!");
                                                break;
                                        }
                                    } 
                                    break;
                                default:
                                    Console.WriteLine("OP2 : Opção inválida!");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("OP01 : Opção inválida!");
                        break;
                }
            }
        }
    }
}
