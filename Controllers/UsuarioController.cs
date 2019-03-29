using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using webApiBaseAspNetCore2._1.Models;
using webApiBaseAspNetCore2._1.Data;
using webApiBaseAspNetCore2._1.Services;

namespace webApiBaseAspNetCore2._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
       
        private readonly TodoContext _context; 

        public UsuarioController(TodoContext context){
            _context = context;

            if(_context.Usuarios.Count()==0){

                _context.Usuarios.Add(
                    new Usuario { 
                        Nome="Antonio",
                        Telefone="321212313",
                        Email="anto@gmail.com"
                    }
                );

                _context.SaveChanges();
            }
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> Get()
        {
             //return UsuarioService.GetDadosUsuarios();   
             return await _context.Usuarios.ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> Get(long id)
        {
              var usuario = await _context.Usuarios.FindAsync(id);

              if(usuario == null){
                 return NotFound();
              }
              return usuario;
        }

        // POST api/values
        [HttpPost]
        public void Post(Usuario value)
        {
            _context.Usuarios.Add(value);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(long id, Usuario usuario)
        {
            
                if(id != usuario.Id ){
                    return BadRequest();
                }

                _context.Entry(usuario).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return NoContent();   
             
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var usuario = await _context.Usuarios.FindAsync(id); 

            if(usuario == null){

                return NotFound();
            } 

            _context.Usuarios.Remove(usuario);

            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
