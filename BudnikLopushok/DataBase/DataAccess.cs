using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudnikLopushok.DataBase
{
    public class DataAccess
    {
        public delegate void RefreshListDelegate();
        public static event RefreshListDelegate RefreshList;

        public static List<Product> GetProducts() => LopushokDBEntities.GetContext().Products.ToList();

        internal static List<ProductType> GetProductTypes() => LopushokDBEntities.GetContext().ProductTypes.ToList();

        internal static void SaveProduct(Product product)
        {
            if (product.Id == 0)
                LopushokDBEntities.GetContext().Products.Add(product);
            LopushokDBEntities.GetContext().SaveChanges();
            RefreshList?.Invoke();
        }

        internal static void DeleteProduct(Product product)
        {
            LopushokDBEntities.GetContext().Products.Remove(product);
            LopushokDBEntities.GetContext().SaveChanges();
            RefreshList?.Invoke();
        }
    }
}
