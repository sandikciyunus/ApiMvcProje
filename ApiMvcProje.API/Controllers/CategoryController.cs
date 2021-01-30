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
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        private IProductService _productService;
        private IMapper _mapper;

        public CategoryController(ICategoryService categoryService,IMapper mapper,IProductService productService)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<IList<CategoryDTO>>(_categoryService.GetAll()));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_mapper.Map<CategoryDTO>(_categoryService.GetById(id)));
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryDTO categoryDTO)
        {
            _categoryService.Add(_mapper.Map<Category>(categoryDTO));

            return Created("", "Kategori başarıyla eklendi");
        }

        [HttpGet("{id}/products")]
        public IActionResult GetWithProductsById(int id)
        {
            return Ok(_productService.GetByCategoryId(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(CategoryDTO categoryDTO)
        {
            _categoryService.Update(_mapper.Map<Category>(categoryDTO));

            return Ok("Başarıyla güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _categoryService.GetById(id);
            _categoryService.Delete(category);
            return Ok("Başarıyla silindi");
        }


    }
}
