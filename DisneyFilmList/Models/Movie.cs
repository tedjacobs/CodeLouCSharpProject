using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisneyFilmList.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:ddd, MMM d, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        
        public Producer Producer { get; set; }
        public Star Star { get; set; }
    }
}