using AIChatBot.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AIChatController : ControllerBase
{
    [HttpPost("ask")]
    public IActionResult Ask([FromBody] ChatRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Question))
            return BadRequest("السؤال مطلوب");

        // مثال على الرد البسيط (هنطور ده بعدين)
        var answer = $"انت سألت: {request.Question} - والإجابة هتبقى هنا قريب 😊";

        return Ok(new ChatResponse { Answer = answer });
    }
}
