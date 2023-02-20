using Microsoft.EntityFrameworkCore.Internal;
using Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
        public void Remove(Person person)
        {
            using (var context = new OnlineShopDbContext())
            {
                try
                {
                    var people = context.Person.Where(p => p.Id == person.Id).First();
                    //Table Person ba DbSet be vojod omade, ba "context" ke be database vasle. az Where astefade mishe ke ta address va motaghayer khodemon ro moarefi konim. p.Id migharde har ja ba person.Id barabar ya yeki khodesh ro peyda kone, meghdar khodesh ro ham ke ma midim. First() karesh ine ke avalin ghozinee ke peyda kard ro baraye ma antekhab kone.
                    context.Person.Remove(people);
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
        public void Update(Person person)
        {
            using (var context = new OnlineShopDbContext())
            {
                try
                {
                    var people = context.Person.Where(p => p.Id == person.Id).First();
                    people.FirstName = person.FirstName;
                    people.LastName = person.LastName;
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
