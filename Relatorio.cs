using System;
using System.Collections.Generic;
public class Relatorio
{
    private Calculadora _calc;
    private float _total;
    List<ItemRelatorio> consumacao;
    

    public Relatorio()
    {
        consumacao = new List<ItemRelatorio>();
        _calc = new Calculadora();
    }
    public float Total
    { 
        get => _total;
        set{ _total = _calc.GetTotalRelatorio(consumacao);}
    }
    public static Relatorio Create() 
    {
        Relatorio r = new Relatorio();
        return r;
    }
    public void AdicionarItemRelatorio(ItemRelatorio c)
    {
        consumacao.Add(c);
    }
    public void GetRelatorio()
    {
        Console.WriteLine("PRODUTO          QNTxVALOR           SUBTOTAL");
        foreach (var item in consumacao)
        {
            Console.WriteLine($"{item.Produto.Nome}                {item.Quantidade}x{item.Produto.Valor}         {item.Quantidade*item.Produto.Valor}");
        }
        Console.WriteLine($"TOTAL GERAL                             {Total}");
    }
}
