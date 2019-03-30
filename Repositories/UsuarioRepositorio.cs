using System;
using System.Collections.Generic;
using webApiBaseAspNetCore2._1.Models;
using webApiBaseAspNetCore2._1.Data;

using Microsoft.EntityFrameworkCore;
namespace webApiBaseAspNetCore2._1.Repositories
{

    public class UsuarioRepositorio {

            private readonly TodoContext _context;
            public UsuarioRepositorio (TodoContext context)
            {
                _context = context;
            
            }

            // public IEnumerable<Usuario> GetUsuarios(){

            //    return  _context.Usuarios.ToList();
                
            // }  
    }


}
