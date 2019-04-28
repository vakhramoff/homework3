using System;
using System.Threading.Tasks;
//using Dapper;
using homework3.Models;
using homework3.Services.Interfaces;
//using Npgsql;

namespace homework3.Services
{
    public class UserInfoService : IUserInfoService
    {
        private const string ConnectionString = "host=localhost;port=5432;database=postgres;username=postgres;password=1234560";

        public async Task<Contact> GetById(Guid id)
        {
            Contact contact = new Contact
            {
                Email = "tcook@apple.com",
                Id = id,
                Nickname = "@tim_cook",
                Phone = "+44 7539 476802‬",
                Position = "CEO"
            };

            return await Task.FromResult<Contact>(contact);
        }

        //{
        //    using (var connection = new NpgsqlConnection(ConnectionString))
        //    {
        //        return await connection.QuerySingleAsync<Contact>("SELECT * FROM Users WHERE Id = @id", new { id });
        //    }
        //}
    }

}