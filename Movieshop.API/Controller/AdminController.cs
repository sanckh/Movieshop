using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        //List<AdminResponseModel> adminList;
        //public AdminController()
        //{
        //    adminList = new List<AdminResponseModel>
        //    {
        //    };
        //}

        //public IActionResult Get()
        //{
        //    return Ok(adminList);
        //}

        //[Route("{id:int}")]
        //[HttpGet]
        //public IActionResult Get(int id)
        //{
        //    return id < 1 ? BadRequest() : Ok(adminList.Where(x => x.Id == id).FirstOrDefault());
        //}

        //[Route("{name}")]
        //public IActionResult GetByName(string name)
        //{
        //    return string.IsNullOrEmpty(name) ? NoContent() : Ok(AdminList.Where(x => x.Name == name).FirstOrDefault());
        //}
    }
}