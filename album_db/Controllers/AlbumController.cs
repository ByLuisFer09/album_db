using album_db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace album_db.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {

        private readonly DataBaseContext _dataBaseContext;
        public AlbumController(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        //Get
        [HttpGet("GetAll")]
        public IActionResult getArtista()
        {
            return Ok(_dataBaseContext.album.ToList());
        }

        //Post
        [HttpPost("Post/")]
        public IActionResult postArtista([FromForm] Album request)
        {
            try
            {
                _dataBaseContext.album.Add(request);
                _dataBaseContext.SaveChanges();
                return Ok(request);
            }
            catch (System.Exception)
            {
                return StatusCode(500, "Error");
            }
        }
    }
}
