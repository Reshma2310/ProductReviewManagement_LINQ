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
        public void ListOfReviewGreaterThan3(List<ProductReviewModel> product)
        {
            var result = (from list in product
                          where list.Rating > 3 &&
                          (list.ProductId == 1 || list.ProductId == 4 || list.ProductId == 9)
                          select list);
            Console.WriteLine("List of reviews Greater than 3 and list of products whose Id is 1, 4 & 9");
            foreach (var item in result)
            {
                Console.WriteLine("Product ID: " + item.ProductId + "\tUser ID: " + item.UserId + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tIsLike: " + item.IsLike);

            }
        }        
    }
}
