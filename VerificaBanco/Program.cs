using System;
using System.IO;
using System.Windows.Forms;

namespace VerificaBanco {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            try {
                Application.Run(new FormVerificaBanco());
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Verifica Banco ::. | Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
