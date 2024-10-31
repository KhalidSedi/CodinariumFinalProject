using Entities.Concrete.TableModels;

namespace Entities.Concrete.Dtos
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IconName { get; set; }

        public static Category ToCategory(CategoryUpdateDto dto)
        {
            Category category = new()
            {
                Id = dto.Id,
                Name = dto.Name,
                IconName = dto.IconName,
            };

            return category;
        }
    }
}
