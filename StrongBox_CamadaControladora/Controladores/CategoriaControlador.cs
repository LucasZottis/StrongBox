using StrongBox.Biblioteca.Classes.Estaticas;
using StrongBox.CamadaControle.Interfaces;
using StrongBox.CamadaModelo;
using System.Data;

namespace StrongBox.CamadaControle.Controles {
    public class CategoriaControlador {
        #region Propriedades e Atributos

        private readonly ICategoria _intCategoria;

        #endregion

        #region Construtores

        public CategoriaControlador(ICategoria pInterface) {
            _intCategoria = pInterface;
        }

        #endregion

        #region Métodos Públicos

        public void Criar() {
            Categoria categoria = new Categoria(_intCategoria.ObterNomeCategoria(), _intCategoria.ObterPrefixo());
            categoria.Inserir(ComandosSql.InserirCategoria);
        }

        public void Editar() {
            Categoria categoria = new Categoria(_intCategoria.ObterCodigo(), _intCategoria.ObterNomeCategoria(), _intCategoria.ObterPrefixo());
            categoria.Atualizar(ComandosSql.AtualizarCategoria);
        }

        public DataTable BuscarCategorias() {
            return new Categoria().Consultar(ComandosSql.BuscarCategorias);
        }

        public void Excluir() {
            // TODO: Criar um mecanismo para verificar se tem algum registro relacionado, caso sim, perguntar se deseja deletar todos.
            Categoria categoria = new Categoria(_intCategoria.ObterCodigo());
            categoria.Deletar(ComandosSql.DeletarCategoria);
        }

        #endregion
    }
}
