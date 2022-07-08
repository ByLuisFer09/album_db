using System.ComponentModel.DataAnnotations;

namespace album_db.Models
{
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        public string Nombre { get; set; }
        public Artista artista { get; set; }
        public Genero genero { get; set; }
        
    }
}
