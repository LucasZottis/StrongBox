using System;

namespace StrongBox.CamadaModelo.Excecoes {
    public class LocalException : Exception {
        public LocalException() { }

        public LocalException(string message) : base(message) { }

        public LocalException(string message, Exception inner) : base(message, inner) { }
    }
}
