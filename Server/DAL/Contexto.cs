using Microsoft.EntityFrameworkCore;
using RegistroTickets_Detalles.Shared.Models;

namespace RegistroTickets_Detalles.Server.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<TicketsDetalle> TicketsDetalle { get; set; }
    }
}
