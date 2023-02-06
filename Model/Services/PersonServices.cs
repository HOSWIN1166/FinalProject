using Microsoft.EntityFrameworkCore.Internal;
using Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class PersonServices
    {
        public List<Person> Select()
        {
            using (var context = new OnlineShopDbContext())
            {
                try
                {
                    var people = context.Person.ToList();
                    return people;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if(context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public void Insert(Person person)
        {
            using (var context = new OnlineShopDbContext())
            {
                try
                {
                    context.Person.Add(person);
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
