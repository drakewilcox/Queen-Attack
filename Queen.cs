using System;
using System.Collections.Generic;
using Models;

namespace ChessPlay
{

  public class Program
  {
    public static void Main()
    {
      GetCoord("Target");
      GetCoord("Queen");
      Console.WriteLine(Player.CanAttack());

    }

    public static void GetCoord(string position)
    {
      Console.WriteLine("Enter coordinates for " + position);
      Console.Write("{0,15}", "Enter x: ");
      string targetX = Console.ReadLine();
      Console.Write("{0,15}", "Enter y: ");
      string targetY = Console.ReadLine();
      Console.Write("{0,15:N0}","----------------------");
      Console.WriteLine();

      Player target = new Player();
      target.X  = targetX;
      target.Y = targetY;
      Player.AddPlayer(target);
    }

    
  }
}