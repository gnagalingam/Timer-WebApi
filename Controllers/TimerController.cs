using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TimerController : ControllerBase
    {


        private readonly ILogger<TimerController> _logger;

        public TimerController(ILogger<TimerController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetTimerStartTime")]
        //public String GetStartTime()
        //{
        //    return "40:00";
        //}

        [HttpGet]
        [Route("GetStartTime")]
        [EnableCors("AllowOrigin")]
        public int GetStartTime()
        {
            return 20;
        }

        [HttpGet]
        [Route("StopTimer")]
        [EnableCors("AllowOrigin")]
        public bool StopTimer()
        {
            return true;
        }
    }







}