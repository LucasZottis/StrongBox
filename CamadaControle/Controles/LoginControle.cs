using StrongBox.CamadaControle.Interfaces;
using StrongBox.CamadaModelo.Entidades;
using StrongBox.CamadaModelo.Enums;
using StrongBox.CamadaModelo.Repositorios;
using StrongBox.CamadaModelo.Servicos;
using System;
using System.Data;

namespace StrongBox.CamadaControle.Controles {
    public class LoginControle {
        private readonly ILogin _form;

        private readonly string _sqlInserir = "INSERT INTO LOGIN (USUARIO, OBS, SENHA, TAMANHO, TIPO_SENHA, COD_LOCAL) VALUES (@Usuario, @Observacao, @Senha, @Tamanho, @TipoSenha, @CodigoLocal)";
        private readonly string _sqlAtualizarLogin = "UPDATE LOGIN SET USUARIO = @Usuario, OBS = @Observacao, TAMANHO = @Tamanho, COD_LOCAL = @CodigoLocal WHERE CODIGO = @Codigo";
        private readonly string _sqlAtualizarSenha = "UPDATE LOGIN SET SENHA = @Senha, TAMANHO = @Tamanho, TIPO_SENHA = @TipoSenha WHERE CODIGO = @Codigo";
        private readonly string _sqlDeletar = "UPDATE LOGIN SET EXCLUIDO = @Excluido WHERE CODIGO = @Codigo";

        private readonly string _sqlBuscarTudo = "SELECT LOGIN.*, LOCAL.NOME FROM LOGIN INNER JOIN LOCAL ON (LOCAL.CODIGO = LOGIN.COD_LOCAL) WHERE LOGIN.EXCLUIDO = 0";
        private readonly string _sqlComboBox = "SELECT CODIGO, NOME FROM LOCAL";
        private readonly string _sqlCodigoCategoria = "SELECT COD_CATEGORIA FROM LOCAL WHERE CODIGO = ";
        private readonly string _sqlBuscarPrefixo = "SELECT PREFIXO FROM CATEGORIA WHERE CODIGO = ";

        public LoginControle(ILogin formulario) {
            _form = formulario;
        }

        public void Criar() {
            Login login = new Login(_form.ObterUsuario(), _form.ObterObservacao(), _form.ObterTamanho(), (TipoDeSenha) _form.ObterTipoSenha(), _form.ObterSenha(), _form.ObterLocal());
            LoginRepositorio.Inserir(_sqlInserir, login);
        }
        public void AlterarLogin() {
            Login login = new Login(_form.ObterCodigoLogin(), _form.ObterUsuario(), _form.ObterObservacao(), _form.ObterTamanho(), _form.ObterLocal());
            LoginRepositorio.Atualizar(_sqlAtualizarLogin, login);
        }
        public void AlterarSenha() {
            Login login = new Login(_form.ObterCodigoLogin(), _form.ObterTamanho(), (TipoDeSenha) _form.ObterTipoSenha(), _form.ObterSenha(), _form.ObterLocal());
            LoginRepositorio.Atualizar(_sqlAtualizarSenha, login);
        }
        public void Excluir() {
            Login login = new Login(_form.ObterCodigoLogin());
            login.AtivarDesativar(true);
            LoginRepositorio.Deletar(_sqlDeletar, login);
        }
        public DataTable BuscarLogins() {
            return LoginRepositorio.Consultar(_sqlBuscarTudo);
        }
        public DataTable PreecherComboBox() {
            return LoginRepositorio.Consultar(_sqlComboBox);
        }
        private string BuscarPrefixo() {
            long codigoCategoria = Convert.ToInt64(LoginRepositorio.Consultar(_sqlCodigoCategoria + _form.ObterLocal()).Rows[0].ItemArray[0]);
            return LoginRepositorio.Consultar(_sqlBuscarPrefixo + codigoCategoria).Rows[0].ItemArray[0].ToString().Trim();
        }
        public string GerarSenha() {
            string senha;
            switch (_form.ObterTipoSenha()) {
                case 0: senha = BuscarPrefixo() + GeradorDeSenha.SenhaAlfabetica(_form.ObterTamanho()); break;
                case 1: senha = GeradorDeSenha.SenhaNumerica(_form.ObterTamanho()); break;
                case 2: senha = BuscarPrefixo() + GeradorDeSenha.SenhaAlfaNumerica(_form.ObterTamanho()); break;
                default: throw new Exception("Tipo de senha incorreto!");
            }
            return senha;
        }
    }
}
