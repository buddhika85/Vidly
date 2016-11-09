namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('Peter Perera', 1, 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('Kumar Shngak', 0, 2)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('Mahela Jaya', 1, 3)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('Arvinda De Sil', 0, 4)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Customers WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
