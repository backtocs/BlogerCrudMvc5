using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bloger.Models
{
    public class Blog
    {
        [Required]
        public int id { get; set; }
        [Required, StringLength(50)]
        public string title { get; set; }
        [Required, StringLength(50)]
        public string author { get; set; }
        [Required]
        public string content { get; set; }
        [Required]
        public DateTime created { get; set; }

        public Blog()
        {
            created = DateTime.Now;
        }
    }
}