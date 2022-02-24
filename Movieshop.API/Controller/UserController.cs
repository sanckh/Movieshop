using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //List<UserResponseModel> userList;
        //public UserController()
        //{
        //    userList = new List<UserResponseModel>
        //    {
        //    };
        //}

        //public IActionResult Get()
        //{
        //    return Ok(userList);
        //}

        //[Route("{id:int}")]
        //[HttpGet]
        //public IActionResult Get(int id)
        //{
        //    return id < 1 ? BadRequest() : Ok(userList.Where(x => x.Id == id).FirstOrDefault());
        //}

        //[Route("{name}")]
        //public IActionResult GetByName(string name)
        //{
        //    return string.IsNullOrEmpty(name) ? NoContent() : Ok(userList.Where(x => x.Name == name).FirstOrDefault());
        //}
    }
}