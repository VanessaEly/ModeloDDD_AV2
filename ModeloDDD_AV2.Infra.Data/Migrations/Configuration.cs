using System.Data.Entity.Migrations;

namespace ModeloDDD_AV2.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.ProjetoModeloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ProjetoModeloContext context)
        {
        }
    }
}
