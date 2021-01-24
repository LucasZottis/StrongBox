using StrongBox.CamadaModelo.Entidades;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StrongBox.CamadaModelo.Repositorios {
    public class LoginRepositorio {
        private static readonly string _cadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public static void Inserir(string sql, Login login) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("@Usuario", login.Usuario);
                    comando.Parameters.AddWithValue("@Observacao", login.Observacao);
                    comando.Parameters.AddWithValue("@Senha", login.Senha);
                    comando.Parameters.AddWithValue("@Tamanho", login.Tamanho);
                    comando.Parameters.AddWithValue("@TipoSenha", login.TipoSenha);
                    comando.Parameters.AddWithValue("@CodigoLocal", login.CodigoLocal);

                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi inserido!");
                    conexao.Close();
                }
            }
        }
        public static void Atualizar(string sql, Login login) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("@Codigo", login.Codigo);
                    if (!string.IsNullOrEmpty(login.Usuario)) comando.Parameters.AddWithValue("@Usuario", login.Usuario);
                    if (!string.IsNullOrEmpty(login.Observacao)) comando.Parameters.AddWithValue("@Observacao", login.Observacao);
                    if (!string.IsNullOrEmpty(login.Senha)) comando.Parameters.AddWithValue("@Senha", login.Senha);
                    comando.Parameters.AddWithValue("@Tamanho", login.Tamanho);
                    comando.Parameters.AddWithValue("@TipoSenha", login.TipoSenha);
                    comando.Parameters.AddWithValue("@CodigoLocal", login.CodigoLocal);
                    
                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi atualizado!");
                    conexao.Close();
                }
            }
        }
        public static DataTable Consultar(string sql) {
            DataTable tabela = new DataTable("LOGIN");
            SqlDataAdapter adaptador;

            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }

            return tabela;
        }
        public static void Deletar(string sql, Login login) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("@Codigo", login.Codigo);
                    comando.Parameters.AddWithValue("@Excluido", login.FoiExcluido());

                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi atualizado!");
                    conexao.Close();
                }
            }
        }
    }
}
