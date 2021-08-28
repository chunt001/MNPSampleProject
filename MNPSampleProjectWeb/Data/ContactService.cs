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
            try
            {
                var response = await httpClient.PostAsJsonAsync<Contact>("", contact);
                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStreamAsync();
                    return await JsonSerializer.DeserializeAsync<Contact>(body, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                }
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateContact(Contact contact)
        {
            var response = await httpClient.PutAsJsonAsync<Contact>(contact.Id.ToString(), contact);

        }
        public async Task<Contact[]> GetContacts()
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<Contact[]>("");
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Contact> GetContact(int Id)
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<Contact>(Id.ToString());
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
