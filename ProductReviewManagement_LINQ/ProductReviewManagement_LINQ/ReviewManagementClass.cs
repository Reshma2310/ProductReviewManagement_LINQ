using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        //UC5 and UC7
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
        public DataTable CreateDataTable(List<ProductReviewModel> product)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductId", typeof(Int32));
            table.Columns.Add("UserId", typeof(Int32));
            table.Columns.Add("Rating", typeof(Double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            foreach (var item in product)
            {
                table.Rows.Add(item.ProductId, item.UserId, item.Rating, item.Review, item.IsLike);
            }
            Console.WriteLine("Records in DataTable.");
            Console.WriteLine("ProductId\tUserId\tRating\tReview\tIsLike");
            foreach (var item in table.AsEnumerable())
            {
                Console.WriteLine( "\t" + item.Field<int>("ProductId") + "\t" + item.Field<int>("UserId") + "\t" + item.Field<double>("Rating") + "\t" + item.Field<string>("Review") + "\t" + item.Field<bool>("IsLike"));
            }
            return table;
        }
        public void TrueInIsLike(DataTable table)
        {            
            var data = table.AsEnumerable().Where(x => (x.Field<bool>("IsLike") == true));
            Console.WriteLine("ProductId\tUserId\tRating\tReview\tIsLike");
            foreach (var item in data)
            {
                Console.WriteLine("\t" + item.Field<int>("ProductId") + "\t" + item.Field<int>("UserId") + "\t" +
                    item.Field<double>("Rating") + "\t" + item.Field<string>("Review") + "\t" + item.Field<bool>("IsLike"));
            }
        }
        public void ProductIdAvgRating(DataTable table)
        {
            var result = table.AsEnumerable().GroupBy(table => table.Field<int>("ProductID")).Select(field => new
            {
                ProductId = field.Key,
                Average = field.Average(x => x.Field<double>("Rating"))
            });
            Console.WriteLine("Average rating of each ProductId");
            foreach (var item in result)
            {
                Console.WriteLine("ProductID: " + item.ProductId + "\tAverage: " + item.Average);
            }
        }
        public void NiceInReview(DataTable table)
        {
            var data = table.AsEnumerable().Where(x => (x.Field<string>("Review") == "Nice"));
            Console.WriteLine("ProductId\tUserId\tRating\tReview\tIsLike");
            foreach (var item in data)
            {
                Console.WriteLine("\t" + item.Field<int>("ProductId") + "\t" + item.Field<int>("UserId") + "\t" +
                    item.Field<double>("Rating") + "\t" + item.Field<string>("Review") + "\t" + item.Field<bool>("IsLike"));
            }
        }
        public void OrderByRatingForProductId10(DataTable products)
        {
            Console.WriteLine("List of Review who's UserId is 10");
            var data = products.AsEnumerable().OrderBy(x => (x.Field<double>("Rating"))).Where(x => (x.Field<int>("UserId") == 10));
            Console.WriteLine("ProductId\tUserId\tRating\tReview\tIsLike");
            foreach (var item in data)
            {
                Console.WriteLine("\t" + item.Field<int>("ProductId") + "\t " + item.Field<int>("UserId") + "\t" +
                    item.Field<double>("Rating") + "\t" + item.Field<string>("Review") + "\t" + item.Field<bool>("IsLike"));
            }
        }
    }
}
