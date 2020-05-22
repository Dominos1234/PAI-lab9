using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required!")]
        [StringLength(100, ErrorMessage = "Maximal length of the name of a song is 100 characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Artist is required!")]
        [StringLength(30, ErrorMessage = "Maximal length of the name of a artist is 30 characters!")]
        public string Artist { get; set; }

        [Required(ErrorMessage = "Genre is required!")]
        public int GenreId { get; set; }
    }
}