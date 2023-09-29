namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, InStock) " +
                "Values ( 'The Hangover', 5, 2023-09-25, 2009-07-29, 4)");
        }

        public override void Down()
        {
        }
    }
}
