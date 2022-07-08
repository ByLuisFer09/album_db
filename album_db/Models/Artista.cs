using System.ComponentModel.DataAnnotations;

namespace album_db.Models
{
    public class Artista
    {
        [Key]
        public int IdArtista { get; set; }
        public string Nombre { get; set; }
    }
}
