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
                Console.WriteLine("Product ID: " + item.ProductId + "\tUser ID: " + item.UserId + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tIsLike: " + item.IsLike);
            }
        }
        public void TopThreeRecordsOfAll(List<ProductReviewModel> product)
        {
            var result = (from list in product
                          orderby list.Rating descending
                          select list).Take(3);
            foreach (var item in result)
            {
                Console.WriteLine("Product ID: " + item.ProductId + "\tUser ID: " + item.UserId + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tIsLike: " + item.IsLike);
            }
        }
    }
}
