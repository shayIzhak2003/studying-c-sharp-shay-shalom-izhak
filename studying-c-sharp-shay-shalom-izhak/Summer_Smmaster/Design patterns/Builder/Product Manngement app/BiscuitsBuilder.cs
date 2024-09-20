using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app
{
    public class BiscuitsBuilder : IProductBuilder
    {
        private Product _product;

        public BiscuitsBuilder()
        {
            _product = new Product();
        }

        public void SetName()
        {
            _product.Name = "Biscuits";
        }

        public void SetBarcode()
        {
            _product.Barcode = "9876543210987"; // Example barcode
        }

        public void SetPrice()
        {
            _product.Price = 4.5;
        }

        public void SetUnit()
        {
            _product.Unit = "₪ per unit";
        }

        public void SetWeightPerUnit()
        {
            _product.WeightPerUnit = 50; // Example weight per 100g
        }

        public Product GetProduct()
        {
            return _product;
        }
    }

}
