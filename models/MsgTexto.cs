public class MsgTexto : Mensagem
{
    public int NumChar { get; set; }

    public MsgTexto(int numChar, Contatinho destinatario, string horaEnvio, string conteudo) : base(destinatario, horaEnvio, conteudo)
    {
        NumChar = numChar;
    }

    public override string ToString()
    {
        return "Msg Texto - Contatinho: " + base.Destinatario.getName() +
          ", Numero Telefone: " + base.Destinatario.getCelular() +
          ", Hora de envio: " + base.HoraEnvio +
          ", Conteudo: " + base.Conteudo + " (" + this.NumChar + ")";
    }
}