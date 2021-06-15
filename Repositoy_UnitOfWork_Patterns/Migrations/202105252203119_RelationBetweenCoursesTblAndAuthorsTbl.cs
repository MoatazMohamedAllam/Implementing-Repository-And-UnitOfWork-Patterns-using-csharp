namespace Repositoy_UnitOfWork_Patterns.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationBetweenCoursesTblAndAuthorsTbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Author_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Author_Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            DropColumn("dbo.Courses", "Author_Id");
        }
    }
}
