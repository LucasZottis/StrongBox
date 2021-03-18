using StrongBox.Biblioteca.Enums;
using System;

namespace StrongBox.Biblioteca.Classes.Estaticas {
    public static class Conversores {
        public static int ParaInt(this object pValor) {
            return Convert.ToInt32(pValor);
        }

        public static int ParaInt(this string pValor) {
            return int.Parse(pValor);
        }

        public static byte ParaByte(this TipoSenha pValor) {
            return Convert.ToByte(pValor);
        }
    }
}
