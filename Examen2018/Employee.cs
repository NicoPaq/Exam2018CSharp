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

    class Employee
    {
        private String name;
        private String role;
        private int availableChips;

        public Employee(String name, String role)
        {
            this.name = name;
            this.role = role;
            availableChips = 15;
        }

        public int ResetChips()
        {
            availableChips = 15;
            return availableChips;
        }

        public void EmployeeDisplay()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("   Employee Name : " + this.name);
            Console.WriteLine("   Role : " + this.role);
            Console.WriteLine("   Available Chips : " + this.GetChips());
            Console.WriteLine("***********************************************");
        }

        public int GetChips()
        {
            return availableChips;
        }

        // Utile pour avoir le nom de l'employé dans nos tests.
        public String GetName()
        {
            return this.name;
        }

        public String GetRole()
        {
            return this.role;
        }

        public void SetChips(int chips)
        {
            if(chips > 0 && chips <= 15)
            {
                availableChips = chips;
            }
            else
            {
                Console.WriteLine("You have introduce a number unhallowed. Chips must be between 1 and 15. By default we set them to 15.");
                availableChips = 15;
            }
           
        }

    }
}
