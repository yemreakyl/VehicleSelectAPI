using Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleSelectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]// Bu methodun kendi içimde kullanılan bir methot olduğunu belirttim
        public ActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null) { StatusCode = response.StatusCode };
            else
            {
                return new ObjectResult(response) { StatusCode = response.StatusCode };
            }
        }
    }
}
