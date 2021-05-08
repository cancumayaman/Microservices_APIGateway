using Contact.API.Infrastructure;
using Contact.API.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Services
{
    public class ContactManager : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO()
            {
                Id = id,
                FirstName = "Can Cuma",
                LastName = "Yaman"
            };
        }
    }
}
