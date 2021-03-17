using StrongBox.WinForms.Janelas;
using System;
using System.Configuration;
using System.Windows.Forms;
using VerificaBanco;

namespace StrongBox.WinForms {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            try {
                BancoDeDados banco = new BancoDeDados(ConfigurationManager.ConnectionStrings[1].ConnectionString);
                if (banco.TestarConexao() == false) Application.Run(new FormVerificaBanco());
                Application.Run(new FormStrongBox());
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Strong Box ::. | Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
