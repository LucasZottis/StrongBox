using StrongBox.Biblioteca.Classes.Estaticas;
using StrongBox.Biblioteca.Enums;
using StrongBox.Exceptions;
using System.Configuration;

namespace StrongBox.CamadaModelo {
    public partial class Login {
        #region Propriedades e Atributos

        private readonly string _sCadeiaConexao;
        public int Codigo { get; private set; }
        public string Usuario { get; private set; }
        public string Observacao { get; private set; }
        public byte Tamanho { get; private set; }
        public string Senha { get; private set; }
        public TipoSenha Tipo { get; private set; }
        public int CodigoLocal { get; private set; }

        #endregion

        #region Construtores

        public Login() {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;
        }

        public Login(int pCodigo) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pCodigo < 1) throw new LoginException("Código de login inexistente!"); else Codigo = pCodigo;
        }

        public Login(string pUsuario, string pObservacao, byte pTamanho, TipoSenha pTipo, string pSenha, int pCodigoLocal) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pUsuario.Length > 50) throw new LoginException("Usuário deve ter 50 caracteres ou menos!");
            else if (pUsuario.Length < 4) throw new LoginException("Usuário deve ter 4 caracteres ou mais!"); 
            else Usuario = pUsuario;

            if (string.IsNullOrEmpty(pObservacao)) Observacao = pObservacao;
            else if (pObservacao.Length > 30) throw new LoginException("Observação de ter 30 caracteres ou menos!");
            else if (pObservacao.Length < 4) throw new LoginException("Observação de ter 4 caracteres ou mais!");
            else Observacao = pObservacao;

            if (pTamanho < 4) throw new LoginException("Tamanho da senha não pode ter menos de 4 caracteres!");
            else if (pTamanho > 20) throw new LoginException("Tamanho da senha não pode ter mais de 20 caracteres!"); 
            else Tamanho = pTamanho;

            if (pSenha.Length != Tamanho) throw new LoginException("O tamanho da senha não pode ser diferente que o definido!"); 
            else Senha = pSenha;

            if (pTipo.ParaByte() < 1 || pTipo.ParaByte() > 3) throw new LoginException("Tipo de senha selecionado não existe."); 
            else Tipo = pTipo;

            if (pCodigoLocal < 1) throw new LoginException("Código do local inexistente!"); 
            else CodigoLocal = pCodigoLocal;
        }

        public Login(int pCodigo, string pUsuario, string pObservacao, byte pTamanho, TipoSenha pTipo, string pSenha, int pCodigoLocal) {
            _sCadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            if (pCodigo < 1) throw new LoginException("Código de login inexistente!"); else Codigo = pCodigo;

            if (pUsuario.Length > 50) throw new LoginException("Usuário deve ter 50 caracteres ou menos!");
            else if (pUsuario.Length < 4) throw new LoginException("Usuário deve ter 4 caracteres ou mais!");
            else Usuario = pUsuario;

            if (string.IsNullOrEmpty(pObservacao)) Observacao = pObservacao;
            else if (pObservacao.Length > 30) throw new LoginException("Observação de ter 30 caracteres ou menos!");
            else if (pObservacao.Length < 4) throw new LoginException("Observação de ter 4 caracteres ou mais!");
            else Observacao = pObservacao;

            if (pTamanho < 4) throw new LoginException("Tamanho da senha não pode ter menos de 4 caracteres!");
            else if (pTamanho > 20) throw new LoginException("Tamanho da senha não pode ter mais de 20 caracteres!");
            else Tamanho = pTamanho;

            if (pSenha.Length != Tamanho) throw new LoginException("O tamanho da senha não pode ser diferente que o definido!");
            else Senha = pSenha;

            if (pTipo.ParaByte() < 1 || pTipo.ParaByte() > 3) throw new LoginException("Tipo de senha selecionado não existe.");
            else Tipo = pTipo;

            if (pCodigoLocal < 1) throw new LoginException("Código do local inexistente!");
            else CodigoLocal = pCodigoLocal;

        }

        #endregion
    }
}
