using Model.Dtos;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;

namespace ViewModel
{
    public class PersonViewModel
    {
        private readonly PersonServices _personServices;

        public PersonViewModel()
        {
            _personServices = new PersonServices();
        }
        public dynamic FillGrid()
        {
            return _personServices.Select();
        }
        public void Save(PersonSaveDto personSaveDto)
        {
            var person = new Person()
            {
                FirstName = personSaveDto.FirstName,
                LastName = personSaveDto.LastName,
            };
            _personServices.Insert(person);
        }
        public void Delete(PersonDeleteDto personDeleteDto)
        {
            var person = new Person()
            {
                Id= personDeleteDto.Id,
            };
            _personServices.Remove(person);
        }
        public void Update(PersonUpdateDto personUpdateDto)
        {
            var person = new Person()
            {
                Id = personUpdateDto.Id,
                FirstName = personUpdateDto.NewFirstName,
                LastName = personUpdateDto.NewLastName,
            };
            _personServices.Update(person);
        } 
    }
}
