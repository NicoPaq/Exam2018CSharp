using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2018
{
    /*
     * Author NicoPaq
     * Email : webmaster@kornaddict.be
    */

    class EmployeeVip:Employee
    {

        public EmployeeVip(String name, String role) : base(name, role)
        {

        }

        public new void EmployeeDisplay()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("************ VIP OF THE MONTH *****************");
            base.EmployeeDisplay();
        }

    }
}
