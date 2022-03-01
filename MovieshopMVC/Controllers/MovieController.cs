﻿using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using MovieshopMVC.Models;
using ApplicationCore.Models;

namespace MovieshopMVC.Controllers
{
    public class MovieController:Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            var movies = _movieService.GetMoviesByPagination(10, 1, "");
            return View(movies);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MovieCreateRequestModel model)
        {
            try
            {
               // _movieService.AddMovie(model); //add from movie service class
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(model);
            }
            
        }
    }
}
