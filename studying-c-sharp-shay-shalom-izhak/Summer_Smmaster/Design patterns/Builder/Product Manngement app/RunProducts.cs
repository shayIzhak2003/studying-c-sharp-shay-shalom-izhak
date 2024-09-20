using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app
{
    public class RunProducts
    {
        public static void DemoMain()
        {
            // Frozen Chicken
            IProductBuilder frozenChickenBuilder = new FrozenChickenBuilder();
            ProductDirector director = new ProductDirector(frozenChickenBuilder);
            director.ConstructProduct();
            Product frozenChicken = director.GetProduct();
            Console.WriteLine(frozenChicken);

            // Bisli Snack
            IProductBuilder bisliSnackBuilder = new BisliSnackBuilder();
            director = new ProductDirector(bisliSnackBuilder);
            director.ConstructProduct();
            Product bisliSnack = director.GetProduct();
            Console.WriteLine(bisliSnack);

            // Biscuits
            IProductBuilder biscuitsBuilder = new BiscuitsBuilder();
            director = new ProductDirector(biscuitsBuilder);
            director.ConstructProduct();
            Product biscuits = director.GetProduct();
            Console.WriteLine(biscuits);
        }
    }
}
