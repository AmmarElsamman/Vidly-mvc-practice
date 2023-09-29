namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertCustomersBirthdates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1/1/1989' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = '12/4/1998' WHERE Id = 2");
            Sql("UPDATE Customers SET Birthdate = '19/8/2003' WHERE Id = 3");
            Sql("UPDATE Customers SET Birthdate = '4/4/2003' WHERE Id = 4");
        }

        public override void Down()
        {
        }
    }
}
