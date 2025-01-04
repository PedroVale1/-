using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Data;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(ProductModel product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpGet("v1/products")]
        public IActionResult GetAll([FromServices] AppDbContext context)
        {
            var products = context.Products
                                   .ToList();
            return Ok(products);
        }
        [HttpGet("v2/products")]
        public IActionResult Get([FromServices] AppDbContext context)
        {
            var products = context.Products
                                   .OrderBy(p => p.Price) // Ordenação pelo valor
                                   .ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id, [FromServices] AppDbContext context)
        {
            var product = context.Products.Find(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
