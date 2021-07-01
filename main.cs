using System;
using System.Collections.Generic;

namespace Kauppa
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      Loja lomuttoKirjakauppa = new Loja();
      Persona player = new Persona("Siunarka Kolema", 1200);
      Console.WriteLine ("Seja bem-vindo à Lomutto Kirjakauppa, a maior livraria encantada de Hilipin");
      Console.WriteLine ("Deseja ver nossos itens mágicos?");
      Console.WriteLine ("S = sim; N = não");
      string entrar;
      entrar = Console.ReadLine();
      if (entrar == "S")
      {
        Console.WriteLine("Está aqui nosso catálogo");
        lomuttoKirjakauppa.ExibArmazem();
        Console.WriteLine("Deseja comprar algo?");
        Console.WriteLine ("S = sim; N = não");
        string vaiCompra;
        vaiCompra = Console.ReadLine();
        if (vaiCompra == "S")
        {
          string recompra;
          do
          {
            Console.WriteLine("O que deseja?");
            string venda;
            venda = Console.ReadLine();
            player.Comprar(venda, lomuttoKirjakauppa);
            player.ExibInventario();
            Console.WriteLine("Algo mais?");
            Console.WriteLine ("S = sim; N = não");
            recompra = Console.ReadLine();
          } while (recompra == "S");
          if (recompra == "N")
          {
            Console.WriteLine("Agradecemos pela Compra");
          }
        }
        else if (vaiCompra != "N")
        {
          Console.WriteLine("Tudo bem, agradecemos sua visita!");
        }
      }
      else if (entrar != "S")
      {
        Console.WriteLine("Bom, volte quando desejar algo");
      } 
    }
  }
}