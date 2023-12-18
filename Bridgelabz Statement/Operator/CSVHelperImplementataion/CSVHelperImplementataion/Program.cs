using System;

namespace CSVHelperImplementataion
{
    class Program
    {
        static void Main( )
        {
            CSVHandlerImplementation cSVHandlerImplementation= new CSVHandlerImplementation();
            cSVHandlerImplementation.ImplementCSVHandler();
            cSVHandlerImplementation.ImplementCSVHandlerToJson();
            cSVHandlerImplementation.ImplementJsonToCsv();
        }
    }
}