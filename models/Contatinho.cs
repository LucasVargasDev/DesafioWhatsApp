public class Contatinho
{
    public string Nome;
    public string Celular;

    public Contatinho(string nome, string celular)
    {
        Nome = nome;
        Celular = celular;
    }

    public string getName()
    {
        return Nome;
    }

    public void setName(string nome)
    {
        Nome = nome;
    }

    public string getCelular()
    {
        return Celular;
    }

    public void setCelular(string celular)
    {
        Celular = celular;
    }
}