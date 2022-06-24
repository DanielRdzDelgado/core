using Microsoft.EntityFrameworkCore;
using Tienda.Models;

namespace Tienda.Datos
{
    public class ApplicationDBContext : DbContext //creamos la clase de conexion y hacemos herencia de DBContext que es el encargado de hacer el crud
    {
        
        //constructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options) //optios guarda los modelos
        {

        }


        //Aqui agregamos nuestros modelos 
        public DbSet<Categoria> Categoria { get; set; }


    }
}
