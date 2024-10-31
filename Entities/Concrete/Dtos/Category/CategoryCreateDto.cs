using Entities.Concrete.TableModels;

namespace Entities.Concrete.Dtos
{
    public class CategoryCreateDto
    {
        public string CategoryName { get; set; }
        public string IconName { get; set; }

        public static Category ToCategory(CategoryCreateDto dto)
        {
            Category category = new()
            {
                Name = dto.CategoryName,
                IconName = dto.IconName,
            };
            return category;
        }
    }
}
