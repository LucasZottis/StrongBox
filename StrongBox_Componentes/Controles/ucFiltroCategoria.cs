using StrongBox.Biblioteca.Classes.Estaticas;
using System.Data;
using System.Windows.Forms;

namespace StrongBox_Componentes.Controles
{
    public partial class ucFiltroCategoria : UserControl {
        #region Propriedades e Atributos

        public DataTable FonteDados 
        { 
            private get 
            { 
                return FonteDados; 
            } 
            set 
            { 
                FonteDados = value; 
            } 
        }

        public int Categoria 
        { 
            get 
            { 
                return cbxCategoria.SelectedValue.ParaInt(); 
            } 

            set
            {
                Categoria = txtCodigo.Text.ParaInt();
            }
        }

        #endregion

        #region Construtores

        public ucFiltroCategoria() {
            InitializeComponent();
        }


        #endregion

        #region Eventos

        private void ucFiltroCategoria_KeyDown( object sender, KeyEventArgs e )
        {
            if (e.KeyCode == Keys.F3)
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    cbxCategoria.DataSource = FonteDados;
                }
                else
                {
                    cbxCategoria.DataSource = FonteDados.Select( $"CODIGO = {txtCodigo.Text}" );
                }
            }
        }

        #endregion
    }
}
