using StrongBox.Biblioteca.Classes.Estaticas;
using StrongBox.CamadaControle.Interfaces;
using StrongBox.CamadaModelo;
using System.Data;

namespace StrongBox.CamadaControle.Controles {
    public class CategoriaControlador {
        #region Propriedades e Atributos

        private readonly ICategoria _intCategoria;

        #endregion

        public CategoriaControlador(ICategoria pInterface) {
            _intCategoria = pInterface;
        }

        public void Criar() {
            Categoria categoria = new Categoria(_intCategoria.ObterNomeCategoria(), _intCategoria.ObterPrefixo());
            categoria.Inserir(ComandosSql._sInserirCategoria);
        }

        public void Editar() {
            Categoria categoria = new Categoria(_intCategoria.ObterCodigo(), _intCategoria.ObterNomeCategoria(), _intCategoria.ObterPrefixo());
            categoria.Atualizar(ComandosSql._sAtualizarCategoria);
        }

        public DataTable BuscarCategorias() {
            return new Categoria().Consultar(ComandosSql._sBuscarCategorias);
        }

        public string BuscarPrefixo() {
            // TODO: Implementar para retornar o prefixo da categoria indicada.
            DataTable dtTabela = BuscarCategorias();

            return dtTabela.AsEnumerable().Where(categoria => categoria["CODIGO"].ParaInt() == _intCategoria.ObterCodigo()).ToString();
        }

        public void Excluir() {
            // TODO: Criar um mecanismo para verificar se tem algum registro relacionado, caso sim, perguntar se deseja deletar todos.
            Categoria categoria = new Categoria(_intCategoria.ObterCodigo());
            categoria.Deletar(ComandosSql._sDeletarCategoria);
        }
    }
}
