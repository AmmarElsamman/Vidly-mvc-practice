namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RemoveOneCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = NULL WHERE Id = 2");
        }

        public override void Down()
        {
        }
    }
}
