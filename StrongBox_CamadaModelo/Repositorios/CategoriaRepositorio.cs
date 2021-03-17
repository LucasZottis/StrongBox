using StrongBox.CamadaModelo.Entidades;
using StrongBox.CamadaModelo.Excecoes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StrongBox.CamadaModelo.Repositorios {
    public class CategoriaRepositorio {
        private static readonly string _cadeiaConexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public static void Inserir(string sql, Categoria categoria) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("Nome", categoria.Nome);
                    comando.Parameters.AddWithValue("Prefixo", categoria.Prefixo);

                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi inserido!");
                    conexao.Close();
                }
            }


        }
        public static void Atualizar(string sql, Categoria categoria) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("@Codigo", categoria.Codigo);
                    comando.Parameters.AddWithValue("@Nome", categoria.Nome);
                    comando.Parameters.AddWithValue("@Prefixo", categoria.Prefixo);

                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new CategoriaException("Registro não foi atualizado!");
                    conexao.Close();
                }
            }
        }
        public static DataTable Consultar(string sql, string nomeTabela) {
            DataTable tabela = new DataTable(nomeTabela);
            SqlDataAdapter adaptador;

            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }

            return tabela;
        }
        public static void Deletar(string sql, Categoria categoria) {
            using (SqlConnection conexao = new SqlConnection(_cadeiaConexao)) {
                using (SqlCommand comando = new SqlCommand(sql, conexao)) {
                    comando.Parameters.AddWithValue("@Codigo", categoria.Codigo);
                    comando.Parameters.AddWithValue("@Excluido", categoria.FoiExcluido());

                    conexao.Open();
                    if (comando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi atualizado!");
                    conexao.Close();
                }
            }
        }
    }
}
