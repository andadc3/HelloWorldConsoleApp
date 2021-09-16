using System;

namespace HelloWorldConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("Just another change to trigger SCM polling.");
      Console.WriteLine("Just another change to trigger Jenkins build after adding post-receive git hook.");
    }
  }
}
