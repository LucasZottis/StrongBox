using System.Configuration;

namespace VerificaBanco {
    class Configuracao {
        private Configuration _arquivoConfiguracao;
        public string CaminhoAplicativo { get; private set; }
        public string CaminhoServidor { get; private set; }
        public string CaminhoBanco { get; private set; }
        public string NomeBanco { get; private set; }
        public string CadeiaConexao { get; private set; }

        public Configuracao(string caminhoAplicativo) {
            CaminhoAplicativo = caminhoAplicativo;

            _arquivoConfiguracao = ConfigurationManager.OpenExeConfiguration(CaminhoAplicativo);

            CaminhoServidor = ObterCaminhoServidor();
            CaminhoBanco = ObterCaminhoBancoDados();
            NomeBanco = ObterNomeBancoDados();
            if (!string.IsNullOrEmpty(NomeBanco)) CadeiaConexao = ObterCadeiaConexao();
        }

        private bool VerificarConfiguracao(string chave) {
            return _arquivoConfiguracao.AppSettings.Settings[chave] != null;
        }
        private bool VerificarCadeiaConexao(string nomeBancoDados) {
            return _arquivoConfiguracao.ConnectionStrings.ConnectionStrings[nomeBancoDados] != null;
        }

        private void CriarConfiguracao(string chave, string valor) {
            _arquivoConfiguracao.AppSettings.Settings.Add(chave, valor);
        }
        private void CriarCadeiaConexao(string nomaBancoDados, string cadeiaConexa) {
            _arquivoConfiguracao.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(nomaBancoDados, cadeiaConexa));
        }

        private string ObterCaminhoServidor() {
            if (VerificarConfiguracao("CaminhoServidor")) return _arquivoConfiguracao.AppSettings.Settings["CaminhoServidor"].Value;
            else return string.Empty;
        }
        private string ObterCaminhoBancoDados() {
            if (VerificarConfiguracao("CaminhoBancoDeDados")) return _arquivoConfiguracao.AppSettings.Settings["CaminhoBancoDeDados"].Value;
            else return string.Empty;
        }
        private string ObterNomeBancoDados() {
            if (VerificarConfiguracao("NomeBancoDeDados")) return _arquivoConfiguracao.AppSettings.Settings["NomeBancoDeDados"].Value;
            else return string.Empty;
        }
        private string ObterCadeiaConexao() {
            if (VerificarCadeiaConexao(NomeBanco)) return _arquivoConfiguracao.ConnectionStrings.ConnectionStrings[NomeBanco].ConnectionString;
            else return string.Empty;
        }

        public void AlterarCaminhoServidor(string valor) {
            if (VerificarConfiguracao("CaminhoServidor")) _arquivoConfiguracao.AppSettings.Settings["CaminhoServidor"].Value = valor;
            else CriarConfiguracao("CaminhoServidor", valor);
        }
        public void AlterarCaminhoBancoDados(string valor) {
            if (VerificarConfiguracao("CaminhoBanco")) _arquivoConfiguracao.AppSettings.Settings["CaminhoBanco"].Value = valor;
            else CriarConfiguracao("CaminhoBanco", valor);
        }
        public void AlterarNomeBancoDados(string valor) {
            if (VerificarConfiguracao("NomeBanco")) _arquivoConfiguracao.AppSettings.Settings["NomeBanco"].Value = valor;
            else CriarConfiguracao("NomeBanco", valor);
        }
        public void AlterarCadeiaConexao(string valor) {
            if (VerificarConfiguracao(NomeBanco)) _arquivoConfiguracao.ConnectionStrings.ConnectionStrings[NomeBanco].ConnectionString = valor;
            else CriarConfiguracao(NomeBanco, valor);
        }

        public void SalvarAlteracoes() {
            _arquivoConfiguracao.Save(ConfigurationSaveMode.Modified);
        }
    }
}
