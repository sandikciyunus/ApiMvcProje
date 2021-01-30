using ApiMvcProje.Business.Abstract;
using ApiMvcProje.Dto.Concrete;
using ApiMvcProje.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMvcProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        private IMapper _mapper;
        public ProductController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<IList<ProductDTO>>(_productService.GetAll()));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_mapper.Map<ProductDTO>(_productService.GetById(id)));
        }

        [HttpPost]
        public IActionResult AddProduct(ProductDTO productDTO)
        {
            _productService.Add(_mapper.Map<Product>(productDTO));
            return Created("", "Ürün başarıyla eklendi");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(ProductDTO productDTO)
        {
            _productService.Update(_mapper.Map<Product>(productDTO));
            return Ok("Ürün başarıyla güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _productService.GetById(id);
            _productService.Delete(product);
            return Ok("Ürün başarıyla silindi");
        }

    }
}
