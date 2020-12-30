using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;

namespace StrongBox.WinForms.Janelas {
    public partial class FormBancoDeDados : Form {
        public string CaminhoServidor { get; private set; }
        public string CaminhoBanco { get; private set; }
        public string NomeBanco { get; private set; }
        public string CadeiaConexao { get; private set; }

        private readonly SqlConnectionStringBuilder _construtor = new SqlConnectionStringBuilder();

        public FormBancoDeDados() {
            InitializeComponent();
            CaminhoServidor = BuscarAppSettings("CaminhoServidor");
            CaminhoBanco = BuscarAppSettings("CaminhoBancoDeDados");
            NomeBanco = BuscarAppSettings("NomeBancoDeDados");
            if (!string.IsNullOrEmpty(NomeBanco)) CadeiaConexao = BuscarConnectionStrings(NomeBanco);
        }

        // ------------------------------------------------------------------------

        private void AtualizaCadeiaConexao() {
            // Passa a cadeia de conexão do construtor para a label.
            LblCadeiaConexao.Text = _construtor.ConnectionString;
        }
        private bool VerificaCampos() {
            // Retorna verdadeiro se a caixa de texto CAMINHO e NOME estiverem vazio ou nulos
            return (string.IsNullOrEmpty(TxtCaminhoDb.Text)) && (string.IsNullOrEmpty(TxtNomeDb.Text));
        }
        private bool VerificaBotao(Button botao) {
            // Retorna o estado do botão (se está habilitado ou não).
            return botao.Enabled;
        }

        // ------------------------------------------------------------------------

        private void IniciarServico(string nomeServico, int tempoSegundos) {
            // Instancia um objeto para controle de serviço.
            ServiceController servico = new ServiceController(nomeServico);
            // Determina quanto tempo para concluir a operação.
            TimeSpan tempoLimite = TimeSpan.FromSeconds(tempoSegundos);
            // Inicia o serviço.
            servico.Start();
            // Aguarda até o estado do serviço seja executando ou até que esgote o tempo.
            servico.WaitForStatus(ServiceControllerStatus.Running, tempoLimite);
        }
        private bool VerificaStatusServico(string nomeServico) {
            // Verificar o estado de um serviço especificado, 
            ServiceController servico = new ServiceController(nomeServico);
            // Retornado false caso qualquer coisa diferente de Running.
            if (servico.Status != ServiceControllerStatus.Running) {
                return false;
            } else {
                return true;
            }
        }
        private void PararServico(string nomeServico, int tempoSegundos) {
            // Instancia um objeto para controle de serviço.
            ServiceController servico = new ServiceController(nomeServico);
            // Determina quanto tempo para concluir a operação.
            TimeSpan tempoLimite = TimeSpan.FromSeconds(tempoSegundos);
            // Inicia o serviço.
            servico.Stop();
            // Aguarda até o estado do serviço seja parado ou até que esgote o tempo.
            servico.WaitForStatus(ServiceControllerStatus.Stopped, tempoLimite);
        }

        // ------------------------------------------------------------------------

        public bool VerificaAppSettings(string nomeConfig) {
            // Instancia um objeto para manejamento do arquivo config.
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Instancia um objeto para manejamento da seção de AppSettings.
            var settings = config.AppSettings.Settings;
            // Verifica um configuração informada pelo o usuário,
            // caso não exista a config, retornará false.
            if (settings[nomeConfig] == null) {
                return false;
            } else {
                return true;
            }
        }
        public bool VerificaConnectionStrings(string bancoDados) {
            // Instancia um objeto para manejamento do arquivo config.
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Instancia um objeto para manejamento da seção de AppSettings.
            var connection = config.ConnectionStrings.ConnectionStrings;
            // Verifica um configuração específica informada
            // pelo o usuário, caso não exista a config, retornará false.
            if (connection[bancoDados] == null) {
                return false;
            } else {
                return true;
            }
        }
        private void CriarAppSetting(string nomeConfig, string valor) {
            // Instancia um objeto para manejamento do arquivo config.
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Instancia um objeto para manejamento da seção de AppSettings.
            var settings = config.AppSettings.Settings;
            // Cria uma configuração específicada, informando valor juntamente.
            settings.Add(nomeConfig, valor);
            // Salva o arquivo config.
            config.Save(ConfigurationSaveMode.Modified);
            // Atualiza a seção AppSettings.
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        private void CriarConnectionStrings(string nomeBanco, string cadeiaConexao) {
            // Instancia um objeto para manejamento do arquivo config.
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Instancia um objeto para manejamento da seção de ConnectionStrings.
            var connection = config.ConnectionStrings.ConnectionStrings;
            // Inclui o valor da configuração específicada.
            connection.Add(new ConnectionStringSettings(nomeBanco, cadeiaConexao));
            // Salva o arquivo config.
            config.Save(ConfigurationSaveMode.Modified);
            // Atualiza a seção AppSettings.
            ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.Name);
        }
        private void AlterarAppSettings(string nomeConfig, string valor) {
            // Instancia um objeto para manejamento do arquivo config.
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Instancia um objeto para manejamento da seção de AppSettings.
            var settings = config.AppSettings.Settings;
            // Inclui o valor da configuração específicada.
            settings[nomeConfig].Value = valor;
            // Salva o arquivo config.
            config.Save(ConfigurationSaveMode.Modified);
            // Atualiza a seção AppSettings.
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        private void AlterarConnectionStrings(string nomeBanco, string cadeiaConexao) {
            // Instancia um objeto para manejamento do arquivo config.
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Instancia um objeto para manejamento da seção de ConnectionStrings.
            var connection = config.ConnectionStrings.ConnectionStrings;
            // Inclui o valor da configuração específicada.
            connection[nomeBanco].ConnectionString = cadeiaConexao;
            // Salva o arquivo config.
            config.Save(ConfigurationSaveMode.Modified);
            // Atualiza a seção AppSettings.
            ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.Name);
        }
        private string BuscarAppSettings(string nomeConfig) {
            if (VerificaAppSettings(nomeConfig)) {
                // Retorna o valor da configuração específicada.
                return ConfigurationManager.AppSettings[nomeConfig];
            } else {
                return string.Empty;
            }
        }
        private string BuscarConnectionStrings(string bancoDados) {
            // Retorna o valor da configuração específicada.
            return ConfigurationManager.ConnectionStrings[bancoDados].ConnectionString;
        }

        // ------------------------------------------------------------------------

        private void FormVerificaBanco_Load(object sender, EventArgs e) {
            bool confirmado;
            // Quando carregar o formulário.
            try {
                // Passa os dados do arquivo config.
                TxtDataSource.Text = CaminhoServidor;
                TxtCaminhoDb.Text = CaminhoBanco;
                TxtNomeDb.Text = NomeBanco;
                LblCadeiaConexao.Text = CadeiaConexao;
                // Verifica se a caixa de texto do servidor esta vazia ou nula.
                if (!string.IsNullOrEmpty(TxtDataSource.Text)) {
                    // Caso não esteja, acionará o evento click do confirmar server.
                    this.BtnConfirmarServer_Click(sender, e);
                    // Atribui o valor true para a variável 'confirmado'.
                    confirmado = true;
                } else { confirmado = false; return; }
                // Verifica se as caixas de texto caminho e nome estão vazias ou nulas.
                if (!string.IsNullOrEmpty(TxtCaminhoDb.Text) && (!string.IsNullOrEmpty(TxtNomeDb.Text))) {
                    // Caso estejam, acionará o evento click do botão testar banco.
                    BtnTestarDb_Click(sender, e);
                    // Habilitará o negar banco.
                    BtnNegarDb.Enabled = true;
                    // Desabilitará o testar banco.
                    BtnTestarDb.Enabled = false;
                    // Verifica se houve conexão com o banco.
                    if (LblEstadoConexao.Text == "Confirmado!") { confirmado = true; }
                } else { confirmado = false; return; }
                // Verifica a variável 'confirmado'.
                if (confirmado) {
                    // Fechará esse formulário.
                    Close();
                }
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnConfirmarServer_Click(object sender, EventArgs e) {
            // Confirmando o servidor, será verificado se o campo de texto servidor está vazio ou nulo.
            if (string.IsNullOrEmpty(TxtDataSource.Text)) {
                // Se estiver, aparecerá uma mensagem informando que deve ser preenchido.
                MessageBox.Show("Precisa preencher esse campo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                // Caso contrário, desabilitará o botão confirmar servidor.
                BtnConfirmarServer.Enabled = false;
                // Habilitará o negar servidor.
                BtnNegarServer.Enabled = true;
                // Irá verificar os campos caminho e nome, habilitando o botão buscar banco caso estejam vazios.
                if (VerificaCampos()) BtnBuscarBanco.Enabled = true;
                // Irá verificar os campos caminho e nome, habilitando o botão testar banco caso estejam preenchidos.
                if (!VerificaCampos()) BtnTestarDb.Enabled = true;
                // Irá verificar os campos caminho e nome, habilitando o botão salvar configurações caso estejam preenchidos.
                if (!VerificaCampos()) BtnSalvarConfig.Enabled = true;
                // Desabilitará a caixa de texto servidor.
                TxtDataSource.Enabled = false;
                // Informará o data source da string para o construtor.
                _construtor.DataSource = TxtDataSource.Text;
                // Irá atualiza a string.
                AtualizaCadeiaConexao();
            }
        }
        private void BtnNegarServer_Click(object sender, EventArgs e) {
            // Quando clicado no botão de negar servidor.
            // Será habilitado o botão de confirmar servidor.
            BtnConfirmarServer.Enabled = true;
            // Desabilitado o botão de negar servidor.
            BtnNegarServer.Enabled = false;
            // Desabilitado o botão de buscar banco.
            BtnBuscarBanco.Enabled = false;
            // Verifica o estado do testar banco, caso esteja habilitado, será desabilitado.
            if (VerificaBotao(BtnTestarDb)) BtnTestarDb.Enabled = false;
            // Verifica o estado do salvar configuração, caso esteja habilitado, será desabilitado.
            if (VerificaBotao(BtnSalvarConfig)) BtnSalvarConfig.Enabled = false;
            // Limpará a caixa de texto servidor.
            TxtDataSource.Clear();
            // Habilitará a caixa de texto servidor.
            TxtDataSource.Enabled = true;
            // Limpará o estado do último teste de conexão.
            LblEstadoConexao.Text = null;
            // Limpará o data source da string.
            _construtor.DataSource = string.Empty;
        }
        private void BtnBuscarBanco_Click(object sender, EventArgs e) {
            // Quando clicado para buscar o banco de dados.
            try {
                // Verificará o estado do serviço específicado.
                if (VerificaStatusServico("MSSQL$SQLEXPRESS")) {
                    // Parando o serviço caso esteja em execução.
                    PararServico("MSSQL$SQLEXPRESS", 30);
                }
                // Armazenará o retorno do buscar banco.
                DialogResult busca = OfdBuscarDb.ShowDialog();
                // Verificará se o resulta é OK.
                if (busca == DialogResult.OK) {
                    // Passará o caminho do banco para a caixa de texto caminho.
                    TxtCaminhoDb.Text = OfdBuscarDb.FileName;
                    // Pegará apenas o nome do banco, sem a extensão.
                    TxtNomeDb.Text = Path.GetFileNameWithoutExtension(OfdBuscarDb.FileName);
                    // Habilitará o campo caminnho.
                    TxtCaminhoDb.Enabled = true;
                    // Habilitará o campo nome.
                    TxtNomeDb.Enabled = true;
                    // Habilitará o botão confirmar banco.
                    BtnConfirmarDb.Enabled = true;
                }
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnConfirmarDb_Click(object sender, EventArgs e) {
            TxtCaminhoDb.Enabled = false;
            TxtNomeDb.Enabled = false;

            BtnConfirmarDb.Enabled = false;
            BtnBuscarBanco.Enabled = false;
            BtnNegarDb.Enabled = true;
            BtnTestarDb.Enabled = true;

            _construtor.InitialCatalog = TxtNomeDb.Text;
            AtualizaCadeiaConexao();
        }
        private void BtnNegarDb_Click(object sender, EventArgs e) {
            TxtCaminhoDb.Enabled = true;
            TxtCaminhoDb.Clear();
            TxtNomeDb.Enabled = true;
            TxtNomeDb.Clear();

            BtnBuscarBanco.Enabled = true;
            BtnNegarDb.Enabled = false;
            BtnTestarDb.Enabled = false;
            if (VerificaBotao(BtnSalvarConfig)) BtnSalvarConfig.Enabled = false;

            LblEstadoConexao.Text = null;
            _construtor.InitialCatalog = string.Empty;
        }
        private void BtnTestarDb_Click(object sender, EventArgs e) {
            _construtor.IntegratedSecurity = true;
            AtualizaCadeiaConexao();

            try {
                using (SqlConnection conexao = new SqlConnection(@LblCadeiaConexao.Text)) {
                    if (VerificaStatusServico("MSSQL$SQLEXPRESS") == false) {
                        IniciarServico("MSSQL$SQLEXPRESS", 10000);
                    }
                    if (VerificaStatusServico("MSSQLLaunchpad$SQLEXPRESS") == false) {
                        IniciarServico("MSSQLLaunchpad$SQLEXPRESS", 10000);
                    }

                    conexao.Open();

                    switch (conexao.State) {
                        case ConnectionState.Connecting: {
                                LblEstadoConexao.Text = "Conectando...";
                                break;
                            }
                        case ConnectionState.Open: {
                                LblEstadoConexao.Text = "Conectado!";
                                BtnTestarDb.Enabled = false;
                                BtnSalvarConfig.Enabled = true;
                                break;
                            }
                        case ConnectionState.Broken: {
                                LblEstadoConexao.Text = "Falha!";
                                break;
                            }
                    }

                    conexao.Close();
                }
            } catch (Exception erro) {
                LblEstadoConexao.Text = "Falha!";
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSalvarConfig_Click(object sender, EventArgs e) {
            try {
                if (VerificaAppSettings("CaminhoServidor")) {
                    AlterarAppSettings("CaminhoServidor", TxtDataSource.Text);
                } else {
                    CriarAppSetting("CaminhoServidor", TxtDataSource.Text);
                }

                if (VerificaAppSettings("CaminhoBancoDeDados")) {
                    AlterarAppSettings("CaminhoBancoDeDados", TxtCaminhoDb.Text);
                } else {
                    CriarAppSetting("CaminhoBancoDeDados", TxtCaminhoDb.Text);
                }

                if (VerificaAppSettings("NomeBancoDeDados")) {
                    AlterarAppSettings("NomeBancoDeDados", TxtNomeDb.Text);
                } else {
                    CriarAppSetting("NomeBancoDeDados", TxtNomeDb.Text);
                }

                if (VerificaConnectionStrings(TxtNomeDb.Text)) {
                    AlterarConnectionStrings(TxtNomeDb.Text, LblCadeiaConexao.Text);
                } else {
                    CriarConnectionStrings(TxtNomeDb.Text, LblCadeiaConexao.Text);
                }

                MessageBox.Show("Concluído!", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}