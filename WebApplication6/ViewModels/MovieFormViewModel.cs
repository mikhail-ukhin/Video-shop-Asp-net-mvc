using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public bool IsModelNull => Movie == null;

    }
}