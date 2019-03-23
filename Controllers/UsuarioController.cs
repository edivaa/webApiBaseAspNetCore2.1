using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using webApiBaseAspNetCore2._1.Models;
using webApiBaseAspNetCore2._1.Data;

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
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return  await _context.Usuarios.ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetUsuario(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Usuario>> Post(Usuario value)
        {
            _context.Usuario.Add(value);
            await _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new {Id=value.Id},value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
