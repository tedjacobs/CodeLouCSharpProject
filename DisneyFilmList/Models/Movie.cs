﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DisneyFilmList.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; }


        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        public Producer Producer { get; set; }
        public Star Star { get; set; }
    }
}