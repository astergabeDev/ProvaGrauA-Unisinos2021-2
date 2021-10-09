namespace ProvaGA
{
    public class Jogador
    {
        string nome{get; set;}
        string posicao{get; set;}
        int data{get; set;}
        string nacionalidade{get; set;}
        int altura{get; set;}
        int peso{get; set;}
        int idade{get; set;}

        public Jogador(string nome, string posicao, int data, string nacionalidade, int altura, int peso)
        {
            this.nome = nome;
            this.posicao = posicao;
            this.data = data;
            this.nacionalidade = nacionalidade;
            this.altura = altura;
            this.peso = peso;
        }

        public void imprimeDados()
        {
            System.Console.WriteLine($"Nome: {nome}");
            System.Console.WriteLine($"Posição: {posicao}");
            System.Console.WriteLine($"Ano de nascimento: {data}");
            System.Console.WriteLine($"Nacionalidade: {nacionalidade}");
            System.Console.WriteLine($"Altura: {altura}cm");
            System.Console.WriteLine($"Peso: {peso}kg");

        }
        public void calculaIdade()
        {
            int anoAtual = 2021;

            idade = anoAtual - data;
            System.Console.WriteLine($"Ele tem {idade} anos");

        }
        public void aposentadoria()
        {
            int tempoFalta = 0;
            
            if (posicao == "defesa")
            {
                tempoFalta = 40 - idade;
                System.Console.WriteLine($"Falta: {tempoFalta} anos para se aposentar");
            }else if (posicao == "ataque")
            {
                tempoFalta = 35 - idade;
                System.Console.WriteLine($"Falta: {tempoFalta} anos para se aposentar");
            }else if (posicao == "meio-campo")
            {
                tempoFalta = 38 - idade;
                System.Console.WriteLine($"Falta: {tempoFalta} anos para se aposentar");
            }
        }
    }
}