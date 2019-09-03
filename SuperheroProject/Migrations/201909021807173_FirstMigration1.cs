namespace SuperheroProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Superheroes", "FirstName", c => c.String());
            AddColumn("dbo.Superheroes", "LastName", c => c.String());
            DropColumn("dbo.Superheroes", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Superheroes", "name", c => c.String());
            DropColumn("dbo.Superheroes", "LastName");
            DropColumn("dbo.Superheroes", "FirstName");
        }
    }
}
