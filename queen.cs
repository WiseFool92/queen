using System;

class Queen
{
  static void Main()
  {
    // Console.WriteLine("Enter the Queen's X position");
    // string xPosQueen = Console.ReadLine();
    // int calcXQueen = int.Parse(xPosQueen);

    // Console.WriteLine("Enter the Queen's y position");
    // string yPosQueen = Console.ReadLine();
    // int calcYQueen = int.Parse(yPosQueen);

    // Console.WriteLine("Enter the other chess piece X position");
    // string xPosOther = Console.ReadLine();
    // int calcXPosOther = int.Parse(xPosOther);
    
    // Console.WriteLine("Enter the other chess piece Y position");
    // string yPosOther = Console.ReadLine();
    // int calcYPosOther = int.Parse(yPosOther);

    QueenCordinates("queen");
    QueenCordinates("pawn");
  }
  static void QueenCordinates(string piece)
  {
    Console.WriteLine("What is the x position of " + piece  + "?");
    string yourXCord = Console.ReadLine();
    Console.WriteLine("What is the y position of " + piece + "?");
    string yourYCord = Console.ReadLine();
    Console.WriteLine("Your " + piece + " x pos is " + yourXCord + " & your " + piece + " y pos is " + yourYCord + ".");
  }
}




// if xPosQueen == xPosOther || yPosQueen == yPosOther
// {
//   else
// }