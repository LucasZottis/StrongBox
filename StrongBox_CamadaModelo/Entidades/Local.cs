using StrongBox.Exceptions;
using System.Configuration;

namespace StrongBox.CamadaModelo {
    public partial class Local {
        #region Propriedades e Atributos

        private readonly string _sCadeiaConexao;
        public long Codigo { get; private set; }
        public string Nome { get; private set; }
        public int CodigoCategoria { get; private set; }

        #endregion

        #region Construtores

        public Local() {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;
        }

        public Local(int pCodigo) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pCodigo < 1) throw new LocalException("Código de local inválido!"); else Codigo = pCodigo;
        }

        public Local(string pNome, int pCodigoCategoria) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pNome.Length < 3) throw new LocalException("Nome precisa ter mais de 3 caracteres!"); else Nome = pNome;
            if (pCodigoCategoria < 1) throw new LocalException("Código da categoria inválido!"); else CodigoCategoria = pCodigoCategoria;
        }

        public Local(int pCodigo, string pNome, int pCodigoCategoria) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pCodigo < 1) throw new LocalException("Código de local inválido!"); else Codigo = pCodigo;
            if (pNome.Length < 3) throw new LocalException("Nome precisa ter mais de 3 caracteres!"); else Nome = pNome;
            if (pCodigoCategoria < 1) throw new LocalException("Código da categoria inválido!"); else CodigoCategoria = pCodigoCategoria;
        }

        #endregion
    }
}
