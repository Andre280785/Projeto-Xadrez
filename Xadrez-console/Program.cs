using System;
using tabuleiro;
using xadrez;
using tabuleiro.Exception;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(0, 6));
                tab.colocarPeca(new Rei(tab, tabuleiro.Enums.Cor.Preta), new Posicao(2, 4));

                tab.colocarPeca(new Rei(tab, tabuleiro.Enums.Cor.Branca), new Posicao(3, 5));

                Tela.imprimeTabuleiro(tab);
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
