using album_db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace album_db.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistaController : ControllerBase
    {
        private readonly DataBaseContext _dataBaseContext;
        public ArtistaController(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        //Get
        [HttpGet("GetAll")]
        public IActionResult getArtista()
        {
            return Ok(_dataBaseContext.artista.ToList());
        }

        //Post
        [HttpPost("Post/")]
        public IActionResult postArtista([FromForm] Artista request)
        {
            try
            {
                _dataBaseContext.artista.Add(request);
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
