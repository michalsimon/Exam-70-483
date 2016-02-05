namespace NorthwindsConsole
{
    using System.Diagnostics;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Simple Select
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                var categories = from c in db.Categories select c;

                foreach (Categories category in categories)
                {
                    Debug.WriteLine(
                        string.Format("CategoryId: {0}, CategoryName: {1}", category.CategoryID, category.CategoryName));
                }
            }

            // Select with a join
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                var products = from c in db.Categories
                               join p in db.Products on c.CategoryID equals p.CategoryID
                               select p;

                foreach (Products product in products)
                {
                    Debug.WriteLine(
                        string.Format(
                            "ProductName: {0}, CategorName: {1}", 
                            product.ProductName, 
                            product.Categories.CategoryName));
                }
            }

            // Add a record
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                Categories category = new Categories() { 
                    CategoryName = "Alcohol", 
                    Description = "Happy Beverages" 
                };

                db.Categories.Add(category);
                db.SaveChanges();
            }

            // Update a record
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                Categories category = db.Categories.First(c => c.CategoryName == "Alcohol");
                category.Description = "Happy People";
                db.SaveChanges();
            }

            // Delete a record
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                Categories category = db.Categories.First(c => c.CategoryName == "Alcohol");
                db.Categories.Remove(category);
                db.SaveChanges();
            }

            // Call a stored procedure.
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                var custOrderHist = db.CustOrderHist("ALFKI");

                foreach (CustOrderHist_Result result in custOrderHist)
                {
                    Debug.WriteLine(
                        string.Format("ProductName: {0}, Total: {1}", 
                        result.ProductName, 
                        result.Total));
                }
            }
        }
    }
}