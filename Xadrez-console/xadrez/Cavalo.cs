using System;
using tabuleiro;
using tabuleiro.Enums;


namespace xadrez
{

    class Cavalo : Peca
    {

        public Cavalo(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        private bool podeMover(Posicao pos)
        {
            //Peca
            return false;
        }

        public override bool[,] movimentosPossiveis()
        {
            throw new NotImplementedException();
        }
    }
}
   

