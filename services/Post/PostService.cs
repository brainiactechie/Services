using System.Threading.Tasks;
using System.Collections.Generic;
using DeepInServices.models;
namespace DeepInServices.services{
	public interface  IPostService{
		Task<IEnumerable<Post>> GetPosts();
		Task<Post> GetPost(int Id);
		Task<User> GetUser(int Id);
	}
}
