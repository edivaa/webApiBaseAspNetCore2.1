using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<IEnumerable<Usuario>> Get()
        {
             //return UsuarioService.GetDadosUsuarios();   
             return  _context.Usuarios.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
