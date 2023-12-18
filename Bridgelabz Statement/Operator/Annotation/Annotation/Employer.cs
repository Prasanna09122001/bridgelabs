using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    public class Employer
    {
        int id;
        string name;
        public Employer(int _id,string _name)
        {
            id = _id;
            name = _name;
        }
        [NewAttribute("Accessor","Gives Value of the Employer Id")]
        public  int GetId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Gives Value of the Employer Name")]
        public string GetName()
        {
            return name;
        }
    }
    public class Employee
    {
        int id;
        string name;
        public Employee(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
        [NewAttribute("id", "2805")]
        public int GetId()
        {
            return id;
        }
        [NewAttribute("Name", "Prasanna Venkatesh R P")]
        public string GetName()
        {
            return name;
        }
    }
}
