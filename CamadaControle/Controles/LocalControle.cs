using StrongBox.CamadaControle.Interfaces;
using StrongBox.CamadaModelo.Entidades;
using StrongBox.CamadaModelo.Repositorios;
using System.Data;

namespace StrongBox.CamadaControle.Controles {
    public class LocalControle {
        private readonly ILocal _form;

        private static readonly string _sqlInserir = "INSERT INTO LOCAL (NOME, COD_CATEGORIA) VALUES (@Nome, @CodigoCategoria)";
        private static readonly string _sqlAtualizar = "UPDATE LOCAL SET NOME = @Nome, COD_CATEGORIA = @CodigoCategoria WHERE CODIGO = @Codigo";
        private static readonly string _sqlDeletar = "UPDATE LOCAL SET EXCLUIDO = @Excluido WHERE CODIGO = @Codigo";
        private static readonly string _sqlBuscarTudo = "SELECT LOCAL.*, CATEGORIA.NOME FROM LOCAL INNER JOIN CATEGORIA ON (CATEGORIA.CODIGO = LOCAL.COD_CATEGORIA) WHERE LOCAL.EXCLUIDO = 0";
        private static readonly string _sqlComboBox = "SELECT CODIGO, NOME FROM LOCAL";

        public LocalControle(ILocal formulario) {
            _form = formulario;
        }

        public void Incluir() {
            Local local = new Local(_form.ObterNomeLocal(), _form.ObterCategoria());
            LocalRepositorio.Inserir(_sqlInserir, local);
        }
        public void Modificar() {
            Local local = new Local(_form.ObterCodigoLocal(), _form.ObterNomeLocal(), _form.ObterCategoria());
            LocalRepositorio.Atualizar(_sqlAtualizar, local);
        }
        public DataTable BuscarLocais() {
            return LocalRepositorio.Consultar(_sqlBuscarTudo);
        }
        public DataTable PopularComboBox() {
            return LocalRepositorio.Consultar(_sqlComboBox);
        }
        public void Remover() {
            Local local = new Local(_form.ObterCodigoLocal(), _form.ObterNomeLocal(), _form.ObterCategoria());
            local.AtivarDesativar(true);
            LocalRepositorio.Deletar(_sqlDeletar, local);
        }
    }
}