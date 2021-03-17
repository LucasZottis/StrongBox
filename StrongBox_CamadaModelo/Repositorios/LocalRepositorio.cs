using StrongBox.CamadaModelo.Entidades;
using StrongBox.CamadaModelo.Excecoes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StrongBox.CamadaModelo.Repositorios {
    public class LocalRepositorio {
        private static readonly string _cadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public static void Inserir(string sql, Local local) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("@Nome", local.Nome);
                    comando.Parameters.AddWithValue("@CodigoCategoria", local.CodigoCategoria);

                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new LocalException("Registro não foi inserido!");
                    conexao.Close();
                }
            }
        }
        public static void Atualizar(string sql, Local local) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("@Codigo", local.Codigo);
                    comando.Parameters.AddWithValue("@Nome", local.Nome);
                    comando.Parameters.AddWithValue("@CodigoCategoria", local.CodigoCategoria);

                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new LocalException("Registro não foi atualizado!");
                    conexao.Close();
                }
            }
        }
        public static DataTable Consultar(string sql) {
            DataTable tabela = new DataTable("LOCAL");
            SqlDataAdapter adaptador;

            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }

            return tabela;
        }
        public static void Deletar(string sql, Local local) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("@Codigo", local.Codigo);
                    comando.Parameters.AddWithValue("@Excluido", local.FoiExcluido());

                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi atualizado!");
                    conexao.Close();
                }
            }
        }
    }
}
