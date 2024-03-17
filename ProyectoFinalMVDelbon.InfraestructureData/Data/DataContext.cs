using Microsoft.EntityFrameworkCore;
using ProyectoFinalMVDelbonDomain.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalMVDelbon.InfraestructureData.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<FichaClienteEntity> Fichas { get; set; }
        public DbSet <RegistroEntity> Registros { get; set; }
        public DbSet<UsuarioClienteEntity> UsuariosCliente { get; set; }
        public DbSet<UsuarioSalonEntity> UsuariosSalon { get; set; }

    }
}
