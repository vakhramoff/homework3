using System;
using System.Threading.Tasks;
using Dapper;
using homework3.Models;
using homework3.Services.Interfaces;
using Npgsql;

namespace homework3.Services
{
    public class ContactInfoService : IContactInfoService
    {
        private const string ConnectionString = "host=localhost; port=5432; database=postgres; username=postgres; password=1234560";

        public async Task<Contact> GetById(Guid id)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                return await connection.QuerySingleAsync<Contact>("SELECT * FROM public.\"Contacts\" WHERE id = @id", new { id });
            }
        }

        public async void AppendContact(Contact contact)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                string query = "INSERT INTO public.\"Contacts\" (id, email, nickname, phone, position) VALUES (@id, @email, @nickname, @phone, @position)";

                await connection.ExecuteAsync(query, contact);
            }
        }
    }

}