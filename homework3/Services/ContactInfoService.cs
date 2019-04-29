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
        private const string ConnectionString = "host=89.208.199.118; port=5432; database=PostgreSQL-2564; username=student; password=password";

        public async Task<Contact> GetById(Guid id)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                return await connection.QuerySingleAsync<Contact>("SELECT * FROM \"vakhramoff\".\"Contacts\" WHERE id = @id", new { id });
            }
        }

        public async Task<Contact> AppendContact(Contact contact)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                string query = "INSERT INTO \"vakhramoff\".\"Contacts\" (id, email, nickname, phone, position) VALUES (@id, @email, @nickname, @phone, @position) RETURNING *";


                return await connection.QuerySingleAsync<Contact>(query, contact);
            }
        }
    }

}