namespace sistema_celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public string pMensagem;

        public string pLigacao;

        public void Ligar()
        {
            Console.WriteLine($"Ligando o Celular");

        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando o celular");

        }

        public void FazerLigacao()
        {
            Console.WriteLine($"Fazendo uma ligacao para {pLigacao}...");

        }

        public void EnviarMensagem()
        {
            Console.WriteLine($"Enviando uma mensagem para {pMensagem}...");

        }
    }







}