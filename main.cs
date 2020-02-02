using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    var items = new[] { 2, 4, 1, 3, 0, 6, 5};

    var bogo = new BogoSort(items);

    bogo.Sort();

    foreach(var item in items)
      Console.Write(item + " ");

    Console.WriteLine($"\n{bogo.Iterations} iterations.");
  }
}