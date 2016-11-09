namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerTypeWithBirthDay : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '01/01/1985' WHERE Id = 4");
        }
        
        public override void Down()
        {
            Sql("UPDATE Customers SET BirthDate = NULL WHERE Id = 4");
        }
    }
}
