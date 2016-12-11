namespace ModeloDDD_AV2.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaisICollections : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AutoDeInfracao", "Processo_ProcessoId", c => c.Int());
            CreateIndex("dbo.AutoDeInfracao", "Processo_ProcessoId");
            AddForeignKey("dbo.AutoDeInfracao", "Processo_ProcessoId", "dbo.Processo", "ProcessoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AutoDeInfracao", "Processo_ProcessoId", "dbo.Processo");
            DropIndex("dbo.AutoDeInfracao", new[] { "Processo_ProcessoId" });
            DropColumn("dbo.AutoDeInfracao", "Processo_ProcessoId");
        }
    }
}
