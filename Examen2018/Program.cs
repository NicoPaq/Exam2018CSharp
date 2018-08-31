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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Create new distributor Kfet ");
            Distributor kfet = new Distributor("Kfet", "RedBull", 33, 2);
            kfet.NameDrinkDisplay();
            kfet.DistributorDisplay();
            Console.WriteLine(" Create new distributor Rest Room empty ");
            Distributor sallerepos = new Distributor("Rest Room");
            sallerepos.NameDrinkDisplay();
            sallerepos.DistributorDisplay();
            Console.WriteLine(" Create first employee and display him");
            Employee e1 = new Employee("Steve", "Sales Director");
            e1.EmployeeDisplay();
            Console.WriteLine(" Create second employee and display him");
            Employee e2 = new Employee("Harry", "Commercial");
            e2.EmployeeDisplay();
            Console.WriteLine(e2.GetName() + " buy 8 drinks at Kfet distributor. ");
            // Harry buy eight times same drink at Kfet Distributor.
            for (int i = 1; i < 9; i++){
                Boolean buy = kfet.BuyDrinks(e2);
                if(buy == true){
                    Console.WriteLine("   " + i + " operation(s) recorded.");
                }
                else{
                    Console.WriteLine(" Distributor empty or no more chips.");
                    Console.WriteLine("***********************************************");
                }
            }
            Console.WriteLine(" Display informations about " + e2.GetName());
            e2.EmployeeDisplay();
            Console.WriteLine(" Employee " + e1.GetName() + " ask display of drinks left.");
            kfet.NameDrinkDisplay();
            Console.WriteLine(e1.GetName() + " buy 4 drinks at Kfet distributor. ");
            for (int i = 1; i < 5; i++){
                Boolean buy2 = kfet.BuyDrinks(e1);
                if (buy2 == true){
                    Console.WriteLine("   " + i + " operation(s) recorded.");
                }
                else{
                    Console.WriteLine(" Distributor empty or no more chips.");
                    Console.WriteLine("***********************************************");
                }
            }
            Console.WriteLine(" We need to reload Kfet distributor.");
            int reload = kfet.ReloadDistributor();
            Console.WriteLine(" Amount of " + reload + " drinks has been added.");
            kfet.DistributorDisplay();
            Console.WriteLine(" We need to reset chips to 15 for " + e2.GetName());
            e2.SetChips(15);
            Console.WriteLine(" Display informations about " + e2.GetName());
            e2.EmployeeDisplay();
            Console.WriteLine(e2.GetName() + " want to buy RedBull at "+ kfet.DistributorName());
            kfet.BuyDrinks(e2);
            kfet.DistributorDisplay();
            Console.WriteLine(" Turn drinks of " + kfet.DistributorName() + " into Schweppes");
            Drink b1 = new Drink("Schweppes", 50, 2);
            kfet.RenewDrink(b1);
            kfet.DistributorDisplay();
            Console.WriteLine("*** Employee Elisabeth is VIP this month ***");
            EmployeeVip e3 = new EmployeeVip("Elisabeth", "Sales Assistant");
            e3.EmployeeDisplay();
            Console.WriteLine(e3.GetName() + " buy 8 drinks at Kfet distributor. ");
            // Elisabeth buy eight times same drink at Kfet Distributor - She is a VIP.
            for (int i = 1; i < 9; i++)
            {
                Boolean buy3 = kfet.BuyDrinks(e3);
                if (buy3 == true)
                {
                    Console.WriteLine("   " + i + " operation(s) recorded.");
                }
                else
                {
                    Console.WriteLine(" Distributor empty or no more chips.");
                    Console.WriteLine("***********************************************");
                }
            }
            kfet.DistributorDisplay();
            e3.EmployeeDisplay();
            // Pause program
            Console.ReadKey();

        }
    }
}
