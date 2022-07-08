using System.ComponentModel.DataAnnotations;

namespace album_db.Models
{
    public class Genero
    {
        [Key]
        public int IdGenero { get; set; }
        public string Nombre { get; set; }
    }
}
