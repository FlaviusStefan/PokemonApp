using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonApp.Data;

namespace PokemonApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly DataContext _context;
        private readonly Mapper _mapper;

        public CategoryController(DataContext context, Mapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
