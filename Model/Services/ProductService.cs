using Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class ProductService
    {
        public List<Product> Select()
        {
            using(var context = new OnlineShopDbContext())
            {
                try
                {
                    var products = context.Product.ToList();
                    return products;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if(context!= null) 
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public void Insert(Product product)
        {
            using (var context = new OnlineShopDbContext())
            {
                try
                {
                    context.Product.Add(product);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        public void Remove(Product product)
        {
            using (var context = new OnlineShopDbContext())
            {
                try
                {
                    var products = context.Product.Where(d => d.Id == product.Id).First();
                    context.Product.Remove(products);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        public void Update(Product product)
        {
            using (var context = new OnlineShopDbContext())
            {
                try
                {
                    var Products = context.Product.Where(d => d.Id == product.Id).First();
                    Products.Titel = product.Titel;
                    Products.UnitPrice = product.UnitPrice;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
    }
}
