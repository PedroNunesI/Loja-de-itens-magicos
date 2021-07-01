using System;
using System.Collections.Generic;

namespace Kauppa
{
  public class Loja
  {
    public Dictionary<string, Produto> Estoque;
    public Loja()
    {
      this.Estoque = new Dictionary<string, Produto>();
      Produto livroTappaaHeti = new Produto("Tappaa Heti", "Livro Imediato", 750, "Esse livro te dá dominio sobre a morte");
      this.Estoque.Add("Tappaa Heti",livroTappaaHeti);  
      Produto livroElaaHeti = new Produto("Elaa Heti", "Livro Imediato", 750, "Esse livro te dá dominio sobre a vida");
      this.Estoque.Add("Elaa Heti",livroElaaHeti);
      Produto livroJuostaHeti = new Produto("Juosta Heti", "Livro Imediato", 150, "Esse livro melhora sua velocidade");
      this.Estoque.Add("Juosta Heti",livroJuostaHeti);
      Produto livroLateaHeti = new Produto("Latea Heti", "Livro Imediato", 150, "Esse livro melhora sua força");
      this.Estoque.Add("Latea Heti",livroLateaHeti);

      Produto livroPunainenKoulutus = new Produto("Punainen Koulutus", "Livro Elemental", 200, "Esse Livro te ensina a controlar fogo");
      this.Estoque.Add("Punainen Koulutus",livroPunainenKoulutus);
      Produto livroVesiKoulutus = new Produto("Vesi Koulutus", "Livro Elemental", 200, "Esse Livro te ensina a controlar água");
      this.Estoque.Add("Vesi Koulutus",livroVesiKoulutus);
      Produto livroHiekkaKoulutus = new Produto("Hiekka Koulutus", "Livro Elemental", 200, "Esse Livro te ensina a controlar terra");
      this.Estoque.Add("Hiekka Koulutus",livroHiekkaKoulutus);
      Produto livroTuuliKoulutus = new Produto("Tuuli Koulutus", "Livro Elemental", 200, "Esse Livro te ensina a controlar ar");
      this.Estoque.Add("Tuuli Koulutus",livroTuuliKoulutus);

      Produto enerjouda = new Produto("Enerjouda", "Genérico", 80, "Otimiza em 25% sua sessão de leitura");
      this.Estoque.Add("Enerjouda", enerjouda);
      Produto ikulasit = new Produto("Ikulasit", "Genérico", 1200, "Aparato ocular que permite que você leia em línguas antigas ou desconhecidas");
      this.Estoque.Add("Ikulasit",ikulasit);    
    }
    public void ExibArmazem()
    {
      foreach(KeyValuePair<string, Produto> produto in this.Estoque)
      {
        produto.Value.ExibPro();
      }
    }
  }
}