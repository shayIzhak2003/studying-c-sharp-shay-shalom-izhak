using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app
{
    public interface IProductBuilder
    {
        void SetName();
        void SetBarcode();
        void SetPrice();
        void SetUnit();
        void SetWeightPerUnit();
        Product GetProduct();
    }

}
