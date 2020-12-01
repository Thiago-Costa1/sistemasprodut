using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
                
             {
            int escolha;
            int contador = 0;
            string resposta;
            bool[] promocao = new bool [2];
            string[] produto = new string [2];
            float[] preco = new float [2];
            

           
            Console.WriteLine("Gerenciador de Produtos.");
            Console.WriteLine("-------------------------");

            do
            {   
                
                Console.WriteLine("---Menu---");
                
                Console.WriteLine("Selecione uma das seguintes opções:");
                Console.WriteLine("[1] Cadastrar produtos");
                Console.WriteLine("[2] Listar produtos");
                Console.WriteLine("[0] Sair");
                escolha = int.Parse(Console.ReadLine());

            switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro dos produtos");
                        do
                        {
                            if(contador < 2 ){
                            Console.WriteLine($"Digite o nome do {contador+1}º produto");
                            produto[contador] = Console.ReadLine();

                            Console.WriteLine($"Digite o preço do {contador+1}º produto");
                            preco[contador] = float.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite se o {contador+1}º produto está em promoção True = Sim / False = Não");
                            promocao[contador] = bool.Parse(Console.ReadLine());
                            
                            contador++;

                            }else
                            {
                                Console.WriteLine("Limite de produtos excedido");
                                break;
                            }

                            Console.WriteLine("Gostaria de Cadastrar mais produtos ?? S/N");
                            resposta = Console.ReadLine();

                        }while (resposta.ToUpper() == "S");

                        break;

                    case 2:
                        Console.WriteLine("Lista dos produtos.");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Produtos : {produto[i]}");
                            Console.WriteLine($"Preço : {preco[i]}");
                            EfetuarPromocao (promocao[i]);
                            Console.WriteLine($"-----------------------------");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Sistema finalizado");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
            } 
        } while (escolha != 0); 

        void EfetuarPromocao(bool promocao){
            if (promocao == true){
                Console.WriteLine("Com promoção");
            }else{
                Console.WriteLine("Sem promoção");
            }
        }
              
    }    
            
        }
    }
}
