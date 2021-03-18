using StrongBox.Biblioteca.Classes.Bases;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StrongBox.CamadaModelo {
    public partial class Login : Repositorio {
        public override void Inserir(string pSql) {
            SqlParameter[] sqlParametro = new SqlParameter[6];
            sqlParametro[0] = new SqlParameter("@Usuario", Usuario);
            sqlParametro[1] = new SqlParameter("@Observacao", Observacao);
            sqlParametro[2] = new SqlParameter("@Senha", Senha);
            sqlParametro[3] = new SqlParameter("@Tamanho", Tamanho);
            sqlParametro[4] = new SqlParameter("@TipoSenha", Tipo);
            sqlParametro[5] = new SqlParameter("@CodigoLocal", CodigoLocal);

            using (SqlConnection sqlConexao = new SqlConnection(_sCadeiaConexao)) {
                using (SqlCommand sqlComando = new SqlCommand(pSql, sqlConexao)) {
                    sqlComando.Parameters.AddRange(sqlParametro);
                    sqlConexao.Open();
                    if (sqlComando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi inserido!");
                    sqlConexao.Close();
                }
            }
        }

        public override void Atualizar(string pSql) {
            SqlParameter[] sqlParametro = new SqlParameter[7];
            sqlParametro[0] = new SqlParameter("@Codigo", Codigo);
            sqlParametro[1] = new SqlParameter("@Usuario", Usuario);
            sqlParametro[2] = new SqlParameter("@Observacao", Observacao);
            sqlParametro[3] = new SqlParameter("@Senha", Senha);
            sqlParametro[4] = new SqlParameter("@Tamanho", Tamanho);
            sqlParametro[5] = new SqlParameter("@TipoSenha", Tipo);
            sqlParametro[6] = new SqlParameter("@CodigoLocal", CodigoLocal);
            

            using (SqlConnection sqlConexao = new SqlConnection(_sCadeiaConexao)) {
                using (SqlCommand sqlComando = new SqlCommand(pSql, sqlConexao)) {
                    sqlComando.Parameters.AddRange(sqlParametro);
                    sqlConexao.Open();
                    if (sqlComando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi inserido!");
                    sqlConexao.Close();
                }
            }
        }

        public override DataTable Consultar(string pSql) {
            DataTable dtTabela = new DataTable();
            SqlDataAdapter sqlAdaptador;

            using (SqlConnection sqlConexao = new SqlConnection(_sCadeiaConexao)) {
                using (SqlCommand sqlComando = new SqlCommand(pSql, sqlConexao)) {
                    if (CodigoLocal > 0) sqlComando.Parameters.AddWithValue("@CodigoLocal", CodigoLocal);

                    sqlAdaptador = new SqlDataAdapter(sqlComando);
                    sqlAdaptador.Fill(dtTabela);
                }
            }

            return dtTabela;
        }

        public override void Deletar(string pSql) {
            SqlParameter[] sqlParametro = new SqlParameter[6];
            sqlParametro[0] = new SqlParameter("@Codigo", Codigo);

            using (SqlConnection sqlConexao = new SqlConnection(_sCadeiaConexao)) {
                using (SqlCommand sqlComando = new SqlCommand(pSql, sqlConexao)) {
                    sqlComando.Parameters.AddRange(sqlParametro);
                    sqlConexao.Open();
                    if (sqlComando.ExecuteNonQuery() < 1) throw new Exception("Registro não foi inserido!");
                    sqlConexao.Close();
                }
            }
        }
    }
}
