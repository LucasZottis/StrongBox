using StrongBox.Exceptions;
using System.Configuration;

namespace StrongBox.CamadaModelo {
    public partial class Categoria {
        #region

        private readonly string _sCadeiaConexao;
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Prefixo { get; private set; }

        #endregion

        #region Construtores

        public Categoria() {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;
        }

        public Categoria(int pCodigo) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pCodigo < 1) throw new CategoriaException("Código de categoria inválido!"); 
            else Codigo = pCodigo;
        }

        public Categoria(string pNome, string pPrefixo) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pNome.Length < 5) throw new CategoriaException("Nome precisa ter mais de 5 caracteres"); else Nome = pNome;
            if (pPrefixo.Length != 3) throw new CategoriaException("Prefixo é apenas 3 caracteres"); else Prefixo = pPrefixo;
        }

        public Categoria(int pCodigo, string pNome, string pPrefixo) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pCodigo < 1) throw new CategoriaException("Código de categoria inválido!"); else Codigo = pCodigo;
            if (pNome.Length < 5) throw new CategoriaException("Nome precisa ter mais de 5 caracteres"); else Nome = pNome;
            if (pPrefixo.Length != 3) throw new CategoriaException("Prefixo é apenas 3 caracteres"); else Prefixo = pPrefixo;
        }

        #endregion
    }
}