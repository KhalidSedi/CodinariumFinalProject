using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class Contact : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
