﻿using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i=0; i<tab.linhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j=0; j<tab.colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca) 
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
