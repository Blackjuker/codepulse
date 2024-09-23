using CodePulse.API.Data;
using CodePulse.API.Mapper;
using CodePulse.API.Models.DTO;
using CodePulse.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryMapper _categoryMapper;
        private readonly ICategoryRepository _categoryRepository;
        
        public CategoriesController(CategoryMapper categoryMapper,ICategoryRepository categoryRepository)
        {
            _categoryMapper = categoryMapper;
            _categoryRepository = categoryRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            var category = _categoryMapper.RequestCategoryToCategory(request);
            
            await _categoryRepository.CreateAsync(category);

            var Response = new
            {
                Message = "Message",
                Response = "Category creer avec success"
            };
            return Ok(Response);
        }
    }
}
