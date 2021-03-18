using StrongBox.Biblioteca.Classes.Estaticas;
using StrongBox.CamadaControle.Interfaces;
using StrongBox.CamadaModelo;
using System.Data;

namespace StrongBox.CamadaControle.Controles {
    public class LocalControlador {
        #region Propriedades e Atributos

        private readonly ILocal _intLocal;

        #endregion

        #region Construtores

        public LocalControlador(ILocal pInterface) {
            _intLocal = pInterface;
        }

        #endregion

        #region Métodos Públicos

        public void Incluir() {
            Local local = new Local(_intLocal.ObterNomeLocal(), _intLocal.ObterCategoria());
            local.Inserir(ComandosSql.InserirLocal);
        }

        public void Modificar() {
            Local local = new Local(_intLocal.ObterCodigo(), _intLocal.ObterNomeLocal(), _intLocal.ObterCategoria());
            local.Atualizar(ComandosSql.AtualizarLocal);
        }

        public DataTable BuscarLocais() {
            return new Local().Consultar(ComandosSql.BuscarLocais);
        }

        public void Remover() {
            Local local = new Local(_intLocal.ObterCodigo());
            local.Deletar(ComandosSql.DeletarLocal);
        }

        #endregion
    }
}