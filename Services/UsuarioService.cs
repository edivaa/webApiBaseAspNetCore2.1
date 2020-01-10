
using System.Collections.Generic;
using webApiBaseAspNetCore2._1.Models;
using webApiBaseAspNetCore2._1.Data;



namespace webApiBaseAspNetCore2._1.Services
{

public class UsuarioService {

        private readonly TodoContext _context;
        public UsuarioService(TodoContext context)
        {
            _context = context;
        } 
          

        // public static List<Usuario> GetDadosUsuarios()
        // {
                 

        //          return _context.Usuarios.ToList();

                
        // }
  }

}

