using StrongBox.Biblioteca.Enums;

namespace StrongBox.CamadaControle.Interfaces {
    public interface ILogin {
        int ObterCodigo();
        string ObterUsuario();
        string ObterObservacao();
        string ObterSenha();
        byte ObterTamanho();
        TipoSenha ObterTipo();
        int ObterLocal();
    }
}
