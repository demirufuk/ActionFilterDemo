using ActionFilterDemo.ActionFilters;
using ActionFilterDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilterDemo.Controllers
{
    [Route("api/{merchantCode}/[controller]")]
    [ApiController]
    [MerchantCodeActionFilterAttirbute]
    public class MerchantController : BaseController
    { 
        [HttpGet]
        [Route("GetUsers")]
         public IActionResult GetUsers(string merchantCode)
        {
            return Ok($"Users returned for Merchant {merchantCode}, Page: {Page}, {PageSize}");
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult UpdateMerchant(MerchantUpdateRequestModel reqmodel)
        {
            return Ok($"Merchant updated. Name {reqmodel.MerchantName}, Code: {reqmodel.MerchantCode}");
        }

    }
}
