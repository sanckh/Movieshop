﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetAllGenres();
        int InsertGenre(GenreModel model);
        int DeleteGenre(int id);
        int UpdateGenre(GenreModel model);
    }
}
