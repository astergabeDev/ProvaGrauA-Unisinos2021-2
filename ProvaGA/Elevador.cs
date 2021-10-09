namespace ProvaGA
{
    public class Elevador
    {
        int andarAtual{get; set;}
        int totalAndares{get; set;}
        int capacidadeElevador{get; set;}
        int pessoas{get; set;}

        int[] elevador{get; set;}

        public Elevador(int andarAtual, int totalAndares, int capacidadeElevador, int pessoas)
        {
            this.andarAtual = andarAtual;
            this.totalAndares = totalAndares;
            this.capacidadeElevador = capacidadeElevador;
            this.pessoas = pessoas;
        }

        public void inicializar()
        {
            andarAtual = 0;
            totalAndares = 10;
            capacidadeElevador = 6;
        }
        public void entrar()
        {
            if (pessoas < capacidadeElevador)
            {
                pessoas++;
            }else 
            {
                System.Console.WriteLine("O elevador ja esta cheio");
            }
        }
        public void sair()
        {
            if(pessoas > 0)
            {
                pessoas--;
            }else
            {
                System.Console.WriteLine("O elevador ja esta vazio");
            }
        }
        public void subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual++;
            }else
            {
                System.Console.WriteLine("O elevador ja esta no ultimo andar");
            }
        }
        public void descer()
        {
            if(andarAtual > 0)
            {
                andarAtual--;
            }else 
            {
                System.Console.WriteLine("O elevador ja esta no terreo");
            }
        }
    }
}