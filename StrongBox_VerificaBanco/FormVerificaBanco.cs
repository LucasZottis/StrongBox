using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace VerificaBanco {
    public partial class FormVerificaBanco : Form {
        private readonly SqlConnectionStringBuilder _construtor = new SqlConnectionStringBuilder();
        private Configuracao _arquivoConfiguracao;
        private bool _debug = false;

        public FormVerificaBanco() {
            InitializeComponent();
#if (DEBUG)
            _debug = true;
#endif
            if (_debug) {
                _arquivoConfiguracao = new Configuracao(Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + @"\StrongBox.exe");
            } else {
                _arquivoConfiguracao = new Configuracao(Environment.CurrentDirectory + @"\StrongBox.exe");
            }
        }

        // ------------------------------------------------------------------------

        private void AtualizaLabelCadeiaConexao() {
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

        private void FormVerificaBanco_Load(object sender, EventArgs e) {            
            // Quando carregar o formulário.
            try {
                // Passa os dados do arquivo config.
                TxtDataSource.Text = _arquivoConfiguracao.CaminhoServidor;
                TxtCaminhoDb.Text = _arquivoConfiguracao.CaminhoBanco;
                TxtNomeDb.Text = _arquivoConfiguracao.NomeBanco;
                LblCadeiaConexao.Text = _arquivoConfiguracao.CadeiaConexao;

                // Verifica se a caixa de texto do servidor esta vazia ou nula.
                if (!string.IsNullOrEmpty(TxtDataSource.Text)) {
                    // Caso não esteja, acionará o evento click do confirmar server.
                    this.BtnConfirmarServer_Click(sender, e);
                }

                // Verifica se as caixas de texto caminho e nome estão vazias ou nulas.
                if (!string.IsNullOrEmpty(TxtCaminhoDb.Text) && (!string.IsNullOrEmpty(TxtNomeDb.Text))) {
                    // Caso não estejam, acionará o evento click do botão Confirmar banco.
                    BtnConfirmarDb_Click(sender, e);
                    // Caso não estejam, acionará o evento click do botão testar banco.
                    BtnTestarDb_Click(sender, e);
                }                
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Verificar Banco ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                AtualizaLabelCadeiaConexao();
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
                if (Servico.VerificaStatusServico("MSSQL$SQLEXPRESS")) {
                    // Parando o serviço caso esteja em execução.
                    Servico.PararServico("MSSQL$SQLEXPRESS", 30);
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
            AtualizaLabelCadeiaConexao();
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
            AtualizaLabelCadeiaConexao();

            try {
                BancoDeDados banco = new BancoDeDados(LblCadeiaConexao.Text);
                bool testeBanco = banco.TestarConexao();
                LblEstadoConexao.Text = banco.ResultadoTeste;
                if (testeBanco == true) {
                    BtnTestarDb.Enabled = false;
                    BtnSalvarConfig.Enabled = true;
                }
            } catch (Exception erro) {
                LblEstadoConexao.Text = "Falha!";
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSalvarConfig_Click(object sender, EventArgs e) {
            try {
                _arquivoConfiguracao.AlterarCaminhoServidor(TxtDataSource.Text);
                _arquivoConfiguracao.AlterarCaminhoBancoDados(TxtCaminhoDb.Text);
                _arquivoConfiguracao.AlterarNomeBancoDados(TxtNomeDb.Text);
                _arquivoConfiguracao.AlterarCadeiaConexao(LblCadeiaConexao.Text);
                _arquivoConfiguracao.SalvarAlteracoes();

                MessageBox.Show("Concluído!", ".:: Verifica Banco ::.", MessageBoxButtons.OK);
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Verifica Banco ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}