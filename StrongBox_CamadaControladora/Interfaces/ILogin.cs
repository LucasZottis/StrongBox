namespace StrongBox.CamadaControle.Interfaces {
    public interface ILogin {
        long ObterCodigoLogin();
        string ObterUsuario();
        string ObterObservacao();
        string ObterSenha();
        byte ObterTamanho();
        int ObterTipoSenha();
        long ObterLocal();
    }
}
