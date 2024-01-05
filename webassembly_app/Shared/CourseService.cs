using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace webassembly_app.Shared
{
    public class CourseService
    {
        private readonly HttpClient _httpClient;

        public CourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Course>>("api/courses");
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
            var response = await _httpClient.PostAsJsonAsync("api/courses", course);
            return await response.Content.ReadFromJsonAsync<Course>();
        }

        // Add other CRUD operations as needed...
    }

}
