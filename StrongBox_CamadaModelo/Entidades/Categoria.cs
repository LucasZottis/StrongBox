using StrongBox.CamadaModelo.Excecoes;

namespace StrongBox.CamadaModelo.Entidades {
    public class Categoria {
        public long Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Prefixo { get; private set; }
        private bool _excluido;

        public Categoria(string nome, string prefixo) {
            if (nome.Length < 5) throw new CategoriaException("Nome precisa ter mais de 5 caracteres"); else this.Nome = nome;
            if (prefixo.Length != 3) throw new CategoriaException("Prefixo é apenas 3 caracteres"); else this.Prefixo = prefixo;
        }
        public Categoria(long codigo, string nome, string prefixo) {
            if (codigo < 1) throw new CategoriaException("Código de categoria inválido!"); else this.Codigo = codigo;
            if (nome.Length < 5) throw new CategoriaException("Nome precisa ter mais de 5 caracteres"); else this.Nome = nome;
            if (prefixo.Length != 3) throw new CategoriaException("Prefixo é apenas 3 caracteres"); else this.Prefixo = prefixo;
        }

        public void AtivarDesativar(bool opcao) {
            _excluido = opcao;
        }

        public bool FoiExcluido() {
            return _excluido;
        }
    }
}
