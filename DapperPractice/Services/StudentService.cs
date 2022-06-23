using Dapper;
using DapperPractice.Models;
using System.Data;
using System.Data.SqlClient;

namespace DapperPractice.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudents();
    }

    public class StudentService : IStudentService
    {
        private readonly IConfiguration _configuration;

        public StudentService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var data = await db.GetListAsync<Student>();
                return data;

            }
        }
    }
}
