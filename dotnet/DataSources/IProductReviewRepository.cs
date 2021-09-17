﻿namespace ReviewsRatings.DataSources
{
    using System.Collections.Generic;
    using Models;
    using System.Threading.Tasks;

    public interface IProductReviewRepository
    {
        Task<IList<LegacyReview>> GetProductReviewsAsync(string productId);

        Task SaveProductReviewsAsync(string productId, IList<LegacyReview> productReviews);

        Task<IDictionary<int, string>> LoadLookupAsync();

        Task SaveLookupAsync(IDictionary<int, string> lookupDictionary);

        Task<ValidatedUser> ValidateUserToken(string token);

        Task<bool> ValidateKeyAndToken(string key, string token, string baseUrl);

        Task<VtexOrder> GetOrderInformation(string orderId);

        Task<VtexOrderList> ListOrders(string queryString);

        Task<bool> VerifySchema();
        Task<IList<Review>> GetProductReviewsMD(string searchQuery);
        Task<bool> DeleteProductReviewMD(string documentId);
        Task<bool> SaveProductReviewMD(Review review);
    }
}
