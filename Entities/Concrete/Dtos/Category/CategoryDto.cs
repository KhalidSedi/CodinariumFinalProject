using Entities.Concrete.TableModels;

namespace Entities.Concrete.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string IconName { get; set; }

        public static Category ToCategory(CategoryDto dto)
        {
            Category category = new()
            {
                Id = dto.Id,
                Name = dto.CategoryName,
                IconName = dto.IconName,
            };

            return category;
        }
    }
}
