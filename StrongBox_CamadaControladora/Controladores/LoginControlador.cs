using StrongBox.Biblioteca.Classes.Estaticas;
using StrongBox.Biblioteca.Enums;
using StrongBox.CamadaControle.Interfaces;
using StrongBox.CamadaModelo;
using StrongBox.CamadaModelo.Servicos;
using StrongBox.Exceptions;
using System;
using System.Data;

namespace StrongBox.CamadaControle.Controles {
    public class LoginControlador {
        #region Propriedades e Atributos

        private readonly ILogin _intLogin;

        #endregion

        public LoginControlador(ILogin pInterface) {
            _intLogin = pInterface;
        }

        public void Criar() {
            Login login = new Login(_intLogin.ObterUsuario(), _intLogin.ObterObservacao(), _intLogin.ObterTamanho(), _intLogin.ObterTipo(), _intLogin.ObterSenha(), _intLogin.ObterLocal());
            login.Inserir(ComandosSql.InserirLogin);
        }

        public void Alterar() {
            Login login = new Login(_intLogin.ObterCodigo(), _intLogin.ObterUsuario(), _intLogin.ObterObservacao(), _intLogin.ObterTamanho(), _intLogin.ObterTipo(), _intLogin.ObterSenha(), _intLogin.ObterLocal());
            login.Atualizar(ComandosSql.AtualizarLogin);
        }

        public DataTable BuscarLogins() {
            return new Login().Consultar(ComandosSql.BuscarLogins);
        }

        public void Excluir() {
            Login login = new Login(_intLogin.ObterCodigo());
            login.Deletar(ComandosSql.DeletarLogin);
        }

        public string BuscarPrefixo() {
            return new Login(_intLogin.ObterLocal()).Consultar(ComandosSql.BuscarPrefixo).Rows[0].Field<string>(0);
        }

        public string GerarSenha() {
            string senha;
            switch (_intLogin.ObterTipo()) {
                case TipoSenha.Alfabetica: senha = BuscarPrefixo() + GeradorDeSenha.SenhaAlfabetica(_intLogin.ObterTamanho()); break;
                case TipoSenha.Numerica: senha = GeradorDeSenha.SenhaNumerica(_intLogin.ObterTamanho()); break;
                case TipoSenha.AlfaNumerica: senha = BuscarPrefixo() + GeradorDeSenha.SenhaAlfaNumerica(_intLogin.ObterTamanho()); break;
                default: throw new LoginException("Tipo de senha incorreto!");
            }
            return senha;
        }
    }
}
