﻿using Model.Dtos;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;

namespace ViewModel
{
    public class ProductViewModel
    {
        private readonly ProductService _productService;

        public ProductViewModel()
        {
            _productService = new ProductService();
        }
        public dynamic FillGrid()
        {
            return _productService.Select();
        }
        public void Save(ProductSaveDto productSaveDto)
        {
            var product = new Product()
            {
                Titel = productSaveDto.Title,
                UnitPrice = productSaveDto.UnitPrice,
            };
            _productService.Insert(product);
        }
        public void Delete(PersonAndProductDeleteDto personAndProductDeleteDto)
        {
            var product = new Product()
            {
                Id = personAndProductDeleteDto.Id,
            };
            _productService.Remove(product);
        }
    }
}
