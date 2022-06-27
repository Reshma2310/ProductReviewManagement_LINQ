using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reviews of the Products Specified");            
            List<ProductReviewModel> product = new List<ProductReviewModel>()
            {
                new ProductReviewModel() { ProductId = 1, UserId = 1, Rating = 5, Review = "Best", IsLike = true },
                new ProductReviewModel() { ProductId = 2, UserId = 2, Rating = 1, Review = "Bad", IsLike = true },
                new ProductReviewModel() { ProductId = 3, UserId = 3, Rating = 4, Review = "Better", IsLike = true },
                new ProductReviewModel() { ProductId = 4, UserId = 4, Rating = 4, Review = "Better", IsLike = true },
                new ProductReviewModel() { ProductId = 5, UserId = 5, Rating = 2, Review = "Nice", IsLike = true },
                new ProductReviewModel() { ProductId = 6, UserId = 7, Rating = 2, Review = "Nice", IsLike = true },
                new ProductReviewModel() { ProductId = 7, UserId = 6, Rating = 5, Review = "Best", IsLike = true },
                new ProductReviewModel() { ProductId = 8, UserId = 5, Rating = 3, Review = "Good", IsLike = true },
                new ProductReviewModel() { ProductId = 9, UserId = 4, Rating = 3, Review = "Good", IsLike = true },
                new ProductReviewModel() { ProductId = 10, UserId = 10, Rating = 5, Review = "Best", IsLike = false },
                new ProductReviewModel() { ProductId = 11, UserId = 5, Rating = 2, Review = "Nice", IsLike = true },
                new ProductReviewModel() { ProductId = 12, UserId = 4, Rating = 4, Review = "Better", IsLike = true },
                new ProductReviewModel() { ProductId = 13, UserId = 15, Rating = 3, Review = "Good", IsLike = true },
                new ProductReviewModel() { ProductId = 14, UserId =30, Rating = 2, Review = "Nice", IsLike = true },
                new ProductReviewModel() { ProductId = 15, UserId = 26, Rating = 2, Review = "Nice", IsLike = true },
                new ProductReviewModel() { ProductId = 16, UserId = 8, Rating = 4, Review = "Better", IsLike = false },
                new ProductReviewModel() { ProductId = 17, UserId = 18, Rating = 5, Review = "Best", IsLike = true },
                new ProductReviewModel() { ProductId = 18, UserId = 9, Rating = 3, Review = "Good", IsLike = true },
                new ProductReviewModel() { ProductId = 19, UserId = 10, Rating = 2, Review = "Nice", IsLike = true },
                new ProductReviewModel() { ProductId = 20, UserId = 7, Rating = 1, Review = "Bad", IsLike = true },
                new ProductReviewModel() { ProductId = 21, UserId = 6, Rating = 1, Review = "Bad", IsLike = false },
                new ProductReviewModel() { ProductId = 22, UserId = 5, Rating = 3, Review = "Good", IsLike = true },
                new ProductReviewModel() { ProductId = 23, UserId = 10, Rating = 3, Review = "Good", IsLike = true },
                new ProductReviewModel() { ProductId = 24, UserId = 8, Rating = 1, Review = "Bad", IsLike = true },
                new ProductReviewModel() { ProductId = 25, UserId = 12, Rating = 2, Review = "Nice", IsLike = false },
            };
            ProductReviewManagement_LINQ.ReviewManagementClass reviewManagement = new ProductReviewManagement_LINQ.ReviewManagementClass();
            //reviewManagement.GetReview(product);
            //reviewManagement.TopThreeRecordsOfAll(product);
            reviewManagement.ListOfReviewGreaterThan3(product);            
        }
    }
}