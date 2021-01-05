using StrongBox.CamadaControle.Controles;
using StrongBox.CamadaControle.Interfaces;
using System;
using System.Data;
using System.Windows.Forms;

namespace StrongBox.WinForms.Janelas {
    public partial class FormStrongBox : Form, ICategoria, ILocal, ILogin {
        private readonly CategoriaControle _categoria;
        private readonly LocalControle _local;
        private readonly LoginControle _login;

        private readonly DataTable _tabCategoria;
        private readonly DataTable _tabLocal;
        private readonly DataTable _tabLogin;

        private string _nome;
        private string _prefixo;
        private string _usuario;
        private string _observacao;
        private string _senha;
        private long _codigoCategoria;
        private long _codigoLocal;
        private long _codigoLogin;
        private int _tipoSenha;
        private byte _tamanho;
        private byte _modo = 0;

        public FormStrongBox() {
            InitializeComponent();
            _categoria = new CategoriaControle(this);
            _local = new LocalControle(this);
            _login = new LoginControle(this);

            _tabCategoria = _categoria.BuscarCategorias();
            _tabLocal = _local.BuscarLocais();
            _tabLogin = _login.BuscarLogins();
        }

        // -------------------------------------------------------------------------------------------------------------

        private void PreencherTabelaCategoria() {
            ClnCodigo.DataPropertyName = _tabCategoria.Columns["CODIGO"].ColumnName;
            ClnNomeCategoria.DataPropertyName = _tabCategoria.Columns["NOME"].ColumnName;
            ClnPrefixo.DataPropertyName = _tabCategoria.Columns["PREFIXO"].ColumnName;
            ClnExcluido.DataPropertyName = _tabCategoria.Columns["EXCLUIDO"].ColumnName;

            DgvCategorias.DataSource = _tabCategoria;
        }
        private void PreencherTabelaLocal() {
            ClnCodigoLocal.DataPropertyName = _tabLocal.Columns["CODIGO"].ColumnName;
            ClnNomeLocal.DataPropertyName = _tabLocal.Columns["NOME"].ColumnName;
            ClnCategoria.DataPropertyName = _tabLocal.Columns["COD_CATEGORIA"].ColumnName;
            ClnLocalExcluido.DataPropertyName = _tabLocal.Columns["EXCLUIDO"].ColumnName;
            ClnNomeCategoriaPorLocal.DataPropertyName = _tabLocal.Columns["NOME1"].ColumnName;

            DgvLocais.DataSource = _tabLocal;
        }
        private void PreencherTabelaLogin() {
            ClnCodigoLogin.DataPropertyName = _tabLogin.Columns["CODIGO"].ColumnName;
            ClnUsuario.DataPropertyName = _tabLogin.Columns["USUARIO"].ColumnName;
            ClnObservacao.DataPropertyName = _tabLogin.Columns["OBS"].ColumnName;
            ClnSenha.DataPropertyName = _tabLogin.Columns["SENHA"].ColumnName;
            ClnTamanho.DataPropertyName = _tabLogin.Columns["TAMANHO"].ColumnName;
            ClnTipoSenha.DataPropertyName = _tabLogin.Columns["TIPO_SENHA"].ColumnName;
            ClnLoginExcluido.DataPropertyName = _tabLogin.Columns["EXCLUIDO"].ColumnName;
            ClnLocal.DataPropertyName = _tabLogin.Columns["COD_LOCAL"].ColumnName;
            ClnLocalPorLogin.DataPropertyName = _tabLogin.Columns["NOME"].ColumnName;

            DgvLogins.DataSource = _tabLogin;
        }

        private void LimparCampos() {
            TxtUsuario.Clear();
            TxtDados.Clear();
            TxtSenha.Clear();
            TxtNomeLocal.Clear();
            TxtNomeCategoria.Clear();
            TxtPrefixo.Clear();

            // Método limpar do controle UcCbxLocal
            UcCategoria.LimparUcCategorias();
            UcLocal.LimparUcLocal();

            NudTamanhoSenha.Value = 4;

            RbtnSenhaAlfabetica.Checked = false;
            RbtnSenhaNumerica.Checked = false;
            RbtnSenhaAlfaNumerica.Checked = false;
        }
        private void LimparDados() {
            _nome = null;
            _prefixo = null;
            _usuario = null;
            _observacao = null;
            _senha = null;
            _codigoCategoria = 0;
            _codigoLocal = 0;
            _codigoLogin = 0;
            _tipoSenha = -1;
            _tamanho = 0;
            _modo = 0;
    }
        private void MarcarTipoSenha(int valor) {
            switch (valor) {
                case 0: RbtnSenhaAlfabetica.Checked = true; break;
                case 1: RbtnSenhaNumerica.Checked = true; break;
                case 2: RbtnSenhaAlfaNumerica.Checked = true; break;
            }
        }
        private int DefinirTipoSenha() {
            if (RbtnSenhaAlfabetica.Checked) return 0;
            if (RbtnSenhaNumerica.Checked) return 1;
            if (RbtnSenhaAlfaNumerica.Checked) return 2;
            return -1;
        }
        private bool VerificarLinhaSelecionada(DataGridView grade) {
            if (grade.CurrentRow == null) {
                throw new Exception("Nenhum registro selecionado");
            } else {
                return true;
            }
        }

        // -------------------------------------------------------------------------------------------------------------

        private void HabilitarMenus(bool habilitar) {
            // Habilita ou desabilita menus.
            this.MsLogins.Enabled = habilitar;
            this.MsLocais.Enabled = habilitar;
            this.MsCategorias.Enabled = habilitar;
        }
        private void HabilitarAdicaoLogin(bool habilitar) {
            this.FlpDadosLogins.Enabled = habilitar;
            this.GbxDadosUsuario.Enabled = habilitar;
            this.GbxDadosSenha.Enabled = habilitar;
        }
        private void HabilitarEdicaoLogin(bool habilitar) {
            this.FlpDadosLogins.Enabled = habilitar;
            this.GbxDadosUsuario.Enabled = habilitar;
        }
        private void HabilitarEdicaoSenha(bool habilitar) {
            this.FlpDadosLogins.Enabled = habilitar;
            this.GbxDadosSenha.Enabled = habilitar;
        }

        // -------------------------------------------------------------------------------------------------------------

        private void FormStrongBox_Load(object sender, EventArgs e) {
            try {
                PreencherTabelaLogin();
                PreencherTabelaLocal();
                PreencherTabelaCategoria();

                NudTamanhoSenha.InterceptArrowKeys = false;
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TcPrincipal_SelectedIndexChanged(object sender, EventArgs e) {
            this.HabilitarMenus(true);
            this.HabilitarAdicaoLogin(false);
            LimparCampos();

            this.FlpDadosLogins.Enabled = false;
            this.FlpDadosLocal.Enabled = false;
            this.FlpDadosCategoria.Enabled = false;

            this.DgvLogins.Enabled = true;
            this.DgvLocais.Enabled = true;
            this.DgvCategorias.Enabled = true;

            UcCategoria.DefinirFonte(_categoria.PreencherComboBox());
        }

        // -------------------------------------------------------------------------------------------------------------

        public long ObterCodigoLogin() => _codigoLogin;
        public string ObterUsuario() => _usuario;
        public string ObterObservacao() => _observacao;
        public string ObterSenha() => _senha;
        public byte ObterTamanho() => _tamanho;
        public int ObterTipoSenha() => _tipoSenha;
        public long ObterLocal() => _codigoLocal;

        // --------------------------------------------------------------------

        private void UcLocal_Leave(object sender, EventArgs e) {
            if (!UcLocal.VerificarSeEstaVazio()) BtnGerarSenha.Enabled = true;
            else BtnGerarSenha.Enabled = false;
        }
        private void TsmAdicionarLogin_Click(object sender, EventArgs e) {
            DgvCategorias.Enabled = false;
            DgvLocais.Enabled = false;
            DgvLogins.Enabled = false;
            GbxDadosSenha.Enabled = true;

            HabilitarEdicaoLogin(true);
            HabilitarMenus(false);

            UcLocal.DefinirFonte(_login.PreecherComboBox());

            _modo = 1;
        }
        private void TsmAlterarLogin_Click(object sender, EventArgs e) {
            DgvCategorias.Enabled = false;
            DgvLocais.Enabled = false;
            DgvLogins.Enabled = false;

            HabilitarEdicaoLogin(true);
            HabilitarMenus(false);

            UcLocal.DefinirFonte(_login.PreecherComboBox());

            if (VerificarLinhaSelecionada(DgvLogins)) {
                _codigoLogin = Convert.ToInt64(DgvLogins.CurrentRow.Cells[0].Value.ToString());
                TxtUsuario.Text = DgvLogins.CurrentRow.Cells[1].Value.ToString().Trim();
                TxtDados.Text = DgvLogins.CurrentRow.Cells[2].Value.ToString().Trim();
                NudTamanhoSenha.Value = Convert.ToByte(DgvLogins.CurrentRow.Cells[4].Value.ToString());
                UcLocal.DefinirLocal(DgvLogins.CurrentRow.Cells[6].Value.ToString().Trim());

                _modo = 2;
            }
        }
        private void TsmAlterarSenha_Click(object sender, EventArgs e) {
            DgvCategorias.Enabled = false;
            DgvLocais.Enabled = false;
            DgvLogins.Enabled = false;
            BtnGerarSenha.Enabled = true;

            HabilitarEdicaoSenha(true);
            HabilitarMenus(false);

            if (VerificarLinhaSelecionada(DgvLogins)) {
                TxtUsuario.Text = DgvLogins.CurrentRow.Cells[1].Value.ToString().Trim();
                TxtDados.Text = DgvLogins.CurrentRow.Cells[2].Value.ToString().Trim();
                TxtSenha.Text = DgvLogins.CurrentRow.Cells[3].Value.ToString().Trim();
                NudTamanhoSenha.Value = Convert.ToByte(DgvLogins.CurrentRow.Cells[4].Value.ToString());
                MarcarTipoSenha(Convert.ToInt32(DgvLogins.CurrentRow.Cells[5].Value.ToString()));
                _codigoLocal = Convert.ToInt64(DgvLogins.CurrentRow.Cells[6].Value.ToString().Trim());

                _modo = 3;
            }
        }
        private void TsmExcluirLogin_Click(object sender, EventArgs e) {
            try {
                if (VerificarLinhaSelecionada(DgvLogins)) {
                    _codigoLogin = Convert.ToInt64(DgvLogins.CurrentRow.Cells[0].Value.ToString());
                    _usuario = DgvLogins.CurrentRow.Cells[1].Value.ToString().Trim();
                    _observacao = DgvLogins.CurrentRow.Cells[2].Value.ToString().Trim();
                    _senha = DgvLogins.CurrentRow.Cells[3].Value.ToString().Trim();
                    _tamanho = Convert.ToByte(DgvLogins.CurrentRow.Cells[4].Value.ToString());
                    _tipoSenha = Convert.ToInt32(DgvLogins.CurrentRow.Cells[5].Value.ToString().Trim());
                    _codigoLocal = Convert.ToInt64(DgvLogins.CurrentRow.Cells[6].Value.ToString().Trim());

                    DialogResult resposta = MessageBox.Show($"Deseja mesmo remover '{_usuario} - {DgvLogins.CurrentRow.Cells[8].Value.ToString().Trim()}'?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes) {
                        _login.Excluir();
                        MessageBox.Show("Registro removido.", "Strong Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                DgvLogins.DataSource = _login.BuscarLogins();
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSalvarLogins_Click(object sender, EventArgs e) {
            try {
                switch (_modo) {
                    case 1: {
                            _usuario = TxtUsuario.Text;
                            _observacao = TxtDados.Text;
                            _tamanho = Convert.ToByte(NudTamanhoSenha.Value);
                            _tipoSenha = DefinirTipoSenha();
                            _senha = TxtSenha.Text;
                            _codigoLocal = UcLocal.ObterLocal();

                            _login.Criar();
                            break;
                        }
                    case 2: {
                            _codigoLogin = Convert.ToInt64(DgvLogins.CurrentRow.Cells[0].Value.ToString());
                            _usuario = TxtUsuario.Text;
                            _observacao = TxtDados.Text;
                            _tamanho = Convert.ToByte(NudTamanhoSenha.Value);
                            _codigoLocal = UcLocal.ObterLocal();

                            _login.AlterarLogin();
                            break;
                        }
                    case 3: {
                            _codigoLogin = Convert.ToInt64(DgvLogins.CurrentRow.Cells[0].Value.ToString());
                            _tamanho = Convert.ToByte(NudTamanhoSenha.Value);
                            _tipoSenha = DefinirTipoSenha();
                            _senha = TxtSenha.Text;
                            _codigoLocal = UcLocal.ObterLocal();

                            _login.AlterarSenha();
                            break;
                        }
                }

                DgvLocais.Enabled = true;
                DgvLogins.Enabled = true;
                DgvCategorias.Enabled = true;
                FlpDadosCategoria.Enabled = false;

                HabilitarMenus(true);
                HabilitarEdicaoLogin(false);
                HabilitarEdicaoSenha(false);
                LimparCampos();
                LimparDados();

                _modo = 0;

                DgvLogins.DataSource = _login.BuscarLogins();
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelarLogins_Click(object sender, EventArgs e) {
            DgvCategorias.Enabled = true;
            DgvLocais.Enabled = true;
            DgvLogins.Enabled = true;
            BtnGerarSenha.Enabled = false;
            this.HabilitarAdicaoLogin(false);
            this.HabilitarEdicaoLogin(false);
            this.HabilitarEdicaoSenha(false);
            this.HabilitarMenus(true);
            this.LimparCampos();
            UcLocal.LimparUcLocal();
        }
        private void BtnGerarSenha_Click(object sender, EventArgs e) {
            switch (_modo) {
                case 1: _codigoLocal = UcLocal.ObterLocal(); break;
                case 2: _codigoLocal = UcLocal.ObterLocal(); break;
                case 3: _codigoLocal = Convert.ToInt64(DgvLogins.CurrentRow.Cells[6].Value.ToString().Trim()); break;
            }
            _tamanho = Convert.ToByte(NudTamanhoSenha.Value);
            _tipoSenha = DefinirTipoSenha();

            TxtSenha.Text = _login.GerarSenha();
        }
        
        // -------------------------------------------------------------------------------------------------------------

        public long ObterCodigoLocal() => _codigoLocal;
        public string ObterNomeLocal() => _nome;
        public long ObterCategoria() => _codigoCategoria;

        // --------------------------------------------------------------------

        private void TsmIncluirLocal_Click(object sender, EventArgs e) {
            DgvCategorias.Enabled = false;
            DgvLogins.Enabled = false;
            FlpDadosLocal.Enabled = true;
            HabilitarMenus(false);
            UcCategoria.DefinirFonte(_categoria.PreencherComboBox());

            _modo = 1;
        }
        private void TsmModificarLocal_Click(object sender, EventArgs e) {
            UcCategoria.DefinirFonte(_categoria.PreencherComboBox());
            _codigoLocal = Convert.ToInt64(DgvLocais.CurrentRow.Cells[0].Value.ToString());
            TxtNomeLocal.Text = DgvLocais.CurrentRow.Cells[1].Value.ToString().Trim();
            UcCategoria.DefinirCategoria(DgvLocais.CurrentRow.Cells[2].Value.ToString());

            DgvCategorias.Enabled = false;
            DgvLocais.Enabled = false;
            DgvLogins.Enabled = false;
            FlpDadosLocal.Enabled = true;

            this.HabilitarMenus(false);

            _modo = 2;
        }
        private void TsmRemoverLocal_Click(object sender, EventArgs e) {
            _codigoLocal = Convert.ToInt64(DgvLocais.CurrentRow.Cells[0].Value.ToString());
            _nome = DgvLocais.CurrentRow.Cells[1].Value.ToString();
            _codigoCategoria = Convert.ToInt64(DgvLocais.CurrentRow.Cells[2].Value.ToString());

            DialogResult resposta = MessageBox.Show($"Deseja mesmo remover '{_nome}'?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes) {
                _local.Remover();
                MessageBox.Show("Registro removido.", "Strong Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DgvLocais.DataSource = _local.BuscarLocais();
        }
        private void BtnSalvarLocal_Click(object sender, EventArgs e) {
            _nome = TxtNomeLocal.Text;
            _codigoCategoria = UcCategoria.ObterCategoria();

            try {
                switch (_modo) {
                    case 1: _local.Incluir(); break;
                    case 2: _local.Modificar(); break;
                }

                DgvLocais.Enabled = true;
                DgvLogins.Enabled = true;
                DgvCategorias.Enabled = true;
                FlpDadosCategoria.Enabled = false;
                GbxDadosDeLocal.Enabled = false;

                HabilitarMenus(true);
                LimparCampos();

                _modo = 0;

                DgvLocais.DataSource = _local.BuscarLocais();
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelarLocal_Click(object sender, EventArgs e) {
            DgvCategorias.Enabled = false;
            DgvLogins.Enabled = false;
            FlpDadosLocal.Enabled = false;
            HabilitarMenus(true);
            LimparCampos();
        }

        // -------------------------------------------------------------------------------------------------------------

        public long ObterCodigoCategoria() => _codigoCategoria;
        public string ObterNomeCategoria() => _nome;
        public string ObterPrefixo() => _prefixo;

        // --------------------------------------------------------------------

        private void TsmCriarCategoria_Click(object sender, EventArgs e) {
            DgvLocais.Enabled = false;
            DgvLogins.Enabled = false;
            FlpDadosCategoria.Enabled = true;

            HabilitarMenus(false);

            _modo = 1;
        }
        private void TsmAlterarCategoria_Click(object sender, EventArgs e) {
            _codigoCategoria = Convert.ToInt64(DgvCategorias.CurrentRow.Cells[0].Value.ToString());
            TxtNomeCategoria.Text = DgvCategorias.CurrentRow.Cells[1].Value.ToString().Trim();
            TxtPrefixo.Text = DgvCategorias.CurrentRow.Cells[2].Value.ToString().Trim();

            DgvLocais.Enabled = false;
            DgvLogins.Enabled = false;
            DgvCategorias.Enabled = false;
            FlpDadosCategoria.Enabled = true;

            HabilitarMenus(false);

            _modo = 2;
        }
        private void TsmExcluirCategoria_Click(object sender, EventArgs e) {
            _codigoCategoria = Convert.ToInt64(DgvCategorias.CurrentRow.Cells[0].Value.ToString());
            _nome = DgvCategorias.CurrentRow.Cells[1].Value.ToString().Trim();
            _prefixo = DgvCategorias.CurrentRow.Cells[2].Value.ToString().Trim();

            DialogResult resposta = MessageBox.Show($"Deseja mesmo remover '{_nome}'?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes) {
                _categoria.Excluir();
                MessageBox.Show("Registro removido.", "Strong Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DgvCategorias.DataSource = _categoria.BuscarCategorias();
        }
        private void BtnSalvarCategoria_Click(object sender, EventArgs e) {
            _nome = TxtNomeCategoria.Text;
            _prefixo = TxtPrefixo.Text;

            try {
                switch (_modo) {
                    case 1: _categoria.Criar(); break;
                    case 2: _categoria.Editar(); break;
                }

                DgvLocais.Enabled = true;
                DgvLogins.Enabled = true;
                DgvCategorias.Enabled = true;
                FlpDadosCategoria.Enabled = false;

                HabilitarMenus(true);
                LimparCampos();

                _modo = 0;

                DgvCategorias.DataSource = _categoria.BuscarCategorias();
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelarCategoria_Click(object sender, EventArgs e) {
            this.DgvLocais.Enabled = true;
            this.DgvLogins.Enabled = true;
            this.FlpDadosCategoria.Enabled = false;
            this.HabilitarMenus(true);
            LimparCampos();
        }
    }
}