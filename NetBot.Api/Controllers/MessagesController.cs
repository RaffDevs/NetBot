using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace NetBot.Api.Controllers;

[ApiController]
[Route("messages")]
public class MessagesController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> ReceiveMessage([FromBody] JsonElement payload)
    {
        Console.WriteLine(payload);
        return Ok();
    }
    
}