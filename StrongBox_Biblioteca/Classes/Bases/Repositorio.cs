using System.Data;

namespace StrongBox.Biblioteca.Classes.Bases {
    public abstract class Repositorio {
        public abstract void Inserir(string pSql);

        public abstract void Atualizar(string pSql);

        public abstract DataTable Consultar(string pSql);

        public abstract void Deletar(string pSql);
    }
}
