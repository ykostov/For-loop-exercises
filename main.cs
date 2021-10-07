using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a:");
    int a = Convert.ToInt32(Console.ReadLine());
    
    /* 1va zad

    for (int i = 0; i <= a; i++) 
    {
      for (int j = 0; j <= a - i; j++) 
      {
        Console.Write(" ");
      }
      for (int k = 0; k <= i; k++) 
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    } 
    */
    
    /* 2ra zad

    for (int i = 1; i  <= a; i++)
    {
      for (int k = 1; k <= i; k++)
      {
        Console.Write(k);
      }
      Console.WriteLine("");
    }
    */

  /* 3ta zad

    for (int i = 1; i  <= a; i++)
    {
      for (int k = 1; k <= i; k++)
      {
        Console.Write(i);
      }
      Console.WriteLine("");
    }
    */

/*
    for (int i = 0; i <= a; i++)
    {
      for (int j = 0; j <= i; j++)
      {
        Console.Write("*");
        if (j == 0)
        {
          Console.WriteLine("*");
        }
        if (j == i)
        {
          Console.WriteLine("*");
        }
        else
        {
          Console.WriteLine("");
        }
      }  

      Console.WriteLine("");
    }
  */

  
  for (int i = 1; i <= a; i++)
  {
    Console.Write("*");
    for(int j = 0; j <= a; j++)
    {
      Console.Write(" ");
    }
    Console.WriteLine("*");
  }
  for (int k= 1; k<=a; k++)
  {
    Console.Write("*");
  }
  Console.WriteLine("");

  



  }
}