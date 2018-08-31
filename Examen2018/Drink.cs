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

    class Drink
    {
        private String name;
        private int price;
        private int volume;

        public Drink(String name, int volume, int price)
        {
            this.name = name;
            this.volume = volume;
            this.price = price;
        }

        public String GetName()
        {
            return name;
        }

        public int GetPrice()
        {
            return price;
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetPrix(int price)
        {
            this.price = price;
        }
    }
}
