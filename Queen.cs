using System;
using System.Collections.Generic;

public class Player
{
  public static List<Player> Players = new List<Player>(){};
  public string X;
  public string Y;

  public static void AddPlayer(Player player)
  {
    Players.Add(player);
  }
}



public class Program
{
  public static void Main()
  {
    GetCoord("Target");
    GetCoord("Queen");
    Console.WriteLine(CanAttack());

  }

  public static void GetCoord(string position)
  {
    Console.WriteLine("Enter coordinates for " + position);
    Console.Write("{0,15:N3}", "Enter x:");
    string targetX = Console.ReadLine();
    Console.Write("{0,13}", "Enter y: ");
    string targetY = Console.ReadLine();
    Console.Write("{0,15:N0}","----------------------");
    Console.WriteLine();

    Player target = new Player();
    target.X  = targetX;
    target.Y = targetY;
    Player.AddPlayer(target);
  }

  public static string CanAttack()

  {
    if (Player.Players[0].X == Player.Players[1].X) 
    {
      return "Can attack"; 
    } 
    else if (Player.Players[0].Y  == Player.Players[1].Y)
    {
      return "Can Attack";
    }
    else 
    {
      return "No Attack";
    }

  }
}