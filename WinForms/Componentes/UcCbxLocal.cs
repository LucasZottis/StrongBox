using System;
using System.Data;
using System.Windows.Forms;

namespace StrongBox.WinForms.Componentes {
    public partial class UcCbxLocal : UserControl {
        private DataTable _tabela;
        private string _codigoLocal;

        public UcCbxLocal() {
            InitializeComponent();
            Anchor = AnchorStyles.Left;
            Anchor = AnchorStyles.Top;
            Anchor = AnchorStyles.Right;
        }

        private void UcCbxLocal_Enter(object sender, System.EventArgs e) {
            CbxLocais.DataSource = _tabela;
            CbxLocais.ValueMember = "CODIGO";
            CbxLocais.DisplayMember = "NOME";

            TxtCodigoLocal.Text = _codigoLocal;
            CbxLocais.SelectedIndex = -1;
        }
        private void TxtCodigoLocal_Leave(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(TxtCodigoLocal.Text)) CbxLocais.SelectedValue = int.Parse(TxtCodigoLocal.Text);
            else CbxLocais.SelectedIndex = -1;
        }
        private void CbxLocais_SelectedIndexChanged(object sender, EventArgs e) {
            if (CbxLocais.SelectedIndex > -1) {
                TxtCodigoLocal.Text = CbxLocais.SelectedValue.ToString();
            }
        }

        public void DefinirFonte(DataTable tabela) {
            _tabela = tabela;
        }
        public void DefinirLocal(string codigoCategoria) {
            _codigoLocal = codigoCategoria;
        }
        public long ObterLocal() {
            return Convert.ToInt64(CbxLocais.SelectedValue);
        }
        public void LimparUcLocal() {
            TxtCodigoLocal.Clear();
            CbxLocais.SelectedIndex = -1;
        }
        public bool VerificarSeEstaVazio() {
            return (!string.IsNullOrEmpty(TxtCodigoLocal.Text)) && CbxLocais.SelectedIndex < 1;
        }
    }
}
