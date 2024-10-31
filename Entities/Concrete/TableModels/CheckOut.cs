using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class CheckOut : BaseEntity, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string? State { get; set; }
        public string City { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public int ZipCode { get; set; }
    }
}
