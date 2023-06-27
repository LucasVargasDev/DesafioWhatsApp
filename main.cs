using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Apresentação das Mensagens");

        List<Mensagem> mensagens = new List<Mensagem>();

        mensagens.Add(new MsgTexto(10, new Contatinho("Lilica", "123"), "18:00h", "E ai!"));
        mensagens.Add(new MsgAudio(20, new Contatinho("Ellie", "456"), "20:00h", "Escuta esse audio?"));
        mensagens.Add(new MsgImagem(30, new Contatinho("Megui", "789"), "22:00h", "Olha essa foto."));

        foreach (Mensagem mensagem in mensagens)
        {
            Console.WriteLine(mensagem.ToString());
        }
    }
}