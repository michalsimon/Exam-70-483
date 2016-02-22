namespace NorthwindsClient
{
    using System;
    using System.Data.Services.Client;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Net;

    using NorthwindsClient.NorthwindsServiceReference;

    internal class Program
    {
        private static void Main(string[] args)
        {
            GetCategories();
            AddCategory();
            UpdateRecord();
            DeleteRecord();
            GetCategoriesAsJSON();
        }

        private static void GetCategories()
        {
            NorthwndEntities db =
                new NorthwndEntities(new Uri("http://localhost/NorthwindsWCFDataService/NorthwindsService.svc/"));

            var categories = from c in db.Categories select c;
            foreach (Categories category in categories)
            {
                Debug.WriteLine(
                    string.Format("CategoryId: {0}, CategoryName: {1}", category.CategoryID, category.CategoryName));
            }
        }

        private static void AddCategory()
        {
            NorthwndEntities db =
                new NorthwndEntities(new Uri("http://localhost/NorthwindsWCFDataService/NorthwindsService.svc/"));

            // Create a category
            Categories category = new Categories() { CategoryName = "Alcohol", Description = "Happy Beverages" };
            db.AddToCategories(category);
            DataServiceResponse response = db.SaveChanges();
            if (response.First().StatusCode == (int)HttpStatusCode.Created)
            {
                Debug.WriteLine("New CategoryId: {0}", category.CategoryID);
            }
            else
            {
                Debug.WriteLine("Error: {0}", response.First().Error.Message);
            }
        }

        private static void UpdateRecord()
        {
            NorthwndEntities db =
                new NorthwndEntities(new Uri("http://localhost/NorthwindsWCFDataService/NorthwindsService.svc/"));

            Categories category = db.Categories.Where(c => c.CategoryName == "Alcohol").FirstOrDefault();

            category.Description = "Happy People";

            db.UpdateObject(category);

            db.SaveChanges();
        }

        private static void DeleteRecord()
        {
            NorthwndEntities db =
                new NorthwndEntities(new Uri("http://localhost/NorthwindsWCFDataService/NorthwindsService.svc/"));

            Categories category = db.Categories.Where(c => c.CategoryName == "Alcohol").FirstOrDefault();

            db.DeleteObject(category);

            db.SaveChanges();
        }

        private static void GetCategoriesAsJSON()
        {
            HttpWebRequest req =
                (HttpWebRequest)
                WebRequest.Create(
                    "http://localhost/NorthwindsWCFDataService/NorthwindsService.svc/Categories(1)?$select=CategoryID,CategoryName,Description");

            req.Accept = "application/json;odata=verbose";

            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                Stream s = resp.GetResponseStream();
                StreamReader readStream = new StreamReader(s);

                string jsonString = readStream.ReadToEnd();

                Debug.WriteLine(jsonString);

                resp.Close();
                readStream.Close();
            }
        }
    }
}