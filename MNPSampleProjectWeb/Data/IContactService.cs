using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNPSampleProjectWeb.Data
{
    public interface IContactService
    {
        Task<Contact[]> GetContacts();

        Task<Contact> AddContact(Contact contact);
        Task UpdateContact(Contact contact);

    }
}
