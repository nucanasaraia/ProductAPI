using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Dell XPS 15 Laptop", Category = "Electronics", Price = 1899.99m, StockQuantity = 10, IsAvailable = true },
            new Product { Id = 2, Name = "iPhone 15", Category = "Electronics", Price = 999.99m, StockQuantity = 20, IsAvailable = true },
            new Product { Id = 3, Name = "Banana", Category = "Food", Price = 1.99m, StockQuantity = 100, IsAvailable = true },
            new Product { Id = 4, Name = "Milk", Category = "Food", Price = 2.99m, StockQuantity = 50, IsAvailable = true },
            new Product { Id = 5, Name = "Samsung Galaxy S23", Category = "Electronics", Price = 899.99m, StockQuantity = 15, IsAvailable = true },
            new Product { Id = 6, Name = "Bread", Category = "Food", Price = 1.49m, StockQuantity = 40, IsAvailable = true },
            new Product { Id = 7, Name = "Headphones", Category = "Electronics", Price = 59.99m, StockQuantity = 30, IsAvailable = true },
            new Product { Id = 8, Name = "Chocolate", Category = "Food", Price = 3.99m, StockQuantity = 25, IsAvailable = false }
        };

        [HttpGet("get-all-products")]
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        [HttpGet("get-food-products")]
        public List<Product> GetFoodProducts()
        {
            return _products.Where(p => p.Category == "Food").ToList();
        }

        [HttpGet("get-electronics-products")]
        public List<Product> GetElectronicsProducts()
        {
            return _products.Where(p => p.Category == "Electronics").ToList();
        }

        [HttpGet("get-sorted-by-price")]
        public List<Product> GetProductsSortedByPrice()
        {
            return _products.OrderBy(p => p.Price).ToList();
        }

        [HttpGet("get-sorted-by-price-descending")]
        public List<Product> GetProductsSortedByPriceDescending()
        {
            return _products.OrderByDescending(p => p.Price).ToList();
        }

        [HttpGet("get-available-products")]
        public List<Product> GetAvailableProducts()
        {
            return _products.Where(p => p.IsAvailable).ToList();
        }

        [HttpGet("get-expensive-products")]
        public List<Product> GetExpensiveProducts()
        {
            return _products.Where(p => p.Price > 50).ToList();
        }
    
    }
}
