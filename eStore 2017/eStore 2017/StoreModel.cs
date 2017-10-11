namespace StrollerStore
{
    using StrollerStore;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoreModel : DbContext
    {
        // Your context has been configured to use a 'StoreModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'eStore_2017.StoreModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StoreModel' 
        // connection string in the application configuration file.
        public StoreModel()
            : base("name=StoreModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Customer> Customers { get; set; }
    }

    
}