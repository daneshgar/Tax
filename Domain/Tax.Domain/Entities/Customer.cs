using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Tax.Domain.Common.Base;
//using Tax.Domain.Common.Enums;
//using Tax.Domain.Common.ValueObject;

namespace Tax.Domain.Entities
{
//    public class Customer : Entity<int>
//    {
//        public string Name { get; private set; }
//        public NationalCode NationalCode { get; private set; }
//        public string EconomicCode { get; private set; }
//        public string PostalCode { get; private set; }
//        public string BranchCode { get; private set; }
//        public PersonType PersonType { get; private set; }
//        public string PassportNumber { get; private set; }
//        public DateTime CreatedAt { get; private set; }
//        public DateTime? UpdatedAt { get; private set; }

//        private Customer() : base() { } // For EF

//        public Customer(int id, string name, NationalCode nationalCode, PersonType personType)
//            : base(id)
//        {
//            if (string.IsNullOrWhiteSpace(name))
//                throw new ArgumentException("Customer name cannot be empty", nameof(name));

//            Name = name;
//            NationalCode = nationalCode ?? throw new ArgumentNullException(nameof(nationalCode));
//            PersonType = personType;
//            CreatedAt = DateTime.UtcNow;
//        }

//        public void UpdateEconomicCode(string economicCode)
//        {
//            EconomicCode = economicCode;
//            UpdatedAt = DateTime.UtcNow;
//        }

//        public void UpdatePostalCode(string postalCode)
//        {
//            PostalCode = postalCode;
//            UpdatedAt = DateTime.UtcNow;
//        }

//        public void UpdateBranchCode(string branchCode)
//        {
//            BranchCode = branchCode;
//            UpdatedAt = DateTime.UtcNow;
//        }

//        public void UpdatePassportNumber(string passportNumber)
//        {
//            PassportNumber = passportNumber;
//            UpdatedAt = DateTime.UtcNow;
//        }
//    }
}
