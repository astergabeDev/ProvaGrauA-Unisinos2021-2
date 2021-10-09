using System;

namespace ProvaGA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region teste exercicio 1
            /*
            Jogador messi = new Jogador("Lionel Messi","meio-campo",1987,"Argentino",169,67);
            Jogador neymar = new Jogador("Neymar Jr","ataque",2002,"Brasileiro",175,69);
            messi.imprimeDados();
            messi.calculaIdade();
            messi.aposentadoria();
            neymar.imprimeDados();
            neymar.calculaIdade();
            neymar.aposentadoria();
            */
            #endregion

            #region teste exercicio 2
            /*
            Elevador elevador = new Elevador(0,10,6,0);
            bool menu = true;
            int escolha;

            while(menu)
            {
                System.Console.WriteLine("Menu do elevador:");
                System.Console.WriteLine("1 - inicializar");
                System.Console.WriteLine("2 - entrar");
                System.Console.WriteLine("3 - sair");
                System.Console.WriteLine("4 - subir");
                System.Console.WriteLine("5 - descer");
                System.Console.WriteLine("Insira a opção: ");

                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    elevador.inicializar();
                }
                else if (escolha == 2)
                {
                    elevador.entrar();
                }
                else if (escolha == 3)
                {
                    elevador.sair();
                }
                else if (escolha == 4)
                {
                    elevador.subir();
                }
                else if (escolha == 5)
                {
                    elevador.descer();
                }
            }
            */
            #endregion
            #region teste exercicio 3
            Data dataNova = new Data("27/03/2002");
            dataNova.compara(new Data("19/05/2080"));
            dataNova.getDia();
            dataNova.getMes();
            dataNova.getAno();
            dataNova.getMesExtenso();
            dataNova.isBissexto();   
            #endregion
        }
    }
}
