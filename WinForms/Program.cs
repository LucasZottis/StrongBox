using StrongBox.WinForms.Janelas;
using System;
using System.Windows.Forms;

namespace StrongBox.WinForms {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormBancoDeDados());
            Application.Run(new FormStrongBox());
        }
    }
}
