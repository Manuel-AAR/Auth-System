using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using backend.Models.DTOs;
using backend.Models;
using backend.Data;
using backend.Services;
using backend.Repositories;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController 
{
    [HttpPost("GoogleOAuth")]
    public Task<IActionResult> GoogleOAuth ([FromBody] GoogleOAuthDTO dto)
    {
        
    }

    [HttpPost("Login")]
    public Task<IActionResult> Login ([FromBody] LoginDTO dto)
    {

    }

    [HttpPost("Logout")]
    public Task<IActionResult> Logout ()
    {
        
    }

    [HttpPost("Register")]
    public Task<IActionResult> Register ([FromBody] RegisterDTO dto)
    {

    }

    [HttpPost("RequestRecovery")]
    public Task<IActionResult> RequestRecovery ([FromBody] RequestRecoveryDTO dto)
    {

    }

    [HttpPost("PerformRecovery")]
    public Task<IActionResult> PerformRecovery ([FromBody] PerformRecoveryDTO dto)
    {

    }

    [HttpPost("GetUser")]
    public Task<IActionResult> GetUser ([FromBody] GetUserDTO dto)
    {

    }

    
}