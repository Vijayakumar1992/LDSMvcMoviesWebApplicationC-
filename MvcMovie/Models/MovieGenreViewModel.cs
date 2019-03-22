using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies;
        public SelectList Genres;
        public string MovieGenre { get; set; }
        public SelectList ReleaseDate { get; set; }
        public string SearchString { get; set; }
        public string SortBy { get; set; }
        public SelectList MovieSortBy { get; set; }
    }
}