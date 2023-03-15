using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReveiwManagement
{
    public class ProductManagement
    {
        List<ProductReview> productReviewList = new List<ProductReview>();

        public void AddProductList(List<ProductReview> list)
        {
            this.productReviewList = list;
        }
    }
}
