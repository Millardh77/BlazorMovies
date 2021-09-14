using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository
{
    public interface IMoviesRepository
    {
        Task<int> CreateMovie(Movie movie);
        Task<DetailsMovieDTO> GetDetailsMovieDto(int id);
        Task<IndexPageDTO> GetIndexPageDTO();
        Task<MovieUpdateDTO> GetMovieForUpdate(int id);
        Task UpdateMovie(Movie movie);
    }
}
