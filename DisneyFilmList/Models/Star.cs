using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DisneyFilmList.Models
{
    public class Star
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StarID { get; set; }
        public string Name { get; set; }


    }
}