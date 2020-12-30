using StrongBox.CamadaControle.Interfaces;
using StrongBox.CamadaModelo.Entidades;
using StrongBox.CamadaModelo.Repositorios;
using System.Data;

namespace StrongBox.CamadaControle.Controles {
    public class CategoriaControle {
        private readonly ICategoria _form;

        private static readonly string _sqlInserir = "INSERT INTO CATEGORIA (NOME, PREFIXO) VALUES (@Nome, @Prefixo)";
        private static readonly string _sqlAtualizar = "UPDATE CATEGORIA SET NOME = @Nome, PREFIXO = @Prefixo WHERE CODIGO = @Codigo";
        private static readonly string _sqlDeletar = "UPDATE CATEGORIA SET EXCLUIDO = @Excluido WHERE CODIGO = @Codigo";
        private static readonly string _sqlBuscarCategorias = "SELECT * FROM CATEGORIA WHERE EXCLUIDO = 0";
        private static readonly string _sqlComboBox = " SELECT CODIGO, NOME FROM CATEGORIA";

        public CategoriaControle(ICategoria inter) {
            _form = inter;
        }

        public void Criar() {
            Categoria categoria = new Categoria(_form.ObterNomeCategoria(), _form.ObterPrefixo());
            CategoriaRepositorio.Inserir(_sqlInserir, categoria);
        }

        public void Editar() {
            Categoria categoria = new Categoria(_form.ObterCodigoCategoria(), _form.ObterNomeCategoria(), _form.ObterPrefixo());
            CategoriaRepositorio.Atualizar(_sqlAtualizar, categoria);
        }

        public DataTable BuscarCategorias() {
            return CategoriaRepositorio.Consultar(_sqlBuscarCategorias, "CATEGORIA");
        }

        public DataTable PreencherComboBox() {
            return CategoriaRepositorio.Consultar(_sqlComboBox, "CATEGORIA");
        }

        public string BuscarPrefixo() {
            // TODO: Implementar para retornar o prefixo da categoria indicada.
            return "";
        }

        public void Excluir() {
            // TODO: Criar um mecanismo para verificar se tem algum registro relacionado, caso sim, perguntar se deseja deletar todos.
            Categoria categoria = new Categoria(_form.ObterCodigoCategoria(), _form.ObterNomeCategoria(), _form.ObterPrefixo());
            categoria.AtivarDesativar(true);
            CategoriaRepositorio.Deletar(_sqlDeletar, categoria);
        }
    }
}
