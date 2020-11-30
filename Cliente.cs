public class Cliente
{
    private string _nome;
    private string _cpf;
    private Relatorio _relatorio;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    } 
    public string Cpf
    {
        get => _cpf;
        set => _cpf = value;
    }
    public Relatorio Relatorio
    {
        get => _relatorio;
        set => _relatorio = value;
    }
    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }
    public static Cliente Create(string nome, string cpf)
    {
        Cliente c = new Cliente(nome, cpf);
        return c;
    }
    public void AdicionarRelatorio(Relatorio r)
    {
        Relatorio = r;
    }
}