namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedInstructorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instructor",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        HireDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            DropColumn("dbo.People", "HireDate");
            DropColumn("dbo.People", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Discriminator", c => c.String(maxLength: 128));
            AddColumn("dbo.People", "HireDate", c => c.DateTime());
            DropForeignKey("dbo.Instructor", "Id", "dbo.People");
            DropIndex("dbo.Instructor", new[] { "Id" });
            DropTable("dbo.Instructor");
        }
    }
}
