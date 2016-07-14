using System.Collections.Generic;
using System.Data.Entity;

namespace CollegeWebStore.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Pro Gaming"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Televisions"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Audio"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "PC Components"
                }
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Doritos",
                    Description = "Free range doritos that have lived a life filled with joy and hope. It really comes through in the taste! Certified free range by MLG.", 
                    ImagePath="doritosTriple.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Mountain Dew",
                    Description = "Fuel for REAL gamers.",
                    ImagePath="mountainDew.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "MLG Mouse",
                    Description = "This mouse has more DPI than any other, you are guarenteed to PWN or your money back.",
                    ImagePath="mlgmouse.jpeg",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Stainless Steel XBOX360 Controller",
                    Description = "Literally makes you 150% better.",
                    ImagePath="xboxcontroller.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Good TV",
                    Description = "A good TV",
                    ImagePath="goodtv.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Retro TV",
                    Description = "Even better than the good TV.",
                    ImagePath="roomtv.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "PC World Speakers",
                    Description = "'Fantastic! 10/10' - PCWorld",
                    ImagePath="bestspeakers.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Sweet Amp",
                    Description = "A Sweet Amp.",
                    ImagePath="sweetamp.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Futuristic HIfi System",
                    Description = "Alien technology that fell through the roof last night.",
                    ImagePath="futurehifi.png",
                    UnitPrice = 32.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Sound Blaster Pro",
                    Description = "Literally the best sound card from 1994.",
                    ImagePath="soundplayerpro.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "GeForce4",
                    Description = "Passed through my family for generations.",
                    ImagePath="gforce4.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "32GB HardDrive",
                    Description = "I lost the other 32GB.",
                    ImagePath="harddrive.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Ram",
                    Description = "Some Ram",
                    ImagePath="ram.jpeg",
                    UnitPrice = 95.00,
                    CategoryID = 4
                }
            };

            return products;
        }
    }
}