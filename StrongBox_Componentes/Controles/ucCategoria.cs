using StrongBox.Biblioteca.Classes.Estaticas;
using System;
using System.Data;
using System.Windows.Forms;

namespace StrongBox_Componentes.Controles {
    public partial class ucCategoria : UserControl {
        #region Propriedades e Atributos

        public DataTable FonteDados {
            get {
                return FonteDados;
            }

            set {
                FonteDados = value;
            }
        }

        public int Categoria {
            get {
                return cbxCategoria.SelectedValue.ParaInt();
            }
            set {
                Categoria = txtCodigo.Text.ParaInt();
            } 
        }

        #endregion

        #region Construtores

        public ucCategoria() {
            InitializeComponent();

            cbxCategoria.DisplayMember = "NOME";
            cbxCategoria.ValueMember = "CODIGO";
        }

        #endregion

        #region Eventos

        private void ucCategoria_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F3) {
                if (string.IsNullOrEmpty(txtCodigo.Text)) {
                    cbxCategoria.DataSource = FonteDados;
                } else {
                    cbxCategoria.DataSource = FonteDados.Select($"CODIGO = {txtCodigo.Text}");
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
