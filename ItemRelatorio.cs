public class ItemRelatorio
{
    private Produto _produto;
    private int _quantidade;

    public Produto Produto
    {
        get => _produto;
        set => _produto = value;
    }
    public int Quantidade
    {
        get => _quantidade;
        set => _quantidade = value;
    }
    public static ItemRelatorio Create()
    {
        ItemRelatorio ir = new ItemRelatorio();
        return ir;
    }
    public void AdicionarProduto(Produto p, int qnt)
    {
        Produto = p;
        Quantidade = qnt;
    }
    public float GetSubValor()
    {
        float v = Produto.Valor * Quantidade;
        return v;
    }
} 