using System;
using NumberWords.Models;
using System.Collections.Generic;

class Program
{

  public static void Main()
  {
    Console.WriteLine("Please enter a number:");
    int input = int.Parse(Console.ReadLine());
    if (input < 20)
    {
      NumberConvert newNumber = new NumberConvert(input);
      newNumber.OnesName();
      foreach (string item in NumberConvert.masterList)
      {
        Console.WriteLine(item);
      }
      
    }
    else if (input > 19 && input < 100)
    {
      NumberConvert newNumber = new NumberConvert(input);
      newNumber.TensName();
      foreach (string item in NumberConvert.masterList)
      {
        Console.WriteLine(item);
      }
    }
    else if (input > 99 && input < 1000)
    {
      NumberConvert newNumber = new NumberConvert(input);
      newNumber.HundredsName();
      foreach (string item in NumberConvert.masterList)
      {
        Console.WriteLine(item);
      }
    }
  }
}