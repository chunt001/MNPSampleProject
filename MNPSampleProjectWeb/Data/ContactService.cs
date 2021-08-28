using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MNPSampleProjectWeb.Data
{
    public class ContactService : IContactService
    {
        private readonly HttpClient httpClient;

        public ContactService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<IEnumerable<Contact>>("");
                return response;
                //if (response.IsError == false)
                //{
                //    return response.Result;
                //}
                //else
                //{
                //    throw new ApplicationException(response.Message);
                //}
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
