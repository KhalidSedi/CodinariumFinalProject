using Entities.Concrete.TableModels;

namespace Entities.Concrete.Dtos
{
    public class AboutDto
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public static About ToAbout(AboutDto dto)
        {
            About about = new()
            {
                Id = dto.Id,
                Description = dto.Description,
            };

            return about;
        }
    }
}
