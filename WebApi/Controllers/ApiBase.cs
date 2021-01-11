using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public abstract class ApiBase : ControllerBase
    {
        protected new IActionResult Response(object result = null)
        {
            var success = true;

            if (result == null)
                success = false;

            return Ok(new
            {
                success,
                data = result
            });
        }
    }
}
