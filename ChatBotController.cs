// ========== Controllers/ChatBotController.cs ==========
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AIChatBot.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AIChatBot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatBotController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ChatBotController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("ask")]
        public async Task<IActionResult> Ask([FromBody] string question)
        {
            if (string.IsNullOrWhiteSpace(question))
                return BadRequest("Please enter a question.");

            var products = await _context.Products.ToListAsync();
            var foundProduct = products.FirstOrDefault(p => question.ToLower().Contains(p.Name.ToLower()));

            if (foundProduct != null)
            {
                var response = $"\n🔧 المنتج: {foundProduct.Name}\n📄 الوصف: {foundProduct.Description}\n🧰 الاستخدام: {foundProduct.Usage}\n⚙️ طريقة التركيب: {foundProduct.InstallationInstructions}";
                return Ok(response);
            }

            return Ok("معذرة، لم أتمكن من العثور على معلومات عن المنتج المطلوب.");
        }
    }
}

