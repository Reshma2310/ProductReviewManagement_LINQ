using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement_LINQ
{
    internal class ReviewManagementClass
    {
        public void GetReview(List<ProductReviewModel> product)
        {
            foreach (var item in product)
            {
                Console.WriteLine("Product ID: " + item.ProductId + "\tUser ID: " + item.UserId + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.IsLike);
            }
        }
    }
}
