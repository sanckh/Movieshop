using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movieshop.API.ResponseModel;

namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountCountroller : ControllerBase
    {
        List<AccountResponseModel> accountList;
        public AccountCountroller()
        {
            accountList = new List<AccountResponseModel>
            {
            };
        }

        public IActionResult Get()
        {
            return Ok(accountList);
        }

        [Route("{id:int}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            return id < 1 ? BadRequest() : Ok(accountList.Where(x => x.Id == id).FirstOrDefault());
        }

        //[Route("{name}")]
        //public IActionResult GetByName(string name)
        //{
        //    return string.IsNullOrEmpty(name) ? NoContent() : Ok(accountList.Where(x => x.Name == name).FirstOrDefault());
        //}
    }
}