using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisneyFilmList.Models
{
    public class Producer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProducerID { get; set; }
        public string Name { get; set; }
    }
}