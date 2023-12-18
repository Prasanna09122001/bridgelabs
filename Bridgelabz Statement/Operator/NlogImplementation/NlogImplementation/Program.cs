using System;
namespace NlogImplementation
{
    class program
    {
        static void Main()
        {
            Addition addition = new Addition();
            Sub sub = new Sub();
            NlogOperation nLog = new NlogOperation();
            nLog.LogInfo("");
            sub.add(5, 1); 
        }
    }
}