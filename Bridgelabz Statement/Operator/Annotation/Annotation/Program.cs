using System;

namespace Annotation
{
    class program
    {
        static void Main()
        {
            NewAttribute.AttributeDispaly(typeof(Employer));
            NewAttribute.AttributeDispaly(typeof(Employee));
        }
    }
}