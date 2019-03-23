
using System.Collections.Generic;
using webApiBaseAspNetCore2._1.Models;
using webApiBaseAspNetCore2._1.Data;



namespace webApiBaseAspNetCore2._1.Services
{

public class UsuarioService {


        public static List<Usuario> GetDadosUsuarios()
                {
                    List<Usuario> dados = new List<Usuario>();

                    dados.Add(new Usuario()
                    {
                        Id=1, 
                        Nome="Antonio",
                        Telefone="321212313",
                        Email="anto@gmail.com"
                    });


                dados.Add(new Usuario()
                    { 
                        Id=2,
                        Nome="Paulo",
                        Telefone="321212313",
                        Email="paulo@gmail.com"
                    });

                    dados.Add(new Usuario()
                    { 
                        Id=3,
                        Nome="Fernando",
                        Telefone="99987889",
                        Email="fernC@gmail.com"
                    });

                    dados.Add(new Usuario()
                    { 
                        Id=4,
                        Nome="Marcelo",
                        Telefone="998989898",
                        Email="marcelo@gmail.com"
                    });

                    dados.Add(new Usuario()
                    { 
                        Id=5,
                        Nome="Antenou",
                        Telefone="335639993",
                        Email="antenou@gmail.com"
                    });

                    return dados;

                }
            }

}

