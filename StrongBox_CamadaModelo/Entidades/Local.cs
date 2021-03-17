using StrongBox.CamadaModelo.Excecoes;

namespace StrongBox.CamadaModelo.Entidades {
    public class Local {
        public long Codigo { get; private set; }
        public string Nome { get; private set; }
        public long CodigoCategoria { get; private set; }
        private bool _excluido;

        public Local(string nome, long codigoCategoria) {
            if (nome.Length < 3) throw new LocalException("Nome precisa ter mais de 3 caracteres!"); else this.Nome = nome;
            if (codigoCategoria < 1) throw new LocalException("Código da categoria inválido!"); else this.CodigoCategoria = codigoCategoria;
        }
        public Local(long codLocal, string nome, long codigoCategoria) {
            if (codLocal < 1) throw new LocalException("Código de local inválido!"); else this.Codigo = codLocal;
            if (nome.Length < 3) throw new LocalException("Nome precisa ter mais de 3 caracteres!"); else this.Nome = nome;
            if (codigoCategoria < 1) throw new LocalException("Código da categoria inválido!"); else this.CodigoCategoria = codigoCategoria;
        }

        public void AtivarDesativar(bool opcao) {
            _excluido = opcao;
        }

        public bool FoiExcluido() {
            return _excluido;
        }
    }
}
