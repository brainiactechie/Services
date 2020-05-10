using System.Collections.Generic;
using System.Threading.Tasks;
using DeepInServices.models;
using DeepInServices.services;
using Microsoft.AspNetCore.Components;

namespace DeepInServices.Pages.Components
{
  public  class PostListBase : ComponentBase
    {
      [Inject]
	  public IPostService postservices { get; set; }
	  public IEnumerable<Post> Posts { get; set; }


	  protected override async Task OnInitializedAsync(){
		  Posts = await postservices.GetPosts();
	  }
    }
}
