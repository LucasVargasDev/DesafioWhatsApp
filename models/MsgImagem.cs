public class MsgImagem : Mensagem
{
    public int Tamanho { get; set; }

    public MsgImagem(int tamanho, Contatinho destinatario, string horaEnvio, string conteudo) : base(destinatario, horaEnvio, conteudo)
    {
        Tamanho = tamanho;
    }

    public override string ToString()
    {
        return "Msg Imagem - Contatinho: " + base.Destinatario.getName() +
          ", Numero Telefone: " + base.Destinatario.getCelular() +
          ", Hora de envio: " + base.HoraEnvio +
          ", Conteudo: " + base.Conteudo + " (" + this.Tamanho + ")";
    }
}