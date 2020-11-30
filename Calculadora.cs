using System.Collections.Generic;
public class Calculadora
{
    public float GetTotalRelatorio(List<ItemRelatorio> c)
    {
        float t = 0;
        foreach (var item in c)
        {
            t += item.GetSubValor(); 
        }
        return t;
    }
}