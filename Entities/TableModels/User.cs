using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class User : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
       
    }
}
