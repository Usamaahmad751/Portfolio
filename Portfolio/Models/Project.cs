using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }
        public string Tagline { get; set; }

        [BindProperty]
        public string ImagePath { get; set; }
          public string Specification { get; set; }
        public string Technologies { get; set; }
    }
}
