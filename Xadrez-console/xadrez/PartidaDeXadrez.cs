﻿using System;
using tabuleiro;
using tabuleiro.Enums;
using tabuleiro.Exception;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
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

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }
        
        public void validarPosicaoOrigem(Posicao pos)
        {
            if (Tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if (jogadorAtual != Tab.peca(pos).Cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!Tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem!");
            }
        }

        public void validaPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
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
