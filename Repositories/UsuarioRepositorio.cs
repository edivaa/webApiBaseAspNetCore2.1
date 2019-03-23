using System.Collections.Generic;
using webApiBaseAspNetCore2._1.Models;
using webApiBaseAspNetCore2._1.Data;


namespace webApiBaseAspNetCore2._1.Services
{

    public class UsuarioRepositorio {

            private readonly TodoContext _context;
            public UsuarioRepositorio (TodoContext context)
            {
                _context = context;
            
            }

            public static List<Usuario> GetUsuarios(){

                return _context.Usuarios.getList();
                
            }  
    }


}
