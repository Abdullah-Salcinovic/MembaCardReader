using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Backend.Endpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public UserController(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserResponse>>> GetUsers()
        {
            var users = await _context.Users.Include(u => u.Resources).ToListAsync();
            return users.Select(u => new UserResponse(u)).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetUser(string id)
        {
            var user = await _context.Users.Include(u => u.Resources).FirstOrDefaultAsync(u => u.UserId == id);

            if (user == null)
            {
                return NotFound();
            }

            return new UserResponse(user);
        }

        // GET: api/User/search?name=string&id=string or api/User/search?name=string or api/User/search?id=string
        [HttpGet]
        [Route("search")]
        public async Task<ActionResult<IEnumerable<UserResponse>>> SearchUsers(string? name, string? id)
        {
            var users = await _context.Users.Include(u => u.Resources).ToListAsync();
            if (name != null)
            {
                users = users.Where(u => u.Name.ToLower().Contains(name.ToLower())).ToList();
            }
            if (id != null)
            {
                users = users.Where(u => u.UserId.Contains(id)).ToList();
            }
            return users.Select(u => new UserResponse(u)).ToList();
        }

        [HttpPost]
        public async Task<ActionResult<UserResponse>> PostUser(CreateUserRequest request)
        {
            var user = new User
            {
                UserId = request.UserId,
                Name = request.Name,
                Sex = request.Sex,
                DateOfBirth = request.DateOfBirth,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                SubscriptionType = request.SubscriptionType,
                ValidUntil = request.ValidUntil,
                Resources = request.Resources.Select(r => new Resource
                {
                    StandardFilament = r.StandardFilament,
                    Resin = r.Resin,
                    Cncmill = r.Cncmill,
                    LaserCutter = r.LaserCutter,
                    PremiumFilament = r.PremiumFilament,
                    QualifiedForCrealityPrinters = r.QualifiedForCrealityPrinters,
                    QualifiedForRaise3D = r.QualifiedForRaise3D,
                    QualifiedForLcdprinters = r.QualifiedForLcdprinters,
                    QualifiedForTools = r.QualifiedForTools,
                    QualifiedForComputers = r.QualifiedForComputers,
                    QualifiedForElectronics = r.QualifiedForElectronics
                }).ToList()
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, new UserResponse(user));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(string id, UpdateUserRequest request)
        {
            if (id != request.UserId)
            {
                return BadRequest();
            }

            var user = await _context.Users.Include(u => u.Resources).FirstOrDefaultAsync(u => u.UserId == id);

            if (user == null)
            {
                return NotFound();
            }

            user.Name = request.Name;
            user.Sex = request.Sex;
            user.DateOfBirth = request.DateOfBirth;
            user.PhoneNumber = request.PhoneNumber;
            user.Email = request.Email;
            user.SubscriptionType = request.SubscriptionType;
            user.ValidUntil = request.ValidUntil;
            user.Resources = request.Resources.Select(r => new Resource
            {
                StandardFilament = r.StandardFilament,
                Resin = r.Resin,
                Cncmill = r.Cncmill,
                LaserCutter = r.LaserCutter,
                PremiumFilament = r.PremiumFilament,
                QualifiedForCrealityPrinters = r.QualifiedForCrealityPrinters,
                QualifiedForRaise3D = r.QualifiedForRaise3D,
                QualifiedForLcdprinters = r.QualifiedForLcdprinters,
                QualifiedForTools = r.QualifiedForTools,
                QualifiedForComputers = r.QualifiedForComputers,
                QualifiedForElectronics = r.QualifiedForElectronics
            }).ToList();

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var resource = await _context.Resources
                .Where(r => r.UserId == id)
                .OrderByDescending(r => r.ResourceId)
                .LastOrDefaultAsync();

            if (resource != null)
            {
                _context.Resources.Remove(resource);
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }


        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }

        public class UserResponse
        {
            public string UserId { get; set; }
            public string Name { get; set; }
            public string Sex { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string? PhoneNumber { get; set; }
            public string? Email { get; set; }
            public string? SubscriptionType { get; set; }
            public DateTime? ValidUntil { get; set; }
            public List<ResourceResponse> Resources { get; set; }

            public UserResponse(User user)
            {
                UserId = user.UserId;
                Name = user.Name;
                Sex = user.Sex;
                DateOfBirth = user.DateOfBirth;
                PhoneNumber = user.PhoneNumber;
                Email = user.Email;
                SubscriptionType = user.SubscriptionType;
                ValidUntil = user.ValidUntil;
                Resources = user.Resources.Select(r => new ResourceResponse(r)).ToList();
            }
        }

        public class ResourceResponse
        {
            public int ResourceId { get; set; }
            public string? UserId { get; set; }
            public int? StandardFilament { get; set; }
            public int? Resin { get; set; }
            public decimal? Cncmill { get; set; }
            public decimal? LaserCutter { get; set; }
            public int? PremiumFilament { get; set; }
            public bool? QualifiedForCrealityPrinters { get; set; }
            public bool? QualifiedForRaise3D { get; set; }
            public bool? QualifiedForLcdprinters { get; set; }
            public bool? QualifiedForTools { get; set; }
            public bool? QualifiedForComputers { get; set; }
            public bool? QualifiedForElectronics { get; set; }

            public ResourceResponse(Resource resource)
            {
                ResourceId = resource.ResourceId;
                UserId = resource.UserId;
                StandardFilament = resource.StandardFilament;
                Resin = resource.Resin;
                Cncmill = resource.Cncmill;
                LaserCutter = resource.LaserCutter;
                PremiumFilament = resource.PremiumFilament;
                QualifiedForCrealityPrinters = resource.QualifiedForCrealityPrinters;
                QualifiedForRaise3D = resource.QualifiedForRaise3D;
                QualifiedForLcdprinters = resource.QualifiedForLcdprinters;
                QualifiedForTools = resource.QualifiedForTools;
                QualifiedForComputers = resource.QualifiedForComputers;
                QualifiedForElectronics = resource.QualifiedForElectronics;
            }
        }

        public class CreateUserRequest
        {
            public string UserId { get; set; }
            public string Name { get; set; }
            public string Sex { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string? PhoneNumber { get; set; }
            public string? Email { get; set; }
            public string? SubscriptionType { get; set; }
            public DateTime? ValidUntil { get; set; }
            public List<CreateResourceRequest> Resources { get; set; }
        }

        public class CreateResourceRequest
        {
            public int? StandardFilament { get; set; }
            public int? Resin { get; set; }
            public decimal? Cncmill { get; set; }
            public decimal? LaserCutter { get; set; }
            public int? PremiumFilament { get; set; }
            public bool? QualifiedForCrealityPrinters { get; set; }
            public bool? QualifiedForRaise3D { get; set; }
            public bool? QualifiedForLcdprinters { get; set; }
            public bool? QualifiedForTools { get; set; }
            public bool? QualifiedForComputers { get; set; }
            public bool? QualifiedForElectronics { get; set; }
        }

        public class UpdateUserRequest
        {
            public string UserId { get; set; }
            public string Name { get; set; }
            public string Sex { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string? PhoneNumber { get; set; }
            public string? Email { get; set; }
            public string? SubscriptionType { get; set; }
            public DateTime? ValidUntil { get; set; }
            public List<UpdateResourceRequest> Resources { get; set; }
        }

        public class UpdateResourceRequest
        {
            public int ResourceId { get; set; }
            public int? StandardFilament { get; set; }
            public int? Resin { get; set; }
            public decimal? Cncmill { get; set; }
            public decimal? LaserCutter { get; set; }
            public int? PremiumFilament { get; set; }
            public bool? QualifiedForCrealityPrinters { get; set; }
            public bool? QualifiedForRaise3D { get; set; }
            public bool? QualifiedForLcdprinters { get; set; }
            public bool? QualifiedForTools { get; set; }
            public bool? QualifiedForComputers { get; set; }
            public bool? QualifiedForElectronics { get; set; }
        }
    }
}