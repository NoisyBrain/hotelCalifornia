using System;
public class BancoDados
{
    private static BancoDados _banco;
    public static BancoDados Create()
    {  
        if(_banco == null)
        {
            _banco = new BancoDados();
        }
        return _banco;
    }
    public Cliente SelectCliente(string id)
    {
        return new Cliente("Léo", "16086131783");
    }
    public Produto SelectProduto(string cod)
    {
        return new Produto();
    }
    public void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento aceito");
    }
    public Produto SelectQuarto(string tipoQuarto)
    {
        return new Produto();
    }
}