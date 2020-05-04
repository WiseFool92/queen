using System;

class Queen
{
  static void Main()
  {
    Cordinates("queen");
    Cordinates("pawn");
    Attack("1", "3", "1", "5");
  }
  static void Cordinates(string piece)
  {
    Console.WriteLine("What is the x position of " + piece  + "?");
    string yourXCord = Console.ReadLine();
    Console.WriteLine("What is the y position of " + piece + "?");
    string yourYCord = Console.ReadLine();
    Console.WriteLine("Your " + piece + " x pos is " + yourXCord + " & your " + piece + " y pos is " + yourYCord + ".");
  }
  static void Attack(string xCordQ, string yCordQ, string xCordO, string yCordO)
  {
    if (xCordQ == xCordO || yCordQ == yCordO) 
    {
      Console.WriteLine("The Queen can attack.");
    }
    else
    {
      Console.WriteLine("The Queen cannot attack");
    }
  }
}