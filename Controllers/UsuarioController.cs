using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using webApiBaseAspNetCore2._1.Services;
using webApiBaseAspNetCore2._1.Models;
using webApiBaseAspNetCore2._1.Data;

namespace webApiBaseAspNetCore2._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly TodoContext _context; 
        
        public UsuarioController (TodoContext context){

                   _context = context;
                   
                //    if(_context.Usuarios.Count()=0){

                //        _context.Add(
                //             new Usuario
                //            { 
                //             Nome="Fernando",
                //             Telefone="99987889",
                //             Email="fernC@gmail.com"
                //             );
                //    }

        }

         
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return   _context.Usuarios.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
