public abstract class Mensagem
{
    public Contatinho Destinatario;
    public string HoraEnvio;
    public string Conteudo;

    public Mensagem(Contatinho destinatario, string horaEnvio, string conteudo)
    {
        Destinatario = destinatario;
        HoraEnvio = horaEnvio;
        Conteudo = conteudo;
    }

    public override abstract string ToString();
}