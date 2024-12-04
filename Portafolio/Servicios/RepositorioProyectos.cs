using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "https://aws.amazon.com",
                    ImageURL = "/imagenes/aws_logo.png"
                },
                 new Proyecto {
                    Titulo = "Microsoft",
                    Descripcion = "E-Commerce realizado en ASP.NET MVC",
                    Link = "https://macrosoft.com",
                    ImageURL = "/imagenes/azure_logo.png"
                },
                  new Proyecto {
                    Titulo = "Oracle",
                    Descripcion = "E-Commerce realizado en SQL",
                    Link = "https://oracle.com",
                    ImageURL = "/imagenes/oracle_logo.png"
                },
                   new Proyecto {
                    Titulo = "Google",
                    Descripcion = "E-Commerce realizado en Golang",
                    Link = "https://google.com",
                    ImageURL = "/imagenes/google_logo.png"
                }
            };
        }
    }

   
}
