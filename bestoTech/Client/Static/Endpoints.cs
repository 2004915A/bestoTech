using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string BrandsEndpoint = $"{Prefix}/brands";
        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string CategoriesEndpoint = $"{Prefix}/Categories";
        public static readonly string BrandCategoriesEndpoint = $"{Prefix}/brandcategories";
        public static readonly string ProductCategoriesEndpoint = $"{Prefix}/productcategories";
        public static readonly string AStoresEndpoint = $"{Prefix}/astores";
        public static readonly string ALinksEndpoint = $"{Prefix}/alinks";
    }
}
