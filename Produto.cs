using System;

namespace Kauppa
{
  public class Produto
  {
    public string NomePro;
    public string CategPro;
    public int PrecPro;  
    public string DescPro;
    public Produto(string nome, string categ, int preco, string descr)
    {
      this.NomePro = nome;
      this.CategPro = categ;
      this.PrecPro = preco;
      this.DescPro = descr;
    }
 
    public void ExibPro()
    {
      Console.WriteLine("Produto: {0}", this.NomePro);
      Console.WriteLine("Categoria: {0}", this.CategPro);
      Console.WriteLine("Preço: {0}", this.PrecPro);
      Console.WriteLine("Descrição: {0}", this.DescPro);
    }
  }
}