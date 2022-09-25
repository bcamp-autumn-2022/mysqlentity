using Entitytest.API.Crud.Data;
using Entitytest.API.Crud.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entitytest.API.Crud.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly MyWorldDbContext _myWorldDbContext;
    public UserController(MyWorldDbContext myWorldDbContext)
    {
        _myWorldDbContext = myWorldDbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var Users = await _myWorldDbContext.User.ToListAsync();
        return Ok(Users);
    }

    [HttpGet]
    [Route("get-User-by-id")]
    public async Task<IActionResult> GetUserByIdAsync(int id)
    {
        var User = await _myWorldDbContext.User.FindAsync(id);
        return Ok(User);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(User User)
    {
        _myWorldDbContext.User.Add(User);
        await _myWorldDbContext.SaveChangesAsync();
        return Created($"/get-User-by-id?id={User.Id}", User);
    }

    [HttpPut]
    public async Task<IActionResult> PutAsync(User UserToUpdate)
    {
        _myWorldDbContext.User.Update(UserToUpdate);
        await _myWorldDbContext.SaveChangesAsync();
        return NoContent();
    }

    [Route("{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var UserToDelete = await _myWorldDbContext.User.FindAsync(id);
        if (UserToDelete == null)
        {
            return NotFound();
        }
        _myWorldDbContext.User.Remove(UserToDelete);
        await _myWorldDbContext.SaveChangesAsync();
        return NoContent();
    }
}