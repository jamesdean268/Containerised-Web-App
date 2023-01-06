using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

// ------ LEARNING CODE ADDITION ------
// Configure a controller to handle HTTP requests to the /api/items route and return a list of items from the database. 

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly ItemContext _context;

    public ItemController(ItemContext context)
    {
        _context = context;
    }

    // GET: api/Item
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Item>>> GetItems()
    {
        return await _context.Items.ToListAsync();
    }
}
