using StrongBox.Biblioteca.Classes.Estaticas;
using System;
using System.Data;
using System.Windows.Forms;

namespace StrongBox_Componentes.Controles {
    public partial class ucFiltroLocal : UserControl {
        #region Propriedades e Atributos

        public DataTable FonteDados {
            private get {
                return FonteDados;
            }

            set {
                FonteDados = value;
            }
        }

        public int Local { 
            get {
                return cbxLocal.SelectedValue.ParaInt();
            }

            set {
                Local = txtCodigo.Text.ParaInt();
            }
        }

        #endregion

        #region Construtores

        public ucFiltroLocal() {
            InitializeComponent();

            cbxLocal.DisplayMember = "NOME";
            cbxLocal.ValueMember = "CODIGO";
        }

        #endregion

        #region Eventos

        private void uFiltroLocal_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F3) {
                if (string.IsNullOrEmpty(txtCodigo.Text)) {
                    cbxLocal.DataSource = FonteDados;
                } else {
                    cbxLocal.DataSource = FonteDados.Select($"CODIGO = {txtCodigo.Text}");
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsLetter(e.KeyChar)) {
                MessageBox.Show("Apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Clear();
            }
        }

        #endregion
    }
}
