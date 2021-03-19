using MaterialSkin;
using MaterialSkin.Controls;
using StrongBox.Biblioteca.Classes.Estaticas;
using StrongBox.Biblioteca.Enums;
using StrongBox.CamadaControle.Controles;
using StrongBox.CamadaControle.Interfaces;
using StrongBox.Exceptions;
using System;
using System.Text;
using System.Windows.Forms;

namespace StrongBox.WinForms.Categoria {
    public partial class FormCategoria : MaterialForm, ICategoria {
        #region Propriedades e Atributos

        private StringBuilder _sbMensagem;

        private ModoJanela _eModo;
        private CategoriaControlador _ctControlador;
        private MaterialSkinManager _msTema;
        private Primary _eBarra;
        private Primary _eFaixa;

        #endregion

        #region Construtores

        public FormCategoria()
        {
            InitializeComponent();

            _eModo = ModoJanela.Inclusao;

            _eBarra = Primary.Grey800;
            _eFaixa = Primary.Grey100;

            _msTema = MaterialSkinManager.Instance;
            ConfigurarFormulario();

            _ctControlador = new CategoriaControlador(this);
        }

        #endregion

        #region Métodos de Interface

        public int ObterCodigo() => dgvListaCategoria.CurrentRow.Cells[0].Value.ParaInt();

        public string ObterNomeCategoria() => txtNome.Text;

        public string ObterPrefixo() => txtPrefixo.Text;

        #endregion

        #region Métodos Privados

        private void ConfigurarFormulario()
        {
            _msTema.AddFormToManage(this);
            _msTema.Theme = MaterialSkinManager.Themes.DARK;
            _msTema.ColorScheme = new ColorScheme(_eFaixa, _eBarra, Primary.Red800, Accent.Yellow200, TextShade.BLACK);
        }

        private void MontarMensagem(string pNomeCategoria)
        {
            _sbMensagem = new StringBuilder();

            _sbMensagem.Append("Essa categoria tem locais ou logins relacionados.");
            _sbMensagem.Append("Troque a categoria relacionado à esses login(s) e/ou locai(s) antes de prosseguir, ");
            _sbMensagem.AppendLine("caso deseje continuar com a exclusão serão excluídos juntamente com a categoria.");
            _sbMensagem.AppendLine($@"Deseja mesmo deletar a categoria ""{pNomeCategoria}""?");
        }

        private string PegarNomeDoGrid() => dgvListaCategoria.CurrentRow.Cells[1].Value.ToString();

        private string PegarPrefixoDoGrid() => dgvListaCategoria.CurrentRow.Cells[2].Value.ToString();

        private void HabilitarDesabilitarGrid()
        {
            switch (_eModo)
            {
                case ModoJanela.Inclusao: { dgvListaCategoria.Enabled = true; break; }
                case ModoJanela.Alteracao: { dgvListaCategoria.Enabled = false; break; }
            }
        }

        private void LimparDados()
        {
            txtNome.Clear();
            txtPrefixo.Clear();
        }

        private bool TemLinhaSelecionada() => dgvListaCategoria.CurrentRow != null;

        #endregion

        #region Eventos

        private void FormCategoria_Load(object sender, System.EventArgs e)
        {
            dgvListaCategoria.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool bExecutou = true;
            switch (_eModo)
            {
                case ModoJanela.Inclusao:
                {
                    try
                    {
                        _ctControlador.Criar();
                        MessageBox.Show("Sucesso!", ".:: Strong Box ::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (CategoriaException aviso)
                    {
                        MessageBox.Show(aviso.Message, ".:: Strong Box ::. | Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bExecutou = false;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, ".:: Strong Box ::. | Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (!bExecutou)
                        {
                            _eModo = ModoJanela.Inclusao;
                        }
                        else
                        {
                            LimparDados();
                        }

                        HabilitarDesabilitarGrid();
                    }

                    break;
                }
                case ModoJanela.Alteracao:
                {
                    try
                    {
                        _ctControlador.Editar();
                        MessageBox.Show("Sucesso!", ".:: Strong Box ::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (CategoriaException aviso)
                    {
                        MessageBox.Show(aviso.Message, ".:: Strong Box ::. | Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bExecutou = false;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, ".:: Strong Box ::. | Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (!bExecutou)
                        {
                            _eModo = ModoJanela.Alteracao;
                        }
                        else
                        {
                            LimparDados();
                        }

                        HabilitarDesabilitarGrid();
                    }

                    break;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TemLinhaSelecionada())
            {
                _eModo = ModoJanela.Alteracao;

                txtNome.Text = PegarNomeDoGrid();
                txtPrefixo.Text = PegarPrefixoDoGrid();

                HabilitarDesabilitarGrid();
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if (TemLinhaSelecionada() && _ctControlador.VerificarRegistrosRelacionados())
            {
                MontarMensagem(dgvListaCategoria.CurrentRow.Cells[1].Value.ToString());
                DialogResult resposta = MessageBox.Show(_sbMensagem.ToString(), ".:: Strong Box ::. | Excluir Categoria", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (resposta == DialogResult.OK || resposta == DialogResult.Yes)
                {
                    try
                    {
                        _ctControlador.Excluir();
                    }
                    catch (CategoriaException aviso)
                    {
                        MessageBox.Show(aviso.Message, ".:: Strong Box ::. | Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, ".:: Strong Box ::. | Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}