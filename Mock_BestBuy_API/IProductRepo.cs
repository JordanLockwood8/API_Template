﻿using System.Collections.Generic;

namespace Mock_BestBuy_API.Mock_BestBuy_API
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProduct(int id);
        public void InsertProduct(Product prod);
        public void UpdateProduct(Product prod);
        public void DeleteProduct(Product prod);

    }
}