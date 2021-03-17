namespace StrongBox.Biblioteca.Classes.Estaticas {
    public static class ComandosSql {
        #region Comandos INSERT

        private static readonly string _sInserirLogin = "INSERT INTO LOGIN " +
                                                    "(USUARIO, OBS, SENHA, TAMANHO, TIPO_SENHA, COD_LOCAL) " +
                                                "VALUES " +
                                                    "(@Usuario, @Observacao, @Senha, @Tamanho, @TipoSenha, @CodigoLocal)";

        private static readonly string _sInserirLocal = "INSERT INTO LOCAL " +
                                                            "(NOME, COD_CATEGORIA) " +
                                                        "VALUES " +
                                                            "(@Nome, @CodigoCategoria)";

        private static readonly string _sInserirCategoria = "INSERT INTO CATEGORIA " +
                                                                "(NOME, PREFIXO) " +
                                                            "VALUES " +
                                                                "(@Nome, @Prefixo)";

        #endregion

        #region Comandos UPDATE

        private static readonly string _sAtualizarLogin = "UPDATE " +
                                                            "LOGIN " +
                                                          "SET " +
                                                            "USUARIO = @Usuario, " +
                                                            "OBS = @Observacao, " +
                                                            "SENHA = @Senha " +             
                                                            "TAMANHO = @Tamanho, " +
                                                            "TIPO_SENHA = @Tipo " +
                                                            "COD_LOCAL = @CodigoLocal " +
                                                          "WHERE " +
                                                            "CODIGO = @Codigo";

        private static readonly string _sAtualizarLocal = "UPDATE " +
                                                            "LOCAL " +
                                                          "SET " +
                                                            "NOME = @Nome, " +
                                                            "COD_CATEGORIA = @CodigoCategoria, " +
                                                          "WHERE " +
                                                            "CODIGO = @Codigo";

        private static readonly string _sAtualizarCategoria = "UPDATE " +
                                                                "CATEGORIA " +
                                                              "SET " +
                                                                "NOME = @Nome, " +
                                                                "PREFIXO = @Prefixo, " +
                                                              "WHERE " +
                                                                "CODIGO = @Codigo";

        #endregion

        #region Comandos SELECT

        private static readonly string _sBuscarLogins = "SELECT " +
                                                    "USUARIO, " +
                                                    "OBS, " +
                                                    "SENHA, " +
                                                    "TAMANHO, " +
                                                    "TIPO_SENHA, " +
                                                    "COD_LOCAL, " +
                                                    "LOCAL.NOME " +
                                                "FROM " +
                                                    "LOGIN " +
                                                    "INNER JOIN LOCAL ON LOCAL.CODIGO = LOGIN.COD_LOCAL";

        private static readonly string _sBuscarLocais = "SELECT " +
                                                            "NOME, " +
                                                            "COD_CATEGORIA, " +
                                                            "CATEGORIA.NOME " +
                                                        "FROM " +
                                                            "LOCAL " +
                                                            "INNER JOIN CATEGORIA ON CATEGORIA.CODIGO = LOCAL.COD_LOCAL";

        private static readonly string _sBuscarCategorias = "SELECT " +
                                                                "NOME, " +
                                                                "PREFIXO " +
                                                            "FROM " +
                                                                "CATEGORIA";

        #endregion

        #region Comandos DELETE

        private static readonly string _sDeletarLogin = "DELETE " +
                                                            "LOGIN " +
                                                        "WHERE " +
                                                            "CODIGO = @Codigo";

        private static readonly string _sDeletarLocal = "DELETE " +
                                                            "LOCAL " +
                                                         "WHERE " +
                                                            "CODIGO = @Codigo";

        private static readonly string _sDeletarCategoria = "DELETE " +
                                                                "CATEGORIA " +
                                                             "WHERE " +
                                                                "CODIGO = @Codigo";


        #endregion
    }
}
