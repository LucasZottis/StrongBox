namespace StrongBox.Biblioteca.Classes.Estaticas {
    public static class ComandosSql {
        #region Comandos INSERT

        public static readonly string InserirLogin = "INSERT INTO LOGIN " +
                                                            "(USUARIO, " +
                                                            "OBS, " +
                                                            "SENHA, " +
                                                            "TAMANHO, " +
                                                            "TIPO_SENHA, " +
                                                            "COD_LOCAL) " +
                                                        "VALUES " +
                                                            "(@Usuario, " +
                                                            "@Observacao, " +
                                                            "@Senha, " +
                                                            "@Tamanho, " +
                                                            "@TipoSenha, " +
                                                            "@CodigoLocal)";

        public static readonly string InserirLocal = "INSERT INTO LOCAL " +
                                                            "(NOME, " +
                                                            "COD_CATEGORIA) " +
                                                        "VALUES " +
                                                            "(@Nome, " +
                                                            "@CodigoCategoria)";

        public static readonly string InserirCategoria = "INSERT INTO CATEGORIA " +
                                                                "(NOME, " +
                                                                "PREFIXO) " +
                                                            "VALUES " +
                                                                "(@Nome, " +
                                                                "@Prefixo)";

        #endregion

        #region Comandos UPDATE

        public static readonly string AtualizarLogin = "UPDATE " +
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

        public static readonly string AtualizarLocal = "UPDATE " +
                                                            "LOCAL " +
                                                          "SET " +
                                                            "NOME = @Nome, " +
                                                            "COD_CATEGORIA = @CodigoCategoria, " +
                                                          "WHERE " +
                                                            "CODIGO = @Codigo";

        public static readonly string AtualizarCategoria = "UPDATE " +
                                                                "CATEGORIA " +
                                                              "SET " +
                                                                "NOME = @Nome, " +
                                                                "PREFIXO = @Prefixo, " +
                                                              "WHERE " +
                                                                "CODIGO = @Codigo";

        #endregion

        #region Comandos SELECT

        #region Logins

        public static readonly string BuscarLogins = "SELECT " +
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

        public static readonly string BuscarPrefixo = "SELECT " +
                                                        "CATEGORIA.PREFIXO, " +
                                                      "FROM " +
                                                        "CATEGORIA " +
                                                        "INNER JOIN LOCAL ON LOCAL.CODIGO = @CodigoLocal " +
                                                      "WHERE " +
                                                        "CATEGORIA.CODIGO = LOCAL.COD_CATEGORIA";

        #endregion

        #region Local

        public static readonly string BuscarLocais = "SELECT " +
                                                    "CODIGO, " +
                                                    "NOME, " +
                                                    "COD_CATEGORIA, " +
                                                    "CATEGORIA.NOME " +
                                                "FROM " +
                                                    "LOCAL " +
                                                    "INNER JOIN CATEGORIA ON CATEGORIA.CODIGO = LOCAL.COD_CATEGORIA";

        #endregion

        #region Categoria

        public static readonly string BuscarCategorias = "SELECT " +
                                                                "NOME, " +
                                                                "PREFIXO " +
                                                            "FROM " +
                                                                "CATEGORIA";

        public static readonly string BuscarRegistrosRelacionados = "SELECT " +
                                                                        "LOGIN.CODIGO, " +
                                                                    "FROM " +
                                                                        "LOGIN " +
                                                                        "INNER JOIN LOCAL ON LOCAL.CODIGO = LOGIN.COD_LOCAL " +
                                                                        "INNER JOIN CATEGORIA ON CATEGORIA.CODIGO = LOCAL.COD_CATEGORIA " +
                                                                    "WHERE " +
                                                                        "CATEGORIA.CODIGO = @Codigo";
        #endregion

        #endregion

        #region Comandos DELETE

        public static readonly string DeletarLogin = "DELETE " +
                                                            "LOGIN " +
                                                        "WHERE " +
                                                            "CODIGO = @Codigo";

        public static readonly string DeletarLocal = "DELETE " +
                                                            "LOCAL " +
                                                         "WHERE " +
                                                            "CODIGO = @Codigo";

        public static readonly string DeletarCategoria = "DELETE " +
                                                                "CATEGORIA " +
                                                             "WHERE " +
                                                                "CODIGO = @Codigo";


        #endregion
    }
}
