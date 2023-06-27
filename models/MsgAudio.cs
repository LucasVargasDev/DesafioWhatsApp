public class MsgAudio : Mensagem
{
    public int Duracao { get; set; }

    public MsgAudio(int duracao, Contatinho destinatario, string horaEnvio, string conteudo) : base(destinatario, horaEnvio, conteudo)
    {
        Duracao = duracao;
    }

    public override string ToString()
    {
        return "Msg Audio - Contatinho: " + base.Destinatario.getName() +
          ", Numero Telefone: " + base.Destinatario.getCelular() +
          ", Hora de envio: " + base.HoraEnvio +
          ", Conteudo: " + base.Conteudo + " (" + this.Duracao +")";
    }
}