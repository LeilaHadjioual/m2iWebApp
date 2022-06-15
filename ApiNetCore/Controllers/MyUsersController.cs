using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiNetCore.Models;

namespace ApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyUsersController : ControllerBase
    {
        private readonly TodoContext _context;

        public MyUsersController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/MyUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyUsers>>> GetMyUsers()
        {
            return await _context.MyUsers.ToListAsync();
        }

        // GET: api/MyUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyUsers>> GetMyUsers(long id)
        {
            var myUsers = await _context.MyUsers.FindAsync(id);

            if (myUsers == null)
            {
                return NotFound();
            }

            return myUsers;
        }

        // PUT: api/MyUsers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyUsers(long id, MyUsers myUsers)
        {
            if (id != myUsers.Id)
            {
                return BadRequest();
            }

            _context.Entry(myUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyUsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MyUsers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MyUsers>> PostMyUsers(MyUsers myUsers)
        {
            _context.MyUsers.Add(myUsers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMyUsers", new { id = myUsers.Id }, myUsers);
        }

        // DELETE: api/MyUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MyUsers>> DeleteMyUsers(long id)
        {
            var myUsers = await _context.MyUsers.FindAsync(id);
            if (myUsers == null)
            {
                return NotFound();
            }

            _context.MyUsers.Remove(myUsers);
            await _context.SaveChangesAsync();

            return myUsers;
        }

        private bool MyUsersExists(long id)
        {
            return _context.MyUsers.Any(e => e.Id == id);
        }
    }
}
