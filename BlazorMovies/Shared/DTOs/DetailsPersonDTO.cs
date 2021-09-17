using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMovies.Shared.DTOs
{
    public class DetailsPersonDTO
    {
        public Person Person { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
