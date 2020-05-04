using System;

class Queen
{
  static void Main()
  {
    Console.WriteLine("Enter the Queen's X position");
    string xPosQueen = Console.ReadLine();
    int calcXQueen = int.Parse(xPosQueen);

    Console.WriteLine("Enter the Queen's y position");
    string yPosQueen = Console.ReadLine();
    int calcYQueen = int.Parse(yPosQueen);

    Console.WriteLine("Enter the other chess piece X position");
    string xPosOther = Console.ReadLine();
    int calcXPosOther = int.Parse(xPosOther);
    
    Console.WriteLine("Enter the other chess piece Y position");
    string yPosOther = Console.ReadLine();
    int calcYPosOther = int.Parse(yPosOther);

    QueenCordinates("xpos");
    QueenCordinates("ypos");
  }
  static void QueenCordinates(string cord)
  {
    Console.WriteLine("What is your x position" + cord + "?");
    string yourXCord = Console.ReadLine();
    Console.WriteLine("What is your y position" + cord + "?");
    string yourYCord = Console.ReadLine();
    Console.WriteLine("Your x pos is " + yourXCord + "& your y pos is" + yourYCord + ".");
  }
}