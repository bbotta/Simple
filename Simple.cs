
using System;


class HelloWorld
{
    static void Main()
    {
#if DebugConfig
        Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");
#endif


        Console.WriteLine("Let this compile due to the trigger.");
  }

}
