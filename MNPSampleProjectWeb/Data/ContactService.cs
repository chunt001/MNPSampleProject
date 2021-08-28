using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
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

        public async Task<Contact> AddContact(Contact contact)
        {
            var response = await httpClient.PostAsJsonAsync<Contact>("", contact);
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<Contact>(body, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }

            return null;
        }

        public async Task UpdateContact(Contact contact)
        {
            //var response = await httpClient.PutAsJsonAsync<Contact>("");

        }
        public async Task<Contact[]> GetContacts()
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<Contact[]>("");
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
