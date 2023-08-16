using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralParactice
{
    //Teacher class inherits from Employee class & provides implementation of INotification
    //base class (Employee) must come before Interface otherwise compiler gives error
    public class Teacher : Employee, INotification
    {
        public string Department { get; set; }

        public void Notify()    //Teacher class must implement Interface
        {
            Console.WriteLine("Notification from Teachcr class!");
        }
    }
}
