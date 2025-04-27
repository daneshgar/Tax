using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax.Domain.ValueObject;

namespace Tax.Domain.Entities
{
    public class UserEntity : Entity<UserId>
    {
        public string Username { get; private set; }
        public string PersonName { get; private set; }

        private UserEntity() { }

        public UserEntity(UserId id, string username, string personName) : base(id)
        {
            Username = username;
            PersonName = personName;
        }
    }
}
