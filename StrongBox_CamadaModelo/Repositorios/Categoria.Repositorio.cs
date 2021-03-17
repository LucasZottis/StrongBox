using StrongBox.Biblioteca.Classes.Bases;
using StrongBox.CamadaModelo.Excecoes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StrongBox.CamadaModelo {
    public partial class Categoria : Repositorio {
        public override void Inserir(string pSql) {
            SqlParameter[] sqlParametro = new SqlParameter[2];
            sqlParametro[0] = new SqlParameter("@Nome", Nome);
            sqlParametro[1] = new SqlParameter("@Prefixo", Prefixo);

            using (SqlConnection sqlConexao = new SqlConnection(_sCadeiaConexao)) {
                using (SqlCommand sqlComando = new SqlCommand(pSql, sqlConexao)) {
                    sqlConexao.Open();
                    if (sqlComando.ExecuteNonQuery() < 1) throw new CategoriaException("Não foi possível criar a categoria!");
                    sqlConexao.Close();
                }
            }
        }

        public override void Atualizar(string pSql) {
            SqlParameter[] sqlParametro = new SqlParameter[3];
            sqlParametro[0] = new SqlParameter("@Codigo", Codigo);
            sqlParametro[1] = new SqlParameter("@Nome", Nome);
            sqlParametro[2] = new SqlParameter("@Prefixo", Prefixo);

            using (SqlConnection sqlConexao = new SqlConnection(_sCadeiaConexao)) {
                using (SqlCommand sqlComando = new SqlCommand(pSql, sqlConexao)) {
                    sqlConexao.Open();
                    if (sqlComando.ExecuteNonQuery() < 1) throw new CategoriaException("Não foi possível alterar a categoria!");
                    sqlConexao.Close();
                }
            }
        }

        public override DataTable Consultar(string pSql) {
            DataTable dtTabela = new DataTable();
            SqlDataAdapter sqlAdaptador;

            using (SqlConnection sqlConexao = new SqlConnection(_sCadeiaConexao)) {
                using (SqlCommand sqlComando = new SqlCommand(pSql, sqlConexao)) {
                    sqlAdaptador = new SqlDataAdapter(sqlComando);
                    sqlAdaptador.Fill(dtTabela);
                }
            }

            return dtTabela;
        }

        public override void Deletar(string pSql) {
            using (SqlConnection sqlConexao = new SqlConnection(_sCadeiaConexao)) {
                using (SqlCommand sqlComando = new SqlCommand(pSql, sqlConexao)) {
                    sqlComando.Parameters.AddWithValue("@Codigo", Codigo);
                    sqlConexao.Open();
                    if (sqlComando.ExecuteNonQuery() < 1) throw new Exception("Não foi possível deletar categoria!");
                    sqlConexao.Close();
                }
            }
        }
    }
}
