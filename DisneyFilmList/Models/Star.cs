using System.ComponentModel.DataAnnotations.Schema;

namespace DisneyFilmList.Models
{
    public class Star
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StarID { get; set; }
        public string Name { get; set; }
    }
}