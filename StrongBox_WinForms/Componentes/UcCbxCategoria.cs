using System;
using System.Data;
using System.Windows.Forms;

namespace StrongBox.WinForms.Componentes {
    public partial class UcCbxCategoria : UserControl {
        private DataTable _tabela;
        private string _codigoCategoria;

        public UcCbxCategoria() {
            InitializeComponent();
            Anchor = AnchorStyles.Left;
            Anchor = AnchorStyles.Top;
            Anchor = AnchorStyles.Right;
        }

        private void UcCbxCategoria_Enter(object sender, System.EventArgs e) {
            CbxCategoria.DataSource = _tabela;
            CbxCategoria.ValueMember = "CODIGO";
            CbxCategoria.DisplayMember = "NOME";

            TxtCodigoCategoria.Text = _codigoCategoria;
            CbxCategoria.SelectedIndex = -1;
        }
        private void TxtCodigoCategoria_Leave(object sender, System.EventArgs e) {
            if (!string.IsNullOrEmpty(TxtCodigoCategoria.Text)) CbxCategoria.SelectedValue = int.Parse(TxtCodigoCategoria.Text);
            else CbxCategoria.SelectedIndex = -1;
        }
        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e) {
            if (CbxCategoria.SelectedIndex > -1) {
                TxtCodigoCategoria.Text = CbxCategoria.SelectedValue.ToString();
            }
        }

        public void DefinirFonte(DataTable tabela) {
            _tabela = tabela;
        }
        public void DefinirCategoria(string codigoCategoria) {
            _codigoCategoria = codigoCategoria;
        }
        public long ObterCategoria() {
            return Convert.ToInt64(CbxCategoria.SelectedValue);
        }
        public void LimparUcCategorias() {
            TxtCodigoCategoria.Clear();
            CbxCategoria.SelectedIndex = -1;
        }
        public bool VerificarSeEstaVazio() {
            return (!string.IsNullOrEmpty(TxtCodigoCategoria.Text)) && CbxCategoria.SelectedIndex < 1;
        }
    }
}
