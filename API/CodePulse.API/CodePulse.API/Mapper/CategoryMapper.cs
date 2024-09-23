using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using Riok.Mapperly.Abstractions;

namespace CodePulse.API.Mapper
{
    [Mapper]
    public partial class CategoryMapper
    {
        public partial CreateCategoryRequestDto CategoryToRequestCategoryDto(Category category);
        public partial CategoryDto CategoryToCategoryDto(Category category);
        public partial Category RequestCategoryToCategory(CreateCategoryRequestDto createCategoryRequestDto);
    }
}
