using System;
namespace POOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;
        public bool desligado;
        public bool mensagens;
        public bool ligacoes;

        public void Ligar(bool ligado){
            if(ligado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("O celular está desligado");
            }
        }

        public void Desligar(bool desligado){
            if(desligado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("O celular está desligado");
            }
        }

         public void Mensagem(bool mensagem){
            if(mensagem == true){
                Console.WriteLine("Escreva a mensagem: ");
                string mensagens = Console.ReadLine();
                Console.WriteLine("Sua mensagem foi enviada");
            }else{
                Console.WriteLine("Tente novamnete, mensagem cancelada");
            }
        }

        public void FazerLigacao(bool ligacao){
            if(ligacao == true){
                Console.WriteLine("Para quem?");
                string quem = Console.ReadLine();
                Console.WriteLine("Ligando!");
                Console.WriteLine($"Ligação para {quem} recusada, grave seu recado ou você será cobrado após o sinal");
            }else{
                Console.WriteLine("Ligue novamente mais tarde!");
            }
        }
    }
}