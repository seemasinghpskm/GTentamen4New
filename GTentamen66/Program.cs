using GTentamen66.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTentamen66
{
    class Program
    {
        static void Main(string[] args)
        {
            IncreaseBeverageByEightPercent();
        }

        private static void IncreaseBeverageByEightPercent()
        {
            using (NorthWindEntityContext cx = new NorthWindEntityContext())
            {
                var cat = (from c in cx.Categories
                          where c.CategoryName == "Beverages"
                          select c).First();
                foreach (var p in cat.Products)
                {
                    p.UnitPrice= p.UnitPrice * 1.08M;

                }
                cx.SaveChanges();
            }
        }
    }
}
