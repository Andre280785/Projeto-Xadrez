using System;
using tabuleiro;
using tabuleiro.Enums;

namespace xadrez
{
    class PartidaDeXadrez
    {
        private int turno;
        private Cor jogadorAtual;
        public Tabuleiro Tab { get; private set; }
        public bool Terminada { get; private set; }


        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            Terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
        }
        
        private void colocarPecas()
        {
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Branca), new PosicaoXadrez('c',1).toPosicao());
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Branca), new PosicaoXadrez('c',2).toPosicao());
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Branca), new PosicaoXadrez('d',2).toPosicao());
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Branca), new PosicaoXadrez('e',2).toPosicao());
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Branca), new PosicaoXadrez('e',1).toPosicao());
            Tab.colocarPeca(new Rei(Tab, tabuleiro.Enums.Cor.Branca), new PosicaoXadrez('d',1).toPosicao());

            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            Tab.colocarPeca(new Torre(Tab, tabuleiro.Enums.Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            Tab.colocarPeca(new Rei(Tab, tabuleiro.Enums.Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());

        }
    }
}
