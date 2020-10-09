namespace marraia.SOLID._5___DSP.Solucao.Repositorio.Gateway.Interfaces
{
    public interface IEmailGateway
    {
        void EnvioEmail(string de, string para, string assunto, string mensagem);
    }
}
