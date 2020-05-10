using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DeepInServices.models;
using System.Text.Json;
namespace DeepInServices.services
{
    public class PostData : IPostService
    {
        private readonly HttpClient http;

        public PostData(HttpClient http)
        {
            this.http = http;
        }

        public async Task<Post> GetPost(int Id)
        {
            var url = "https://jsonplaceholder.typicode.com/posts/" + Id;
            var getReq = await http.GetAsync(url);
            var post = await getReq.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Post>(post , new JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {

            var url = "https://jsonplaceholder.typicode.com/posts";
            var getReq = await http.GetAsync(new Uri(url));
            var posts = await getReq.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<IEnumerable<Post>>(posts, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<User> GetUser(int Id)
        {
            var url = "https://jsonplaceholder.typicode.com/users/"+Id;
            return await JsonSerializer.DeserializeAsync<User>(await http.GetStreamAsync(url), new JsonSerializerOptions(){PropertyNameCaseInsensitive =true});
        }
    }
}
