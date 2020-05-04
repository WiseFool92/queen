using System;

class Queen
{
  static void Main()
  {
    string[] queens = Cordinates("queen");
    string[] other = Cordinates("pawn");
    Attack(queens, other);
  }
  static string[] Cordinates(string piece)
  {
    Console.WriteLine("What is the x position of " + piece + "?");
    string yourXCord = Console.ReadLine();
    Console.WriteLine("What is the y position of " + piece + "?");
    string yourYCord = Console.ReadLine();
    Console.WriteLine("Your " + piece + " x pos is " + yourXCord + " & your " + piece + " y pos is " + yourYCord + ".");
    string[] bothCord = { yourXCord, yourYCord };
    return bothCord;
  }
  static void Attack(string[] queens, string[] other)
  {
    if (queens[0] == other[0] || queens[1] == other[1])
    {
      Console.WriteLine("The Queen can attack.");
    }
    else
    {
      Console.WriteLine("The Queen cannot attack");
    }
  }
}