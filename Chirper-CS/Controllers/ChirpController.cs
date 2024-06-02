using Chirper_CS.Data;
using Chirper_CS.DTO;
using Chirper_CS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chirper_CS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChirpController : ControllerBase
    {
        private readonly ChirperDbContext _context;

        public ChirpController(ChirperDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllChirps([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            int totalChirps = await _context.Chirps.CountAsync();
            int totalPages = (int)Math.Ceiling((double)totalChirps / pageSize);
            int skipAmount = (pageNumber - 1) * pageSize;

            if(pageNumber < 1 || pageNumber > totalPages)
            {
                return BadRequest("Invalid page number");
            }

            var chirps = await _context.Chirps
                .Skip(skipAmount)
                .Take(pageSize)
                .Select(c => new ChirpResponseDTO
                {
                    ChirpId = c.ChirpId,
                    Message = c.Message,
                    UserFullName = c.User.FullName
                })
                .ToListAsync();

            var result = new
            {
                TotalPages = totalPages,
                Chirps = chirps
            };

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetChirp([FromRoute(Name = "id")] int chirpId)
        {
            var chirp = await _context.Chirps.Include(c => c.User).FirstOrDefaultAsync(c => c.ChirpId == chirpId);
            if (chirp != null)
            {
                var result = new ChirpResponseDTO() { ChirpId = chirp.ChirpId, Message = chirp.Message, UserFullName = chirp.User.FullName };
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateChirp([FromBody] ChirpAddDTO chirpAddDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var chirp = new Chirp() { Message = chirpAddDTO.Message, UserId = chirpAddDTO.UserId };
            await _context.Chirps.AddAsync(chirp);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Success" });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateChirp([FromRoute] int id, [FromBody] ChirpDTO chirp)
        {
            var existingChirp = await _context.Chirps.FindAsync(id);
            if (existingChirp != null)
            {
                existingChirp.Message = chirp.Message;
                _context.Chirps.Update(existingChirp);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Success" });
            }
            return NotFound();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteChirp([FromRoute] int id)
        {
            var chirp = await _context.Chirps.FindAsync(id);
            if(chirp == null)
            {
                return NotFound();
            }
            _context.Chirps.Remove(chirp);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
