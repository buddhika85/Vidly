namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesWithName : DbMigration
    {
        public override void Up()
        {            
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Three Months - Quately' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annualy' WHERE Id = 4");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM MembershipTypes WHERE Id IN (1, 2, 3, 4)");  // Truncate table
        }
    }
}
