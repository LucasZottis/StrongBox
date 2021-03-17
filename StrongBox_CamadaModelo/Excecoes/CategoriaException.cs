using System;

namespace StrongBox.CamadaModelo.Excecoes {
    public class CategoriaException : Exception {
        public CategoriaException() { }

        public CategoriaException(string message) : base(message) { }

        public CategoriaException(string message, Exception inner) : base(message, inner) { }
    }
}
