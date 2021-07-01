using System;
using System.Collections.Generic;

namespace Kauppa
{
  public class Persona
  {
    public string Nome;
    public int Kolikko;
    /*Kolikko é a moeda oficial de Hilipin*/
    public List<Produto> Inventario;
    public Persona(string nome, int kolikko)
    {  
      this.Nome = nome;
      this.Kolikko = kolikko;
      this.Inventario = new List<Produto>();
    }
    public void ExibInventario()
    {
      foreach(Produto item in this.Inventario)
      {
        item.ExibPro();
      }
    }
    public void Comprar(string nomePro, Loja kauppa)
    {
      if(kauppa.Estoque.ContainsKey(nomePro))
      {
        if(this.Kolikko >= kauppa.Estoque[nomePro].PrecPro)
        {
          Console.WriteLine("É um ótimo item, realmente vai levar?");
          Console.WriteLine("S = sim; N = não");
          string conferirCompra = Console.ReadLine();
          if (conferirCompra == "S")
          {
            this.Inventario.Add(kauppa.Estoque[nomePro]);
            this.Kolikko -= kauppa.Estoque[nomePro].PrecPro;
            Console.WriteLine("Agradecemos pela compra");
          }
          else if (conferirCompra != "S"){
            Console.WriteLine("Você optou por não comprar");
          }
        } 
      } 
      else
      {
        Console.WriteLine("O item {0} não está em estoque.", nomePro);
      }
    }
  }
}