using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using CollegeWebStore.Models;

namespace CollegeWebStore
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProducts(int? categoryId)
        {
            var _db = new CollegeWebStore.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }

        public IQueryable<Product> GetProductsFromSearch([QueryString("searchString")] String searchSting, [QueryString("id")] int? categoryId)
        {
            var _db = new CollegeWebStore.Models.ProductContext();
            IQueryable<Product> query = GetProducts(categoryId); //get by catagory (or all if none exists)
            String s = searchSting;
            if (!String.IsNullOrEmpty(s))
            {
                s.Replace("\"", "");
                query = query.Where(p => p.ProductName.Contains(s)); //get it by the search string
            }
            return query;
        }

    }
}