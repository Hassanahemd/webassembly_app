using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace webassembly_app.Shared
{
    public class StudentService
    {
        private readonly HttpClient _httpClient;

        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Student>>("api/students");
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            var response = await _httpClient.PostAsJsonAsync("api/students", student);
            return await response.Content.ReadFromJsonAsync<Student>();
        }

        // Add other CRUD operations as needed...
    }

}
