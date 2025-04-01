using Microsoft.EntityFrameworkCore;

namespace eCommerce.Database
{
    public class eCommerceContext : DbContext
    {
        // Esse tipo de conexão não diferencia ambientes!
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True;");
        // }

        /*
        Para usar uma connection string diferente por ambiente precisamos:
            1) Configurar uma connection string em cada appsettings de acordo com o ambiente;
            2) Instanciar um configuration no Program.cs ou Startup.cs;
            3) Adicionar o serviço que usa o SQLServer se conectando em cada ambiente específico;
        */

        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
        {

        }

    }
}