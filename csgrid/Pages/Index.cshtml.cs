using System;
using System.Collections.Generic;
using csgrid.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csgrid.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
            Movies = new List<Movie>();

            Movies.Add(new Movie {
                ID = 0,
                Genre = "Romantic Comedy",
                Price = 7.5m,
                ReleaseDate = new DateTime(2018, 1, 1),
                Title = "When Harry Met Sally" });
        }

        private DateTime DateTime(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public List<Movie> Movies;

        public void OnGet()
        {

        }
    }
}