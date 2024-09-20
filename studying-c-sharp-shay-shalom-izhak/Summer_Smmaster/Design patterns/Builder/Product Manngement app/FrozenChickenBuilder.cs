using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app
{
    public class FrozenChickenBuilder : IProductBuilder
    {
        private Product _product;

        public FrozenChickenBuilder()
        {
            _product = new Product();
        }

        public void SetName()
        {
            _product.Name = "Frozen Chicken";
        }

        public void SetBarcode()
        {
            _product.Barcode = "1234567890123"; // Example barcode
        }

        public void SetPrice()
        {
            _product.Price = 30.0;
        }

        public void SetUnit()
        {
            _product.Unit = "₪ per unit";
        }

        public void SetWeightPerUnit()
        {
            _product.WeightPerUnit = 71; // Example weight per 100g
        }

        public Product GetProduct()
        {
            return _product;
        }
    }

}
