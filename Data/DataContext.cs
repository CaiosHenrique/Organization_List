
using Organization_List.Models;

namespace Organization_List.Data
{

    public class DataContext : DbContext
    {

        public DbSet<Tarefas> TB_Tarefas {get; set;}
    }
}