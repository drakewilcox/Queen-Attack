
using System.Collections.Generic;

namespace Models
{
  public class Player
  {
    private static List<Player> Players = new List<Player>(){};
    public string X;
    public string Y;

  public static void AddPlayer(Player player)
  {
    Players.Add(player);
  }  
    public static string GetTargetX()
    {
      return Player.Players[0].X;
    }
    public static string GetTargetY()
    {
      return Player.Players[0].Y;
    }
    public static string GetQueenX()
    {
      return Player.Players[1].X;
    }
    public static string GetQueenY()
    {
      return Player.Players[1].Y;
    }

    public static string CanAttack()
    {
      if ( Player.GetTargetX() == Player.GetQueenX()) 
      {
        return "Can attack"; 
      } 
      else if (Player.GetTargetY()  == Player.GetQueenY())
      {
        return "Can Attack";
      }
      else 
      {
        return "No Attack";
      }
    }
  }
}