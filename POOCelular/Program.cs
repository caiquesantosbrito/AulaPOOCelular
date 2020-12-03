using System;

namespace POOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            string escolha; 
            do{
            Console.WriteLine("O Celular está ligado? sim/nao");
            escolha = Console.ReadLine();

                if(escolha.ToLower() == "sim"){
                celular1.ligado = true;
                Console.WriteLine("Digite a cor do celular:");
                celular1.cor = Console.ReadLine();
                Console.WriteLine("Digite o modelo do celular:");
                celular1.modelo = Console.ReadLine();
                Console.WriteLine("Digite o tamanho do celular:");
                celular1.tamanho = Console.ReadLine();

            Console.WriteLine("Deseja enviar alguma mensagem? sim/nao");
            string resposta = Console.ReadLine();
                    
                if(resposta.ToLower() == "sim"){
                    celular1.mensagens = true;
                    celular1.Mensagem(celular1.mensagens);
                }else{
                    celular1.mensagens = false;
                    celular1.Mensagem(celular1.mensagens);
                }

            Console.WriteLine("Deseja fazer alguma ligação? sim/nao");
            string resposta2 = Console.ReadLine();
                
                if(resposta2.ToLower() == "sim"){
                    celular1.ligacoes = true;
                    celular1.FazerLigacao(celular1.ligacoes);
                }else{
                    celular1.ligacoes = false;
                    celular1.FazerLigacao(celular1.ligacoes);
                }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----Informações do aparelho-----");
            Console.ResetColor();
            Console.WriteLine("Cor do aparelho : " + celular1.cor);
            Console.WriteLine("Moedelo do aparelho: " + celular1.modelo);
            Console.WriteLine("Tamanho do aparelho :" + celular1.tamanho);
            break;
                    
            }else{
                Console.WriteLine("Fim!");
            }
            }while(escolha.ToLower() == "sim");
        }       
    }
}
