using System.Data;
using System.Data.SqlClient;

namespace VerificaBanco {
    public class BancoDeDados {
        public string CadeiaConexao { get; private set; }
        public string ResultadoTeste { get; private set; }

        public BancoDeDados(string cadeiaConexao) {
            CadeiaConexao = cadeiaConexao;
        }

        public bool TestarConexao() {
            using (SqlConnection conexao = new SqlConnection(CadeiaConexao)) {
                if (Servico.VerificaStatusServico("MSSQL$SQLEXPRESS") == false) {
                    Servico.IniciarServico("MSSQL$SQLEXPRESS", 10000);
                }
                if (Servico.VerificaStatusServico("MSSQLLaunchpad$SQLEXPRESS") == false) {
                    Servico.IniciarServico("MSSQLLaunchpad$SQLEXPRESS", 10000);
                }

                conexao.Open();

                switch (conexao.State) {
                    case ConnectionState.Connecting: {
                            conexao.Close();
                            ResultadoTeste = "Tentando conexão.";
                            return false;
                        }
                    case ConnectionState.Open: {
                            ResultadoTeste = "Conectado!";
                            conexao.Close();
                            return true;
                        }
                    case ConnectionState.Broken: {
                            ResultadoTeste = "Falhou!";
                            conexao.Close();
                            return false;
                        }
                    default: return false;
                }

            }
        }
    }
}
