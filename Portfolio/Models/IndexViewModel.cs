using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Project> projects { get; set; }
        public IEnumerable<Blog> blogs { get; set; }
        public IEnumerable<OpenSourceProjects> OpenSourceProjects { get; set; }

    }
}
