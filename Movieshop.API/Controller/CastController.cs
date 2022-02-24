using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastController : ControllerBase
    {
        //List<CastResponseModel> castList;
        //public CastController()
        //{
        //    castList = new List<CastResponseModel>
        //    {
        //    };
        //}

    //    public IActionResult Get()
    //    {
    //        return Ok(castList);
    //    }

    //    [Route("{id:int}")]
    //    [HttpGet]
    //    public IActionResult Get(int id)
    //    {
    //        return id < 1 ? BadRequest() : Ok(castList.Where(x => x.Id == id).FirstOrDefault());
    //    }

    //    [Route("{name}")]
    //    public IActionResult GetByName(string name)
    //    {
    //        return string.IsNullOrEmpty(name) ? NoContent() : Ok(castList.Where(x => x.Name == name).FirstOrDefault());
    //    }
    }
}