using Tax.Domain.ValueObject;

namespace Tax.Domain.Entities
{
    public class CustomerEntity : Entity<CustomerId>
    {
        public string CustomerName { get; private set; }
        public string NationalCode { get; private set; }

        private CustomerEntity() { }

        public CustomerEntity(CustomerId id, string customerName, string nationalCode) : base(id)
        {
            CustomerName = customerName;
            NationalCode = nationalCode;
        }
    }

}
