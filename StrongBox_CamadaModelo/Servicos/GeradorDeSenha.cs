using System;

namespace StrongBox.CamadaModelo.Servicos {
    public static class GeradorDeSenha {
        private readonly static Random aleatorio = new Random();
        private readonly static string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXWYZabcdefghijklmnopqrstuvxwyz";
        private readonly static string numeros = "0123456789";

        public static string SenhaAlfaNumerica(byte tamanho) {
            string senha = null;
            int posicao;

            for (int i = 0; i < tamanho - 3; i++) {
                if (i % 2 == 0) {
                    posicao = aleatorio.Next(alfabeto.Length);
                    senha += alfabeto[posicao];
                } else {
                    posicao = aleatorio.Next(numeros.Length);
                    senha += numeros[posicao];
                }
            }

            return senha;
        }
        public static string SenhaNumerica(byte tamanho) {
            string senha = null;
            int posicao;

            for (int i = 0; i < tamanho - 3; i++) {
                posicao = aleatorio.Next(numeros.Length);
                senha += numeros[posicao];
            }

            return senha;
        }
        public static string SenhaAlfabetica(byte tamanho) {
            string senha = null;
            int posicao;

            for (int i = 0; i < tamanho - 3; i++) {
                posicao = aleatorio.Next(alfabeto.Length);
                senha += alfabeto[posicao];
            }

            return senha;
        }
    }
}
