using StrongBox.CamadaModelo.Enums;
using StrongBox.CamadaModelo.Excecoes;
using System;

namespace StrongBox.CamadaModelo.Entidades {
    public class Login {
        public long Codigo { get; private set; }
        public string Usuario { get; private set; }
        public string Observacao { get; private set; }
        public byte Tamanho { get; private set; }
        public string Senha { get; private set; }
        public TipoDeSenha TipoSenha { get; private set; }
        public long CodigoLocal { get; private set; }
        private bool _excluido;

        public Login(string usuario, string observacao, byte tamanho, TipoDeSenha tipo, string senha, long codigoLocal) {
            if (usuario.Length > 50 || usuario.Length < 4) throw new LoginException("Login deve ter de 4 à 50 caracteres."); else this.Usuario = usuario;
            if (string.IsNullOrEmpty(observacao)) {
                Observacao = observacao;
            } else if (observacao.Length > 30 || observacao.Length < 4) {
                throw new LoginException("Campo observação deve ter de 4 à 30 caracteres.");
            } else this.Observacao = observacao;
            if (tamanho < 4 || tamanho > 20) throw new LoginException("Tamanho da deve ser entre 4 e 20 caracteres."); else this.Tamanho = tamanho;
            if (senha.Length != Tamanho) throw new LoginException("O tamanho da senha não pode ser diferente que o definido."); else this.Senha = senha;
            if (Convert.ToByte(tipo) < 0 || Convert.ToByte(tipo) > 2) throw new LoginException("Tipo de senha selecionado não existe."); else TipoSenha = tipo;
            if (codigoLocal < 1) throw new LoginException("Local inexistente."); else this.CodigoLocal = codigoLocal;
        }
        public Login(long codigo, string usuario, string observacao, byte tamanho, long codigoLocal) {
            if (codigo < 0) throw new LoginException("ID não pode ser menor que 0."); else this.Codigo = codigo;
            if (usuario.Length > 50 || usuario.Length < 4) throw new LoginException("Login deve ter de 4 à 50 caracteres."); else this.Usuario = usuario;
            if (string.IsNullOrEmpty(observacao)) {
                Observacao = observacao;
            } else if (observacao.Length > 30 || observacao.Length < 4) {
                throw new LoginException("Campo observação deve ter de 4 à 30 caracteres.");
            } else this.Observacao = observacao; 
            if (tamanho < 4 || tamanho > 20) throw new LoginException("Tamanho da deve ser entre 4 e 20 caracteres."); else this.Tamanho = tamanho;
            if (codigoLocal < 1) throw new LoginException("Local inexistente."); else this.CodigoLocal = codigoLocal;
        }
        public Login(long codigo, byte tamanho, TipoDeSenha tipo, string senha, long codigoLocal) {
            if (codigo < 0) throw new LoginException("ID não pode ser menor que 0."); else this.Codigo = codigo;
            if (tamanho < 4 || tamanho > 20) throw new LoginException("Tamanho da deve ser entre 4 e 20 caracteres."); else this.Tamanho = tamanho;
            if (senha.Length != Tamanho) throw new LoginException("O tamanho da senha não pode ser diferente que o definido."); else this.Senha = senha;
            if (Convert.ToInt32(tipo) < 1 || Convert.ToInt32(tipo) > 3) throw new LoginException("Tipo de senha selecionado não existe."); else TipoSenha = tipo;
            if (codigoLocal < 1) throw new LoginException("Local inexistente."); else this.CodigoLocal = codigoLocal;
        }
        public Login(long codigo) {
            if (codigo < 0) throw new LoginException("ID não pode ser menor que 0."); else this.Codigo = codigo;
        }


        public void AtivarDesativar(bool opcao) {
            _excluido = opcao;
        }

        public bool FoiExcluido() {
            return _excluido;
        }
    }
}
