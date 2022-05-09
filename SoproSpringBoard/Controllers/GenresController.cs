using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SoproSpringBoard.Domain.Models;
using SoproSpringBoard.Repository;
using SoproSpringBoard.Service.Interface;

namespace SoproSpringBoard.Controllers
{
    public class GenresController : Controller
    {
        private readonly IGenreService _genreService;
        private readonly ILogger<GenresController> _logger;

        public GenresController(IGenreService genreService, ILogger<GenresController> logger)
        {
            _genreService = genreService;
            _logger = logger;
        }

        // GET: Genres
        public async Task<IActionResult> Index()
        {
            try
            {
                return View(_genreService.GetAllGenres());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return View(new List<Genre>());
            }
        }

        // GET: Genres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                _genreService.CreateNewGenre(genre);
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }


        private bool GenreExists(int id)
        {
            return _genreService.GetDetailsForGenre(id) != null;
        }
    }
}
