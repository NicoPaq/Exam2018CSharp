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

    class Distributor
    {
        private String distributorInfo;
        private int nbrDrinks;
        private Drink drink;

        public Distributor(String distributorName, String name, int volume, int price) {
            this.distributorInfo = distributorName;
            this.drink = new Drink(name, volume, price);
            nbrDrinks = 10;
        }

        public Distributor(String distributorName) {
            this.distributorInfo = distributorName;
            nbrDrinks = 0;
        }

        public void NameDrinkDisplay() { 

            if(this.drink != null){
                Console.WriteLine("***********************************************");
                Console.WriteLine("   Drink : " + drink.GetName());
                Console.WriteLine("***********************************************");
            }
            else{
                Console.WriteLine("***********************************************");
                Console.WriteLine("************ No Drinks Available **************");
                Console.WriteLine("***********************************************");
            }
        
        }

        public Drink GetDrink()
        {
            return this.drink;
        }

        public int GetNbrDrinks()
        {
            return nbrDrinks;
        }

        public void SetNbrDrinks()
        {
            nbrDrinks--;
        }


        public String DistributorName()
        {
            return this.distributorInfo;
        }

        public int ReloadDistributor()
        {
            int result = 10 - nbrDrinks;
            if(0 <= result && result <= 10)
            {
                nbrDrinks = 10;
                return result;
            }
            return -1;
        }

        public void RenewDrink(Drink drink)
        {
            this.drink = drink;
        }

        public bool BuyDrinks(Employee employee)
        {
            if(employee.GetType() == typeof(EmployeeVip))
            {
                if (nbrDrinks > 0)
                {
                    nbrDrinks--;
                    return true;
                }
                return false;
            }
            else
            {
                if (nbrDrinks > 0 && employee.GetChips() > drink.GetPrice())
                {
                    employee.SetChips(employee.GetChips() - drink.GetPrice());
                    nbrDrinks--;
                    return true;
                }
                return false;
            } 
      
        }

        public void DistributorDisplay()
        {
            if(this.drink != null)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("   Distributor Name : " + this.distributorInfo);
                Console.WriteLine("   Quantity Left : " + nbrDrinks);
                Console.WriteLine("   Drink Name: " + drink.GetName());
                Console.WriteLine("   Volume: " + drink.GetVolume() + " cl ");
                Console.WriteLine("   Price: " + drink.GetPrice() + " chips");
                Console.WriteLine("***********************************************");
            }
            else
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("   Distributor Name : " + this.distributorInfo);
                Console.WriteLine("   This distributor contains no drinks.        ");
                Console.WriteLine("   Apologizes for the inconvenience.           ");
                Console.WriteLine("***********************************************");
            }
          
        }
    }
}
