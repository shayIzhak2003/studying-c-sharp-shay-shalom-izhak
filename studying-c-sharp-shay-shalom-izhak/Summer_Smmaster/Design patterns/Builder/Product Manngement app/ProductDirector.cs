using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app
{
    public class ProductDirector
    {
        private readonly IProductBuilder _productBuilder;

        public ProductDirector(IProductBuilder productBuilder)
        {
            _productBuilder = productBuilder;
        }

        public void ConstructProduct()
        {
            _productBuilder.SetName();
            _productBuilder.SetBarcode();
            _productBuilder.SetPrice();
            _productBuilder.SetUnit();
            _productBuilder.SetWeightPerUnit();
        }

        public Product GetProduct()
        {
            return _productBuilder.GetProduct();
        }
    }

}
