using System;

namespace HelloWorldConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("Just another change to trigger SCM polling.");
      /**
       * Automatic build won't get triggered, because local Jenkins uses localhost, not visible to the internet.
       * Due to this, when attempting to add the webhook in Github, the payload url for Jenkins wasn't valid.
       * Payload URL: https://10.5.10.101:8088/github-webhook or https://localhost:8088/github-webhook
       */
      Console.WriteLine("Just another change to trigger Jenkins build after adding post-receive git hook.");
    }
  }
}
