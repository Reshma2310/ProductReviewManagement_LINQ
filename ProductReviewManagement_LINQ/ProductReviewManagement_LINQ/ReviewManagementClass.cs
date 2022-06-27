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
        public void CountOfReview(List<ProductReviewModel> product)
        {
            var result = product.GroupBy(x => (x.ProductId)).Select(x => new { ProductId = x.Key, count = x.Count() });
            foreach (var item in result)
            {
                Console.WriteLine("ProductId: " + item.ProductId + " --- Count : " + item.count);
            }
        }
        public void ProductIdAndReview(List<ProductReviewModel> product)
        {
            var result = product.Select(x => (x.ProductId, x.Review));
            Console.WriteLine("Product ID\tReview");
            foreach (var item in result)
            {
                Console.WriteLine("\t" + item.ProductId + "\t" + item.Review);
            }            
        }
        public void SkipTop5Records(List<ProductReviewModel> product)
        {
            var result = product.OrderByDescending(x => (x.Rating)).Skip(5);
            foreach (var item in result)
            {
                Console.WriteLine("ProductId: " + item.ProductId + "\tUserId: " + item.UserId + "\tRating: " + item.Rating + "\tReview: " +
                     item.Review + "\tIsLike: " + item.IsLike);
            }
        }
    }
}
