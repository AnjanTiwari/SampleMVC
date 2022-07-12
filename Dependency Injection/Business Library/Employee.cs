using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Library
{
    public class Employee :IEmployee //make it public
    {
        public  int getStudents()
        {
            return 10; //this you will get from DB but now we areunderstanding DI
        }
    }
}
