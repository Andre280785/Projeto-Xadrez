using tabuleiro.Enums;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            this.QtdMovimentos = 0;
        }

        public void incrementarQtdMovimentos()
        {
            QtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}